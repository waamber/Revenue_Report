using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revenue_CodeChallenge.Models
{
	public class ReportDto
	{
		public int ReportId { get; set; }
		public int ItemId { get; set; }
		public double Item_price { get; set; }
		public int Item_count { get; set; }
	}
}