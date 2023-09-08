using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace EMPRESA
{
    class empleados
    {
        String cadena;
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public empleados()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=EMPRESA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Empleados";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }

        public void ver(DataGridView DATA) 
        {
            DATA.DataSource = tabla;
        }

        public void ver(ComboBox COMBO)
        {
            COMBO.DisplayMember = "Nombre";
            COMBO.ValueMember = "DNI";
            COMBO.DataSource = tabla;
        }

        public void ver(ListBox lb) 
        {
            lb.DisplayMember = "Nombre";
            lb.ValueMember = "DNI";
            lb.DataSource = tabla;
        }
        public void ver2(DataGridView DATA)
        {
            DATA.Columns.Clear();
            DATA.Columns.Add("C1" , "DNI");
            DATA.Columns.Add("C2" , "DNI");

            foreach (DataRow fila in tabla.Rows) 
            {
                DATA.Rows.Add(fila["dni"], fila["Nombre"]);
            }
        }
        public void ver(DataGridView DATA, int Sector)
        {
            DATA.Rows.Clear();
           foreach(DataRow fila in tabla.Rows) 
           {
                if (fila["Sector"].ToString() == Sector.ToString()) 
                {
                    DATA.Rows.Add(fila["dni"], fila["Nombre"], fila["Sueldo"]);
                }
            }
        }
    }
}
