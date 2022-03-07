namespace MyDataManagerWinForms
{
    partial class AddUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.conveniencelabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ConvenienceComboBox = new System.Windows.Forms.ComboBox();
            this.pricePointComboBox = new System.Windows.Forms.ComboBox();
            this.CuisineComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cuisine";
            // 
            // conveniencelabel
            // 
            this.conveniencelabel.AutoSize = true;
            this.conveniencelabel.Location = new System.Drawing.Point(12, 153);
            this.conveniencelabel.Name = "conveniencelabel";
            this.conveniencelabel.Size = new System.Drawing.Size(76, 15);
            this.conveniencelabel.TabIndex = 19;
            this.conveniencelabel.Text = "Convenience";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 75);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "Price";
            // 
            // ConvenienceComboBox
            // 
            this.ConvenienceComboBox.FormattingEnabled = true;
            this.ConvenienceComboBox.Location = new System.Drawing.Point(12, 171);
            this.ConvenienceComboBox.Name = "ConvenienceComboBox";
            this.ConvenienceComboBox.Size = new System.Drawing.Size(180, 23);
            this.ConvenienceComboBox.TabIndex = 17;
            // 
            // pricePointComboBox
            // 
            this.pricePointComboBox.FormattingEnabled = true;
            this.pricePointComboBox.Location = new System.Drawing.Point(12, 93);
            this.pricePointComboBox.Name = "pricePointComboBox";
            this.pricePointComboBox.Size = new System.Drawing.Size(180, 23);
            this.pricePointComboBox.TabIndex = 16;
            // 
            // CuisineComboBox
            // 
            this.CuisineComboBox.FormattingEnabled = true;
            this.CuisineComboBox.Location = new System.Drawing.Point(12, 242);
            this.CuisineComboBox.Name = "CuisineComboBox";
            this.CuisineComboBox.Size = new System.Drawing.Size(180, 23);
            this.CuisineComboBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(12, 26);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(180, 23);
            this.txtBoxName.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conveniencelabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ConvenienceComboBox);
            this.Controls.Add(this.pricePointComboBox);
            this.Controls.Add(this.CuisineComboBox);
            this.Name = "AddUpdateForm";
            this.Text = "AddUpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.AddUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label conveniencelabel;
        private Label priceLabel;
        private ComboBox ConvenienceComboBox;
        private ComboBox pricePointComboBox;
        private ComboBox CuisineComboBox;
        private Label label1;
        private TextBox txtBoxName;
        private Button btnSave;
        private Button btnCancel;
    }
}