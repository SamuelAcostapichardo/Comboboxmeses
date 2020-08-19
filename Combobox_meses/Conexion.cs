using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Combobox_meses
{
    public class Conexion
    {
        private readonly string conexion = ConfigurationManager.ConnectionStrings["Combobox_meses.Properties.Settings.Setting"].ConnectionString;


        public SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }

        SqlDataReader rd;

        public void Llenarcombo(ComboBox b)
        {
            using (var Sqlcon = GetConnection())
            {
                Sqlcon.Open();
                try
                {
                    using (var Sqlcmd = new SqlCommand ("select Meses from Mes", Sqlcon))
                    {                    
                       rd = Sqlcmd.ExecuteReader();
                       while (rd.Read())
                       {
                            b.Items.Add(rd["Meses"].ToString());                           
                       }                       
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar los meses");
                }
            }
        }


       


    }
}
