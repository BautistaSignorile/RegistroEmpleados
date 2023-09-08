
namespace EMPRESA
{
    partial class Empresa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DATA = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.AllowUserToAddRows = false;
            this.DATA.AllowUserToDeleteRows = false;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.Location = new System.Drawing.Point(12, 21);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(776, 417);
            this.DATA.TabIndex = 0;
            this.DATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ir al form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DATA);
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA;
        private System.Windows.Forms.Button button1;
    }
}

