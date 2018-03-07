using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
	public class Event
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public virtual List<EventRegistration> eventRegistrations { get; set; }
	}
}
