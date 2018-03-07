using BLL.Data;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
	public interface IEventService
	{
	}

	public class EventService : IEventService
	{
		private DataContext _context;

		public EventService(DataContext context)
		{
			_context = context;
		}

		public Event AddEvent(string name, string country, string city, DateTime startDate, DateTime endDate)
		{
			var @event = new Event
			{
				Name = name,
				Country = country,
				City = city,
				StartDate = startDate,
				EndDate = endDate
			};

			_context.Events.Add(@event);

			return @event;
		}

		public EventRegistration RegisterForEvent(int eventId, string emailAddress, string firstName, string lastName, string country, DateTime arrivalDate, DateTime registrationDate)
		{
			var eventRegistration = new EventRegistration
			{
				EventId = eventId,
				EmailAddress = emailAddress,
				FirstName = firstName,
				LastName = lastName,
				Country = country,
				ArrivalDate = arrivalDate,
				RegistrationDate = registrationDate
			};

			_context.EventRegistrations.Add(eventRegistration);

			return eventRegistration;
		}
	}
}
