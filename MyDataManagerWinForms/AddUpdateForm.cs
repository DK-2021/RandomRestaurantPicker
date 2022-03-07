using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataManagerWinForms
{
    public partial class AddUpdateForm : Form
    {
        private static IConfigurationRoot _configuration;
        private static DbContextOptionsBuilder<DataDbContext> _optionsBuilder;
        private IList<Cuisine> Cuisines = new List<Cuisine>();
        private IList<Convenience> convenience = new List<Convenience>();
        public event RespondToMessageEvent Responding;

        //private bool updating;
        private Restaurant updateRestaurant;
        public AddUpdateForm()
        {
            InitializeComponent();
            //updating = false;
        }

        public AddUpdateForm(Restaurant restaurant)
        {
            InitializeComponent();
            txtBoxName.Text = restaurant.Name;
            pricePointComboBox.SelectedItem = restaurant.Price;
            ConvenienceComboBox.SelectedItem = restaurant.Convenience;
            CuisineComboBox.SelectedItem = restaurant.Cuisine;
            updateRestaurant = restaurant;
            //updating = true;
        }

        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDataManagerData"));
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            BuildOptions();

            using (var db = new DataDbContext(_optionsBuilder.Options))
            {
                Cuisines = db.Cuisines.OrderBy(x => x.Type).ToList();
                CuisineComboBox.DataSource = Cuisines;
            }

            pricePointComboBox.DataSource = Enum.GetValues(typeof(Price));

            using (var db = new DataDbContext(_optionsBuilder.Options))
            {
                convenience = db.Conveniences.OrderBy(x => x.Type).ToList();
                ConvenienceComboBox.DataSource = convenience;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (updateRestaurant != null)
            {
                //update stuff
                using (var db = new DataDbContext(_optionsBuilder.Options))
                {
                    var restaurant = db.Restaurants.SingleOrDefault(x => x.Id == updateRestaurant.Id); 
                    if (restaurant != null)
                    {
                        restaurant.Name = txtBoxName.Text;
                        restaurant.Price = (int)pricePointComboBox.SelectedItem;
                        restaurant.Convenience = (Convenience)ConvenienceComboBox.SelectedItem;
                        restaurant.Cuisine = (Cuisine)CuisineComboBox.SelectedItem;
                        db.SaveChanges();

                        if(Responding != null)
                        {
                            Responding.Invoke("Updated");
                        }
                    }
                }
                this.Close();
            }
            else
            {
                if (string.IsNullOrEmpty(txtBoxName.Text))
                {
                    MessageBox.Show("Please enter the name of the restaurant.");
                }
                else
                {
                    //actually add something
                    var _restaurant = new Restaurant();

                    var selectedConv = (Convenience)ConvenienceComboBox.SelectedItem;
                    var selectedCuis = (Cuisine)CuisineComboBox.SelectedItem;
                    var selectedPrice = (int)this.pricePointComboBox.SelectedItem;

                    _restaurant.Price = selectedPrice;
                    _restaurant.ConvenienceId = selectedConv.Id;
                    _restaurant.CuisineId = selectedCuis.Id;
                    _restaurant.Name = txtBoxName.Text;

                    using (var db = new DataDbContext(_optionsBuilder.Options))
                    {
                        db.Add(_restaurant);
                        db.SaveChanges();
                        if (Responding != null)
                        {
                            Responding.Invoke("Added");
                        }
                    }

                    MessageBox.Show("Restaurant added.");
                    this.Close();
                }
            }
            
        }

        private void AddUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MainForm.Refresh();???
        }
    }
}
