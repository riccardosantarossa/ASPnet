using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Prove_Connessione
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection cn;
        string strsql;
        SqlCommand cmd;
        SqlDataReader dr;
        string strcn = "Data Source= .\\SQLEXPRESS;Trusted_Connection=Yes;DATABASE=dbGardaland_Santarossa";

        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Creo e apro la connessione
            cn = new SqlConnection(strcn);
            cn.Open();

            //Popolo la combobox delle nazioni
            strsql = "SELECT * FROM tblNazioni ORDER BY nomeNazione";
            cmd = new SqlCommand(strsql,cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbNazioni.Items.Add(dr["nomeNazione"].ToString());
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}