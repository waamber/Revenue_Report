using Revenue_CodeChallenge.Models;
using Revenue_CodeChallenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Revenue_CodeChallenge.Controllers
{
	[RoutePrefix("api/item")]
	public class ItemController : ApiController
	{
		[Route(""), HttpPost]
		public HttpResponseMessage AddItem(ItemDto item)
		{
			var repo = new ItemRepo();
			var results = repo.AddItem(item);

			return Request.CreateResponse(HttpStatusCode.OK, results);
		}
	}
}