using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revenue_CodeChallenge.Models
{
	public class ItemDto
	{
		public string Item { get; set; }
		public string Item_description { get; set; }
		public double Item_price { get; set; }
		public int Item_count { get; set; }
		public int ReportId { get; set; }
		public string Vendor { get; set; }
		public string Vendor_address { get; set; }
	}
}