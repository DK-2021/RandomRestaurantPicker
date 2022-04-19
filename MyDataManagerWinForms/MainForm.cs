using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDataManagerDataOperations;
using MyDataModels;
using System.Diagnostics;

namespace MyDataManagerWinForms
{
    public delegate void RespondToMessageEvent(string message);

    public partial class MainForm : Form
    {
        private static IConfigurationRoot _configuration;
        public static DbContextOptionsBuilder<DataDbContext> _optionsBuilder;
        Random rand = new Random();
        private static List<Restaurant> restaurants; 
        private IList<Cuisine> Cuisines = new List<Cuisine>();
        //private IList<Price> pricePoint = new List<Price>();
        private IList<Convenience> convenience = new List<Convenience>();

        public MainForm()
        {
            InitializeComponent();
            
        }
        
        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDataManagerData"));
        }
        private void RespondToMessage(string message)
        {
            MessageBox.Show(message);
            Refresh();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            BuildOptions();

            var dataoperations = new DataOperations();
            Cuisines = Task.Run(() => dataoperations.GetCuisines()).Result;
            CuisineComboBox.DataSource = Cuisines;
          
            pricePointComboBox.DataSource = Enum.GetValues(typeof(Price));

            convenience = Task.Run(() => dataoperations.GetConveniences()).Result;
            ConvenienceComboBox.DataSource = convenience;

            restaurants = Task.Run (() => dataoperations.GetRestaurants()).Result;
            

            dgItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgItems.ReadOnly = true;
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cboBox = sender as ComboBox;
            var selItem = cboBox.SelectedItem as Cuisine;

            LoadGrid(selItem);
        }

        private void LoadGrid(Cuisine selectedItem)
        {
            Debug.WriteLine($"Selected Item {selectedItem.Id}| {selectedItem.Type}");
            //var curData = Items.Where(x => x.CategoryId == selectedItem.Id).OrderBy(x => x.Name).ToList();
            //dgItems.DataSource = curData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var priceValue = (Price)pricePointComboBox.SelectedValue;
            var convValue = (Convenience)ConvenienceComboBox.SelectedValue;
            var cuisValue = (Cuisine)CuisineComboBox.SelectedValue;

            
            var myOps = new DataOperations();
            var result = Task.Run(() => myOps.GetMatches((int)priceValue, convValue, cuisValue)).Result;
            dgItems.DataSource = result.Select(x => new
            {
                restaurantName = x.Name,
                Price = priceValue,
                Convenience = x.Convenience.Type,
                Cuisine = x.Cuisine.Type


            }).ToList();

        }

        private void btnSurpriseMe_Click(object sender, EventArgs e)
        {
            //if list is full, return one at random. otherwise, return random restaurant from entire db
            if (restaurants?.Count > 0)
            {
                MessageBox.Show(restaurants[rand.Next(restaurants.Count)].ToString());
            }
            else
            {

                //using (var db = new DataDbContext(_optionsBuilder.Options))
                //{
                //    restaurants = db.Restaurants.ToListAsync().Result;
                var choice = rand.Next(restaurants.Count);

                MessageBox.Show(restaurants[choice].ToString());
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddUpdateForm addupdate = new AddUpdateForm();
            addupdate.Responding += new RespondToMessageEvent(RespondToMessage);
            addupdate.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsSelected())
            {
                var restaurantData = dgItems.SelectedRows[0].Cells;
                var updateId = (int)restaurantData[0].Value;
                using (var db = new DataDbContext(_optionsBuilder.Options))
                {
                    var restaurant = db.Restaurants.SingleOrDefault(x => x.Id == updateId);
                    if (restaurant != null)
                    {
                        AddUpdateForm addupdate = new AddUpdateForm(restaurant);
                        addupdate.Responding += new RespondToMessageEvent(RespondToMessage);
                        addupdate.ShowDialog();
                    }
                }
            }
            else
            {
                NothingSelected();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsSelected())
            {
                var restaurantData = dgItems.SelectedRows[0].Cells;
                //ask user to confirm deletion
                var userSelection = MessageBox.Show($"Delete selected restaurant from the database?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //delete the selected restaurant from the database
                if (userSelection == DialogResult.OK)
                {
                    var deleteId = (int)restaurantData[0].Value;
                    using (var db = new DataDbContext(_optionsBuilder.Options))
                    {
                        var restaurant = db.Restaurants.SingleOrDefault(x => x.Id == deleteId);
                        if (restaurant != null)
                        {
                            db.Restaurants.Remove(restaurant);
                            db.SaveChanges();
                            Refresh();
                        }
                    }
                }
            }
            else
            {
                NothingSelected();
            }
        }

        private bool IsSelected()
        {
            if (dgItems.SelectedRows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void NothingSelected()
        {
            MessageBox.Show("Nothing is selected.");
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            var gettingData = new GetData();
            gettingData.GetDataAsync();
        }

        
    }
}