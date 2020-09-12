using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebFacturaMvc.Reportes
{
    public partial class frmReporteFactura : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand comando;
        SqlDataAdapter adapter;
        SqlParameter param;
        string idVenta;


        protected void Page_Load(object sender, EventArgs e)
        {
            //string constr = ConfigurationManager.ConnectionStrings["FerreteriaDiplomadoEntities"].ToString();
            //con = new SqlConnection(constr);
            con = new SqlConnection("Data Source = RBSDL02929\\DESASQLSERVER; Initial Catalog = FerreteriaDiplomado; Persist Security Info = True; User ID = sa; Password = Prueba01");
            if (!IsPostBack)
            {
                renderReport();

            }
        }

        public void renderReport()
        {
            idVenta = Request.QueryString.Get("IdVenta");

            DataTable dt = cargar(idVenta);
            ReportDataSource rds = new ReportDataSource("DataSet1",dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = "Reportes/rptFactura.rdlc";

            //parameters
            ReportParameter[] rptParams = new ReportParameter[]
            {
                new ReportParameter("idVenta",idVenta.ToString())
        };
            ReportViewer1.LocalReport.Refresh();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        public DataTable cargar(string codigoventa)
        {
            DataTable dt = new DataTable();
            //string constr = ConfigurationManager.ConnectionStrings["FerreteriaDiplomadoEntities"].ToString();
            //con = new SqlConnection(constr);
            using (SqlConnection cn=new SqlConnection("Data Source = RBSDL02929\\DESASQLSERVER; Initial Catalog = FerreteriaDiplomado; Persist Security Info = True; User ID = sa; Password = Prueba01"))
            {
                
                SqlCommand cmd = new SqlCommand("sp_reporte_venta",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = idVenta;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt); 
            }
            return dt;
           
        }
    }
}