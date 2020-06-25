using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prenotazione
{
	public partial class Site1 : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{/*risposta al commento di prova, ora pusho*/
			BTMesc.Visible =true;
			if (Session["islogged"] == null)
			{
				BTMesc.Visible = false;
				switch (Session["Page"])
				{
					case "accesso":
						BTMlogin.Visible = false;
						break;
					case "registrazione":
						BTMLog.Visible = false;
						break;
				}
			}
			else
			{
				BTMlogin.Visible = false;
				BTMLog.Visible = false;
			}
			

			

		}

		protected void BTMnewLog_Click(object sender, EventArgs e)
		{
			Response.Redirect("registrazione.aspx", true);

		}

		protected void BTMlogin_Click(object sender, EventArgs e)
		{
			Response.Redirect("accesso.aspx", true);
		}
	}
}