using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Model.Dao
{
   public class ConexionDB
    {


        private static ConexionDB objConexionDB=null;
        private SqlConnection con;

        private ConexionDB()
        {
            
            con = new SqlConnection("Data Source=RBSDL02929\\DESASQLSERVER;Initial Catalog=FerreteriaDiplomado;Persist Security Info=True;User ID=sa;Password=Prueba01");
            //string constr = ConfigurationManager.ConnectionStrings["FerreteriaDiplomadoEntities"].ToString();
            //con = new SqlConnection(constr);
        }

        public static ConexionDB saberEstado()
        {
            if (objConexionDB == null)
            {
                objConexionDB = new ConexionDB();

            }
            return objConexionDB;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void closeDB()
        {
            objConexionDB = null;
        }
    }
}
