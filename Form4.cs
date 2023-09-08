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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            sectores oSectores = new sectores();
            oSectores.ver(comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            empleados oEmpleados = new empleados();
            oEmpleados.ver(dataGridView1, Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
