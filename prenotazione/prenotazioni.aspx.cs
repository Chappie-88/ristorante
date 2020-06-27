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
        int capienza;
           Guid ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            capienza = Convert.ToInt32(Session["capienza"]);
            if (Session["islogged"] == null) { Response.Redirect("homepage.aspx", true); }
            ID = Guid.Parse(Session["IDuser"].ToString());

            GenerateBookingTable(ID);
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
                    if (DAL.dateTest(DateTime.Parse(TXTdate.Text), ID))
                    {
                        if ((capienza - DAL.freeSeat(DateTime.Parse(TXTdate.Text)) - int.Parse(TXTnPrenotati.Text)) < 0)
                        {
                            Booking b = new Booking(); b.id_prenotazione = Guid.NewGuid();
                            /*testare funzionamento con login*/
                            b.ID = Guid.Parse(Session["IDuser"].ToString());
                            b.dataPrenotazione = DateTime.Parse(TXTdate.Text);
                            //b.dataPrenotazione = DateTime.Today;
                            b.prenotati = int.Parse(TXTnPrenotati.Text);
                            DAL.insertBooking(b);
                            GenerateBookingTable(ID);
                        }
                        else 
                        {
                            LBLprenotazione.Text = "Per il giorno " + TXTdate.Text + " non ci sono " + TXTnPrenotati.Text+ " posti disponibili";
                        }
                    }
                    else {
                        LBLprenotazione.Text = "Hai gia una prenotazione per questa data";
                    }

                }
            }
        }
        private void GenerateBookingTable(Guid ID){
      
            TBLBooking.Rows.Clear();
            TableRow headerRow = new TableRow();
            TableCell dataHeaderCell = new TableCell();
            TableCell bookingHeaderCell = new TableCell();
            TableCell deleteHeaderCell = new TableCell();
            dataHeaderCell.Text = "Data prenotazione";
            bookingHeaderCell.Text = "Posti prenotati";
            deleteHeaderCell.Text =  "" ;
            headerRow.Style.Add("font-weight", "bold");
            headerRow.Cells.Add(dataHeaderCell);
            headerRow.Cells.Add(bookingHeaderCell);
            headerRow.Cells.Add(deleteHeaderCell);
            TBLBooking.Rows.Add(headerRow);
            TBLBooking.Attributes.Add("class", "table");

            List<Booking> booking = DAL.getAllBooking(ID);
            foreach (Booking b in booking)
            {
                TableRow row = new TableRow();
                TableCell dateCell = new TableCell();
                TableCell prenotaticell = new TableCell();
                //TableCell editButtonCell = new TableCell();
                TableCell deleteButtonCell = new TableCell();
                dateCell.Text = b.dataPrenotazione.ToString();
                prenotaticell.Text = b.prenotati.ToString();
                //Button editButton = new Button();
                //editButton.ID = p.ID.ToString() + "Edit";
                //editButton.Text = "Edit";
                //editButton.Click += this.EditButton_Click;
                //editButton.Attributes.Add("class", "btn btn-warning btn-sm");
                //editButtonCell.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.ID = b.id_prenotazione.ToString() + "delete";
                deleteButton.Text = "Delete";
                deleteButton.Click += this.Delete_Click;
                deleteButton.Attributes.Add("class", "btn btn-danger btn-sm");
                deleteButtonCell.Controls.Add(deleteButton);

                row.Cells.Add(dateCell);
                row.Cells.Add(prenotaticell);
                //row.Cells.Add(editButtonCell);
                row.Cells.Add(deleteButtonCell);
                TBLBooking.Rows.Add(row);
            }
            TBLBooking.DataBind();
        }

        protected void Delete_Click(object sender, EventArgs e)
        { /* serve ID di prenotazione come chiave univoca*/
            Button bt = new Button();
            Guid idconvers = Guid.Parse(((Button)sender).ID.Replace("delete", ""));
            DAL.Delete(idconvers);
            Response.Redirect("prenotazioni.aspx", true);
        }
    }
}