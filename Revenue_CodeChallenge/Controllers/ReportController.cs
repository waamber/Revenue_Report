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
		public HttpResponseMessage AddReport(Report report, Vendors vendor, Items item)
		{
			var reportRepo = new ReportRepo();
			var reportResults = reportRepo.AddReport(report);

			var vendorRepo = new VendorRepo();
			var vendorResults = vendorRepo.AddVendor(vendor);

			//var itemRepo = new ItemRepo();
			//var itemResults = itemRepo.InsertItem(item, report.ReportId, vendor.VendorId);

			return Request.CreateResponse(HttpStatusCode.OK);

		}

	}


}