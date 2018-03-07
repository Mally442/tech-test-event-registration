using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BLL.Tests.Services
{
	public class EventServiceTests
	{
		//[Fact]
		//public void RegisterForEvent_returns_bound_eventRegistration()
		//{
		//	var eventService = new EventService();

		//	var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");
		//	var arrivalDate = new DateTime(2018, 3, 1, 13, 0, 0, DateTimeKind.Unspecified);
		//	var arrivalDateUTC = TimeZoneInfo.ConvertTimeToUtc(arrivalDate, timeZoneInfo);
			
		//	var registrationDateUTC = DateTime.UtcNow;

		//	var eventRegistration = eventService.RegisterForEvent(1, "smith.malcolm@gmail.com", "Malcolm", "Smith", "South Africa", arrivalDateUTC, registrationDateUTC);

		//	Assert.Equal(1, eventRegistration.EventId);
		//	Assert.Equal("smith.malcolm@gmail.com", eventRegistration.EmailAddress);
		//	Assert.Equal("Malcolm", eventRegistration.FirstName);
		//	Assert.Equal("Smith", eventRegistration.LastName);
		//	Assert.Equal("South Africa", eventRegistration.Country);
		//	Assert.Equal(arrivalDateUTC, eventRegistration.ArrivalDate);
		//	Assert.Equal(registrationDateUTC, eventRegistration.RegistrationDate);
		//}

		//[Fact]
		//public void AddEvent_returns_bound_event()
		//{
		//	var eventService = new EventService();

		//	var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");
		//	var arrivalDate = new DateTime(2018, 3, 1, 13, 0, 0, DateTimeKind.Unspecified);
		//	var arrivalDateUTC = TimeZoneInfo.ConvertTimeToUtc(arrivalDate, timeZoneInfo);

		//	var registrationDateUTC = DateTime.UtcNow;

		//	var eventRegistration = eventService.RegisterForEvent(1, "smith.malcolm@gmail.com", "Malcolm", "Smith", "South Africa", arrivalDateUTC, registrationDateUTC);

		//	Assert.Equal(1, eventRegistration.EventId);
		//	Assert.Equal("smith.malcolm@gmail.com", eventRegistration.EmailAddress);
		//	Assert.Equal("Malcolm", eventRegistration.FirstName);
		//	Assert.Equal("Smith", eventRegistration.LastName);
		//	Assert.Equal("South Africa", eventRegistration.Country);
		//	Assert.Equal(arrivalDateUTC, eventRegistration.ArrivalDate);
		//	Assert.Equal(registrationDateUTC, eventRegistration.RegistrationDate);
		//}
	}
}
