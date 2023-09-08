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
    class sectores
    {
        String cadena;
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public sectores()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=EMPRESA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Sectores";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }
        public void ver(ComboBox COMBO)
        {
            COMBO.DisplayMember = "Nombre";
            COMBO.ValueMember = "Sector";
            COMBO.DataSource = tabla;
        }
    }
}
