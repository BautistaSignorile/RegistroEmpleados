
namespace EMPRESA
{
    partial class Form3
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
            this.DATA2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DATA2)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA2
            // 
            this.DATA2.AllowUserToAddRows = false;
            this.DATA2.AllowUserToDeleteRows = false;
            this.DATA2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA2.Location = new System.Drawing.Point(12, 12);
            this.DATA2.Name = "DATA2";
            this.DATA2.ReadOnly = true;
            this.DATA2.Size = new System.Drawing.Size(417, 200);
            this.DATA2.TabIndex = 0;
            this.DATA2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA2_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 373);
            this.Controls.Add(this.DATA2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA2;
    }
}