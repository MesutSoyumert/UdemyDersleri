namespace Odev6
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
            this.lbxCars = new System.Windows.Forms.ListBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCars
            // 
            this.lbxCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCars.FormattingEnabled = true;
            this.lbxCars.ItemHeight = 21;
            this.lbxCars.Location = new System.Drawing.Point(12, 129);
            this.lbxCars.Name = "lbxCars";
            this.lbxCars.Size = new System.Drawing.Size(120, 172);
            this.lbxCars.TabIndex = 1;
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCars.Location = new System.Drawing.Point(12, 99);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(52, 21);
            this.lblCars.TabIndex = 2;
            this.lblCars.Text = "label1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToCart.Location = new System.Drawing.Point(138, 129);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(146, 81);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "button1";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbxCart
            // 
            this.lbxCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 21;
            this.lbxCart.Location = new System.Drawing.Point(328, 129);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(120, 172);
            this.lbxCart.TabIndex = 4;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(328, 99);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(52, 21);
            this.lblCart.TabIndex = 5;
            this.lblCart.Text = "label2";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromCart.Location = new System.Drawing.Point(469, 129);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(170, 81);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "button2";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(181, 35);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(72, 30);
            this.lblProjectName.TabIndex = 7;
            this.lblProjectName.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 588);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.lbxCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxCars;
        private Label lblCars;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveFromCart;
        private Label lblProjectName;
    }
}