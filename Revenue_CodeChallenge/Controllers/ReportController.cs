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
	[RoutePrefix("api/report")]
	public class ReportController : ApiController
	{
		[Route(""), HttpPost]
		public HttpResponseMessage AddReport(Report report)
		{
			var repo = new ReportRepo();
			var results = repo.AddReport(report);

			return Request.CreateResponse(HttpStatusCode.OK);

		}

		[Route("{reportName}"), HttpGet]
		public HttpResponseMessage GetReport(string reportName)
		{
			var repo = new ReportRepo();
			var results = repo.GetReport(reportName);

			return Request.CreateResponse(HttpStatusCode.OK, results);
		}
	}


}