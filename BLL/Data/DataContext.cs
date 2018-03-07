using BLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Data
{
	public class DataContext : DbContext
	{
		public DataContext (DbContextOptions<DataContext> options)
			: base(options)
		{
		}

		public DbSet<Event> Events { get; set; }
		public DbSet<EventRegistration> EventRegistrations { get; set; }
	}
}
