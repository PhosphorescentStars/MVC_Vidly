using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		private static List<Customer> customers = new List<Customer>()
			{
				new Customer(){Name = "John Doe", Id=1 },
				new Customer(){Name = "Marie Williams", Id=2 },
				new Customer(){Name = "Simon Simon", Id=3 }
			};

		public ActionResult Index() => View(customers);
				
		public ActionResult Details(int id)
		{
			return View(customers.Where(customer => customer.Id.Equals(id)).FirstOrDefault());
		}
	}
}