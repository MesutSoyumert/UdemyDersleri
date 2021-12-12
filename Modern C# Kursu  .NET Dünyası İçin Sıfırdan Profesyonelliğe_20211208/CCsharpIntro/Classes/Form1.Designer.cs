namespace Classes
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.dgrvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 21;
            this.lbxStudents.Location = new System.Drawing.Point(21, 74);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(214, 235);
            this.lbxStudents.TabIndex = 0;
            // 
            // dgrvStudents
            // 
            this.dgrvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvStudents.Location = new System.Drawing.Point(280, 74);
            this.dgrvStudents.Name = "dgrvStudents";
            this.dgrvStudents.RowTemplate.Height = 25;
            this.dgrvStudents.Size = new System.Drawing.Size(387, 235);
            this.dgrvStudents.TabIndex = 1;
            this.dgrvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrwStudents_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrvStudents);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbxStudents;
        private DataGridView dgrvStudents;
    }
}