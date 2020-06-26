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
				Session["islogged"] = DAL.userlogged;
				LBLuser.Text = "Benvenuto " + DAL.userlogged;
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

		protected void BTMesc_Click(object sender, EventArgs e)
		{
			DAL.userlogged = null;
			DAL.ID = null;
			Session.Contents.RemoveAll();

		}

		protected void BTMprenota_Click(object sender, EventArgs e)
		{if (Session["islogged"] == null)
			{
				Response.Redirect("accesso.aspx", true);
			}else Response.Redirect("prenotazioni.aspx", true);
		}
	}
	
}