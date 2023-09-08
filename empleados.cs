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
    }
}
