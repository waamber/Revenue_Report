using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Revenue_CodeChallenge.Controllers
{
	[RoutePrefix("api/report")]
	public class ReportController : ApiController
	{
		[Route(""), HttpPost]
		public HttpResponseMessage AddReport()
		{

		}
	}
	
}