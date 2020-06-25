using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prenotazione
{
    public partial class accedi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {/*nascondere pulsante accedi ed esci*/
            Session["Page"] = "accesso";

            if (Session["islogged"] != null)
            {
                Response.Redirect("homepage.aspx", true);
            }
            if (Session["NewUser"] != null) 
            {
                LBLnewUser.Text = "Registrazione effettuata con successo";
                Session.Contents.Remove("NewUser");
            }
            
        }

		protected void BTMaccedi_Click(object sender, EventArgs e)
		{
            if (TXTmail.Text != "")
            {
                if (TXTpass.Text == "")
                { LBLnewUser.Text = "Inserire mail e password per accedere"; }
                else
                {
                    if (DAL.Login(TXTmail.Text, TXTpass.Text))
                    {
                        Session["IDuser"] = DAL.ID;
                        Session["islogged"] = true;
                        Response.Redirect("homepage.aspx", true);  /*inserire link a pagina di prenotazione*/
                    }
                    LBLnewUser.Text = "Indirizzo mail o Password sconosciuti, verificare e riprovare, oppure registrarsi";
                   
                }
            }
        }
	}
}