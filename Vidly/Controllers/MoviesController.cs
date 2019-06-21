﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		// GET: Movies
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek!" };
			var customers = new List<Customer>()
			{
				new Customer(){Name = "Customer 1" },
				new Customer(){Name = "Customer 2" }
			};
			
			var viewModel = new RandomMovieViewModel()
			{
				Customers = customers,
				Movie = movie
			};

			return View(viewModel);
		}

		public ActionResult Edit(int id)
		{
			return Content($"El id es {id}");
		}

		public ActionResult Index(int? pageIndex, string sortBy)
		{
			if (!pageIndex.HasValue)
				pageIndex = 1;

			if (string.IsNullOrEmpty(sortBy))
				sortBy = "Name";

			return Content($"PageIndex = {pageIndex}, sortBy = {sortBy}");
		}

		[Route("movies/released/{year:min(2000)}/{month:regex(\\d{2}):range(1,12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content($"Resultado: {month}/{year}");
		}
	}
}