namespace MyDataManagerWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CuisineComboBox = new System.Windows.Forms.ComboBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.pricePointComboBox = new System.Windows.Forms.ComboBox();
            this.ConvenienceComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.conveniencelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSurpriseMe = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CuisineComboBox
            // 
            this.CuisineComboBox.FormattingEnabled = true;
            this.CuisineComboBox.Location = new System.Drawing.Point(618, 33);
            this.CuisineComboBox.Name = "CuisineComboBox";
            this.CuisineComboBox.Size = new System.Drawing.Size(180, 23);
            this.CuisineComboBox.TabIndex = 9;
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(12, 156);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowTemplate.Height = 25;
            this.dgItems.Size = new System.Drawing.Size(786, 274);
            this.dgItems.TabIndex = 1;
            // 
            // pricePointComboBox
            // 
            this.pricePointComboBox.FormattingEnabled = true;
            this.pricePointComboBox.Location = new System.Drawing.Point(246, 33);
            this.pricePointComboBox.Name = "pricePointComboBox";
            this.pricePointComboBox.Size = new System.Drawing.Size(180, 23);
            this.pricePointComboBox.TabIndex = 10;
            // 
            // ConvenienceComboBox
            // 
            this.ConvenienceComboBox.FormattingEnabled = true;
            this.ConvenienceComboBox.Location = new System.Drawing.Point(432, 33);
            this.ConvenienceComboBox.Name = "ConvenienceComboBox";
            this.ConvenienceComboBox.Size = new System.Drawing.Size(180, 23);
            this.ConvenienceComboBox.TabIndex = 11;
            
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(246, 15);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price";
            // 
            // conveniencelabel
            // 
            this.conveniencelabel.AutoSize = true;
            this.conveniencelabel.Location = new System.Drawing.Point(432, 15);
            this.conveniencelabel.Name = "conveniencelabel";
            this.conveniencelabel.Size = new System.Drawing.Size(76, 15);
            this.conveniencelabel.TabIndex = 13;
            this.conveniencelabel.Text = "Convenience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cuisine";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(618, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSurpriseMe
            // 
            this.btnSurpriseMe.Location = new System.Drawing.Point(712, 120);
            this.btnSurpriseMe.Name = "btnSurpriseMe";
            this.btnSurpriseMe.Size = new System.Drawing.Size(86, 30);
            this.btnSurpriseMe.TabIndex = 17;
            this.btnSurpriseMe.Text = "Surprise Me!";
            this.btnSurpriseMe.UseVisualStyleBackColor = true;
            this.btnSurpriseMe.Click += new System.EventHandler(this.btnSurpriseMe_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(561, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(723, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(642, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(514, 120);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(86, 30);
            this.LoadData.TabIndex = 22;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 468);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSurpriseMe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conveniencelabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ConvenienceComboBox);
            this.Controls.Add(this.pricePointComboBox);
            this.Controls.Add(this.CuisineComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgItems);
            this.Name = "MainForm";
            this.Text = "Restaurant Picker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private ComboBox CuisineComboBox;
        private DataGridView dgItems;
        private ComboBox pricePointComboBox;
        private ComboBox ConvenienceComboBox;
        private Label priceLabel;
        private Label conveniencelabel;
        private Label label3;
        private Button btnSearch;
        private Button btnSurpriseMe;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button LoadData;
    }
}