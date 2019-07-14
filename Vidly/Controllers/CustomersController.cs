using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		private ApplicationDbContext context;

		public CustomersController()=> context = new ApplicationDbContext();		
		protected override void Dispose(bool disposing) => context.Dispose();		

		private static List<Customer> customers = new List<Customer>()
		{
			new Customer(){Name = "John Doe", Id=1 },
			new Customer(){Name = "Marie Williams", Id=2 },
			new Customer(){Name = "Simon Simon", Id=3 }
		};

		public ActionResult Index() => View(context.Customers.Include(c => c.MembershipType));

		public ActionResult Details(int id) 
			=> View(context.Customers.Where(customer => customer.Id.Equals(id)).FirstOrDefault());
	}
}