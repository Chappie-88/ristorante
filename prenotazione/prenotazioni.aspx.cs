using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prenotazione
{
	public partial class prenotazioni : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			//if (Session["islogged"] == null) { Response.Redirect("homepage.aspx", true); }
			Session["IDuser"] = "2C427B01-8ED7-4BAB-ABDD-058C4FF20975";
		}
		protected void BTMPrenota_Click(object sender, EventArgs e)
		{
			if (TXTdate.Text == "")
			{
				LBLprenotazione.Text = "Inserire una data valida";
			}
			else
			{
				if (TXTnPrenotati.Text == "")
				{
					LBLprenotazione.Text = "Inserire almeno 1 prenotato";
				}
				else
				{
					if (int.Parse(TXTnPrenotati.Text) < 1)
					{
						LBLprenotazione.Text = "Inserire almeno 1 prenotato";

					}

					Booking b = new Booking();                                  /*testare funzionamento con login*/
					b.ID = Guid.Parse(Session["IDuser"].ToString());
					b.dataPrenotazione = DateTime.Parse(TXTdate.Text);
					//b.dataPrenotazione = DateTime.Today;
					b.prenotati = int.Parse(TXTnPrenotati.Text);
					DAL.insertBooking(b);

				}
			}
		}
		}
	
}