namespace Odev9
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
            this.dgrwCars = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxDailyPrice = new System.Windows.Forms.TextBox();
            this.tbxModelYear = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCars)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrwCars
            // 
            this.dgrwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwCars.Location = new System.Drawing.Point(12, 12);
            this.dgrwCars.Name = "dgrwCars";
            this.dgrwCars.RowTemplate.Height = 25;
            this.dgrwCars.Size = new System.Drawing.Size(756, 171);
            this.dgrwCars.TabIndex = 0;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxCity);
            this.gbxAdd.Controls.Add(this.tbxDailyPrice);
            this.gbxAdd.Controls.Add(this.tbxModelYear);
            this.gbxAdd.Controls.Add(this.tbxModel);
            this.gbxAdd.Controls.Add(this.tbxBrand);
            this.gbxAdd.Controls.Add(this.tbxId);
            this.gbxAdd.Controls.Add(this.lblCity);
            this.gbxAdd.Controls.Add(this.lblDailyPrice);
            this.gbxAdd.Controls.Add(this.lblModelYear);
            this.gbxAdd.Controls.Add(this.lblModel);
            this.gbxAdd.Controls.Add(this.lblBrand);
            this.gbxAdd.Controls.Add(this.lblId);
            this.gbxAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbxAdd.Location = new System.Drawing.Point(31, 212);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(391, 289);
            this.gbxAdd.TabIndex = 14;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "groupBox1";
            this.gbxAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(246, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCity.Location = new System.Drawing.Point(231, 193);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 29);
            this.tbxCity.TabIndex = 25;
            // 
            // tbxDailyPrice
            // 
            this.tbxDailyPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDailyPrice.Location = new System.Drawing.Point(231, 158);
            this.tbxDailyPrice.Name = "tbxDailyPrice";
            this.tbxDailyPrice.Size = new System.Drawing.Size(100, 29);
            this.tbxDailyPrice.TabIndex = 24;
            // 
            // tbxModelYear
            // 
            this.tbxModelYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxModelYear.Location = new System.Drawing.Point(231, 123);
            this.tbxModelYear.Name = "tbxModelYear";
            this.tbxModelYear.Size = new System.Drawing.Size(100, 29);
            this.tbxModelYear.TabIndex = 23;
            // 
            // tbxModel
            // 
            this.tbxModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxModel.Location = new System.Drawing.Point(231, 88);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 29);
            this.tbxModel.TabIndex = 22;
            // 
            // tbxBrand
            // 
            this.tbxBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBrand.Location = new System.Drawing.Point(231, 53);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(100, 29);
            this.tbxBrand.TabIndex = 21;
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxId.Location = new System.Drawing.Point(231, 18);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 29);
            this.tbxId.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(59, 201);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 21);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "label1";
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDailyPrice.Location = new System.Drawing.Point(59, 166);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(52, 21);
            this.lblDailyPrice.TabIndex = 18;
            this.lblDailyPrice.Text = "label1";
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModelYear.Location = new System.Drawing.Point(59, 131);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(52, 21);
            this.lblModelYear.TabIndex = 17;
            this.lblModelYear.Text = "label1";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(59, 96);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 21);
            this.lblModel.TabIndex = 16;
            this.lblModel.Text = "label1";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(59, 61);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 21);
            this.lblBrand.TabIndex = 15;
            this.lblBrand.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(59, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 21);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgrwCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCars)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgrwCars;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private TextBox tbxCity;
        private TextBox tbxDailyPrice;
        private TextBox tbxModelYear;
        private TextBox tbxModel;
        private TextBox tbxBrand;
        private TextBox tbxId;
        private Label lblCity;
        private Label lblDailyPrice;
        private Label lblModelYear;
        private Label lblModel;
        private Label lblBrand;
        private Label lblId;
    }
}