using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
	public class EventRegistration
	{
		public int Id { get; set; }
		public int EventId { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Country { get; set; }
		public DateTime ArrivalDate { get; set; }
		public DateTime RegistrationDate { get; set; }

		public virtual Event Event { get; set; }
	}
}
