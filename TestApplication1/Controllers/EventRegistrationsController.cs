using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BLL.Data;
using BLL.Models;

namespace TestApplication1.Controllers
{
	public class EventRegistrationsController : Controller
	{
		private readonly DataContext _context;

		public EventRegistrationsController(DataContext context)
		{
			_context = context;
		}

		// GET: EventRegistrations
		public async Task<IActionResult> Index()
		{
			var dataContext = _context.EventRegistrations.Include(e => e.Event);
			return View(await dataContext.ToListAsync());
		}

		// GET: EventRegistrations/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var eventRegistration = await _context.EventRegistrations
				.Include(e => e.Event)
				.SingleOrDefaultAsync(m => m.Id == id);
			if (eventRegistration == null)
			{
				return NotFound();
			}

			return View(eventRegistration);
		}

		private bool EventRegistrationExists(int id)
		{
			return _context.EventRegistrations.Any(e => e.Id == id);
		}
	}
}
