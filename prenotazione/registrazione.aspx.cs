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
            else
            {
                Person p = new Person();
                p.name = TXTname.Text;
                p.surname = TXTsurname.Text;
                p.tel = TXTtel.Text;
                p.email = TXTmail.Text;
                p.pass = TXTpass.Text;

                DAL.insertUser(p);
                Session["NewUsere"] = true;
                Response.Redirect("accesso.aspx", true);

            }
		}
	}
}