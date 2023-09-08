using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            empleados oEmpleados = new empleados();
            oEmpleados.ver2(DATA2);
        }

        private void DATA2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
