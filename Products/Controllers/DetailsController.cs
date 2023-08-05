using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.Infrastucture;
using Products.Models;

namespace Products.Controllers
{
	public class DetailsController : Controller
	{
		private readonly DataContext _context;

		public DetailsController(DataContext context)
		{
			_context = context;
		}


		public IActionResult Index(string productSlug)
		{
			// Veritabanından ürünü alın.
			var product = _context.Products.Where(p => p.Slug == productSlug).FirstOrDefault();

			// Ürünle görünümü döndürün.
			return View(product);
		}

	}
}
