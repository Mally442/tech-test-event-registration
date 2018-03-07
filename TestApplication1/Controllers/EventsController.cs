using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BLL.Data;
using BLL.Models;
using TestApplication1.Models;
using System.Diagnostics;

namespace TestApplication1.Controllers
{
	public class EventsController : Controller
	{
		private readonly DataContext _context;

		public EventsController(DataContext context)
		{
			_context = context;
		}

		// GET: Events
		public async Task<IActionResult> Index()
		{
			var events = await _context.Events.ToListAsync();

			//TODO: Create a binder to do this
			var viewModel = events.Select(@event => new EventViewModel
			{
				Id = @event.Id,
				Name = @event.Name,
				Country = @event.Country,
				City = @event.City,
				StartDate = @event.StartDate,
				EndDate = @event.EndDate
			});

			return View(viewModel);
		}

		// GET: Events/Register/5
		public async Task<IActionResult> Register(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var @event = await _context.Events
				.SingleOrDefaultAsync(m => m.Id == id);
			if (@event == null)
			{
				return NotFound();
			}

			//TODO: Create a binder to do this
			var eventRegistration = new EventRegistrationViewModel
			{
				EventId = id.Value,
				Event = new EventViewModel
				{
					Id = @event.Id,
					Name = @event.Name,
					Country = @event.Country,
					City = @event.City,
					StartDate = @event.StartDate,
					EndDate = @event.EndDate
				}
			};

			return View(eventRegistration);
		}

		// POST: Events/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register([Bind("EventId,EmailAddress,FirstName,LastName,Country,ArrivalDate")] EventRegistrationViewModel eventRegistrationViewModel)
		{
			//TODO: Create a binder to do this
			var eventRegistration = new EventRegistration
			{
				EventId = eventRegistrationViewModel.EventId,
				EmailAddress = eventRegistrationViewModel.EmailAddress,
				FirstName = eventRegistrationViewModel.FirstName,
				LastName = eventRegistrationViewModel.LastName,
				Country = eventRegistrationViewModel.Country,
				ArrivalDate = eventRegistrationViewModel.ArrivalDate,
				RegistrationDate = DateTime.UtcNow
			};

			if (ModelState.IsValid)
			{
				_context.Add(eventRegistration);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(eventRegistration);
		}

		// GET: Events/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Events/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Country,City,StartDate,EndDate")] Event @event)
		{
			if (ModelState.IsValid)
			{
				_context.Add(@event);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(@event);
		}

		private bool EventExists(int id)
		{
			return _context.Events.Any(e => e.Id == id);
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
