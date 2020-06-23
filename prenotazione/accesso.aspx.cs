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
        {
            
            if (Session["NewUser"] != null) 
            {
                LBLnewUser.Text = "Registrazione effettuata con successo";
                Session.Contents.Remove("NewUser");
            }
        }
    }
}