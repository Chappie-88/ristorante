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
            

            if (Session["login"] != null)
            {
                Response.Redirect("homepage.aspx", true);
            }
            if (Session["NewUser"] != null) 
            {
                LBLnewUser.Text = "Registrazione effettuata con successo";
                Session.Contents.Remove("NewUser");
            }
            
        }

		protected void Button1_Click(object sender, EventArgs e)
		{
            if (DAL.Login(TXTmail.Text, TXTpass.Text))
            {
                Session["username"] = "prova";
                Session["islogged"] = true;
                /*Response.Redirect(".aspx", true); */ /*inserire link a pagina di prenotazione*/
            }
            LBLnewUser.Text = "Indiritto mail o Password sconosciuti, verificare e riprovare, oppure registrarsi";
        }
	}
}