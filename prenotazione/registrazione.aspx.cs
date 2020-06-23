using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prenotazione
{
    public partial class registrazione : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

		protected void Button1_Click(object sender, EventArgs e)
		{
            if (DAL.checkMail(TXTmail.Text)) 
            {
                LBLerrMail.Text = "* ATTENZIONE indirizzo mail gia in uso";
            }
		}
	}
}