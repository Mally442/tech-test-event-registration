using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication1.Models
{
	public class EventRegistrationViewModel
	{
		public int Id { get; set; }
		[HiddenInput(DisplayValue = false)]
		public int EventId { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Country { get; set; }
		public DateTime ArrivalDate { get; set; }
		public DateTime RegistrationDate { get; set; }

		public EventViewModel Event { get; set; }
	}
}
