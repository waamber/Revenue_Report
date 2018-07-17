using Dapper;
using Revenue_CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Revenue_CodeChallenge.Services
{
	public class VendorRepo
	{
		private static SqlConnection GetDb()
		{
			return new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCart"].ConnectionString);
		}

		public int AddVendor(Vendors vendor)
		{
			using (var db = GetDb())
			{
				db.Open();
				return db.Execute(@"INSERT INTO [dbo].[Vendor]
									 ([Vendor],
									  [Vendor_address])
									VALUES
									 ([@Vendor],
									  [@Vendor_Address])", vendor);
			}
		}

	}
}