using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication1.Models
{
	public class EventViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
