using BLL.Data;
using BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TestApplication1.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new DataContext(
				serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
			{
				// Look for any events.
				if (context.Events.Any())
				{
					return;   // DB has been seeded
				}

				context.Events.AddRange(
					 new Event
					 {
						 Name = "Event 1",
						 Country = "South Africa",
						 City = "Cape Town",
						 StartDate = DateTime.Parse("1989-1-11 01:00 PM"),
						 EndDate = DateTime.Parse("1989-1-11 02:00 PM")
					 },
					 new Event
					 {
						 Name = "Event 2",
						 Country = "England",
						 City = "London",
						 StartDate = DateTime.Parse("1989-1-11 01:00 PM"),
						 EndDate = DateTime.Parse("1989-1-11 02:00 PM")
					 },
					 new Event
					 {
						 Name = "Event 3",
						 Country = "South Africa",
						 City = "Durban",
						 StartDate = DateTime.Parse("1989-1-11 01:00 PM"),
						 EndDate = DateTime.Parse("1989-1-11 02:00 PM")
					 }
				);
				context.SaveChanges();
			}
		}
	}
}
