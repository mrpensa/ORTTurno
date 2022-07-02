using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ORTTurno.Data
{
    public class ConexionDb
    {
        private static SqlConnection instacia;


        private ConexionDb()
        {

        }

        public static SqlConnection Instance()
        {
            if (instacia == null)
            {
                instacia = new SqlConnection("Data Source=DESKTOP-TQI9FIK;Initial Catalog=DB_Acceso;Integrated Security=true");
            }
            return instacia;
        }
    }
}