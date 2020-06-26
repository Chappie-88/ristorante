using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prenotazione
{
	public class Booking
	{
		public Guid ID { get; set; }
		public DateTime dataPrenotazione { get; set; }
		public int prenotati { get; set; }
	}
}