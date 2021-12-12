namespace Odev7
{
    partial class Form1
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
            this.btnRemoveFromCars = new System.Windows.Forms.Button();
            this.lblCarsListText = new System.Windows.Forms.Label();
            this.lbxCarsList = new System.Windows.Forms.ListBox();
            this.tbxCarName = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveFromCars
            // 
            this.btnRemoveFromCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromCars.Location = new System.Drawing.Point(12, 379);
            this.btnRemoveFromCars.Name = "btnRemoveFromCars";
            this.btnRemoveFromCars.Size = new System.Drawing.Size(135, 30);
            this.btnRemoveFromCars.TabIndex = 0;
            this.btnRemoveFromCars.UseVisualStyleBackColor = true;
            this.btnRemoveFromCars.Click += new System.EventHandler(this.btnRemoveFromCars_Click);
            // 
            // lblCarsListText
            // 
            this.lblCarsListText.AutoSize = true;
            this.lblCarsListText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarsListText.Location = new System.Drawing.Point(6, 60);
            this.lblCarsListText.Name = "lblCarsListText";
            this.lblCarsListText.Size = new System.Drawing.Size(52, 21);
            this.lblCarsListText.TabIndex = 1;
            this.lblCarsListText.Text = "label1";
            // 
            // lbxCarsList
            // 
            this.lbxCarsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCarsList.FormattingEnabled = true;
            this.lbxCarsList.ItemHeight = 21;
            this.lbxCarsList.Location = new System.Drawing.Point(6, 97);
            this.lbxCarsList.Name = "lbxCarsList";
            this.lbxCarsList.Size = new System.Drawing.Size(141, 256);
            this.lbxCarsList.TabIndex = 2;
            // 
            // tbxCarName
            // 
            this.tbxCarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCarName.Location = new System.Drawing.Point(409, 97);
            this.tbxCarName.Name = "tbxCarName";
            this.tbxCarName.Size = new System.Drawing.Size(286, 29);
            this.tbxCarName.TabIndex = 3;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCar.Location = new System.Drawing.Point(581, 133);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(114, 30);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "button2";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(209, 25);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(72, 30);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "label1";
            this.lblProjectName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.tbxCarName);
            this.Controls.Add(this.lbxCarsList);
            this.Controls.Add(this.lblCarsListText);
            this.Controls.Add(this.btnRemoveFromCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRemoveFromCars;
        private Label lblCarsListText;
        private ListBox lbxCarsList;
        private TextBox tbxCarName;
        private Button btnAddCar;
        private Label lblProjectName;
    }
}