namespace WindowsFormsApplication2
{
    partial class SharpMailOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpMailOrder));
            this.Calculate = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Sales = new System.Windows.Forms.Label();
            this.Bonus = new System.Windows.Forms.Label();
            this.Languages = new System.Windows.Forms.GroupBox();
            this.French = new System.Windows.Forms.RadioButton();
            this.English = new System.Windows.Forms.RadioButton();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.EmpIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.BonusTextBox = new System.Windows.Forms.TextBox();
            this.MitchImage = new System.Windows.Forms.PictureBox();
            this.Languages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MitchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 16);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click_1);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(92, 16);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click_1);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(51, 50);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(58, 112);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(161, 20);
            this.EmployeeName.TabIndex = 8;
            this.EmployeeName.Text = "Employee\'s Name :";
            this.EmployeeName.Click += new System.EventHandler(this.EmployeeName_Click_1);
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(58, 156);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(121, 20);
            this.EmployeeID.TabIndex = 9;
            this.EmployeeID.Text = "Employee ID :";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(58, 191);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(133, 20);
            this.Hours.TabIndex = 10;
            this.Hours.Text = "Hours Worked :";
            this.Hours.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sales
            // 
            this.Sales.AutoSize = true;
            this.Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(58, 237);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(109, 20);
            this.Sales.TabIndex = 11;
            this.Sales.Text = "Total Sales :";
            this.Sales.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bonus
            // 
            this.Bonus.AutoSize = true;
            this.Bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus.Location = new System.Drawing.Point(58, 284);
            this.Bonus.Name = "Bonus";
            this.Bonus.Size = new System.Drawing.Size(120, 20);
            this.Bonus.TabIndex = 12;
            this.Bonus.Text = "Sales Bonus :";
            this.Bonus.Click += new System.EventHandler(this.label5_Click);
            // 
            // Languages
            // 
            this.Languages.Controls.Add(this.French);
            this.Languages.Controls.Add(this.English);
            this.Languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Languages.Location = new System.Drawing.Point(223, 9);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(153, 64);
            this.Languages.TabIndex = 13;
            this.Languages.TabStop = false;
            this.Languages.Text = "Language";
            this.Languages.Enter += new System.EventHandler(this.Languages_Enter);
            // 
            // French
            // 
            this.French.AutoSize = true;
            this.French.Location = new System.Drawing.Point(24, 41);
            this.French.Name = "French";
            this.French.Size = new System.Drawing.Size(73, 20);
            this.French.TabIndex = 1;
            this.French.TabStop = true;
            this.French.Text = "French";
            this.French.UseVisualStyleBackColor = true;
            this.French.CheckedChanged += new System.EventHandler(this.French_CheckedChanged);
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Location = new System.Drawing.Point(24, 21);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(77, 20);
            this.English.TabIndex = 0;
            this.English.TabStop = true;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Location = new System.Drawing.Point(247, 112);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(225, 20);
            this.EmpNameTextBox.TabIndex = 15;
            this.EmpNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmpIDTextBox
            // 
            this.EmpIDTextBox.Location = new System.Drawing.Point(247, 155);
            this.EmpIDTextBox.Name = "EmpIDTextBox";
            this.EmpIDTextBox.Size = new System.Drawing.Size(225, 20);
            this.EmpIDTextBox.TabIndex = 17;
            this.EmpIDTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(247, 190);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(225, 20);
            this.HoursTextBox.TabIndex = 18;
            this.HoursTextBox.TextChanged += new System.EventHandler(this.HoursTextBox_TextChanged);
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Location = new System.Drawing.Point(247, 236);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(225, 20);
            this.SalesTextBox.TabIndex = 19;
            // 
            // BonusTextBox
            // 
            this.BonusTextBox.Location = new System.Drawing.Point(247, 284);
            this.BonusTextBox.Name = "BonusTextBox";
            this.BonusTextBox.ReadOnly = true;
            this.BonusTextBox.Size = new System.Drawing.Size(225, 20);
            this.BonusTextBox.TabIndex = 20;
            // 
            // MitchImage
            // 
            this.MitchImage.Image = global::WindowsFormsApplication2.Properties.Resources.MitchLogo;
            this.MitchImage.Location = new System.Drawing.Point(382, 16);
            this.MitchImage.Name = "MitchImage";
            this.MitchImage.Size = new System.Drawing.Size(101, 62);
            this.MitchImage.TabIndex = 21;
            this.MitchImage.TabStop = false;
            this.MitchImage.Click += new System.EventHandler(this.Calculate_Click_1);
            // 
            // SharpMailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 320);
            this.Controls.Add(this.MitchImage);
            this.Controls.Add(this.BonusTextBox);
            this.Controls.Add(this.SalesTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.EmpIDTextBox);
            this.Controls.Add(this.EmpNameTextBox);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.Bonus);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Calculate);
            this.Name = "SharpMailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Mail Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Languages.ResumeLayout(false);
            this.Languages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MitchImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Label Sales;
        private System.Windows.Forms.Label Bonus;
        private System.Windows.Forms.GroupBox Languages;
        private System.Windows.Forms.RadioButton French;
        private System.Windows.Forms.RadioButton English;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.TextBox EmpIDTextBox;
        private System.Windows.Forms.TextBox BonusTextBox;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.PictureBox MitchImage;
    }
}

