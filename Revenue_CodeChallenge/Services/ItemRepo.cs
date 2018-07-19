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
	public class ItemRepo
	{
		private static SqlConnection GetDb()
		{
			return new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCart"].ConnectionString);
		}

		public int AddItem(ItemDto item)
		{
			using(var db= GetDb())
			{
				db.Open();
				return db.Execute(@"INSERT INTO [dbo].[Item]
									([Item],
									 [Item_count],
									 [Item_price],
									 [Item_description],
									 [ReportId],
									 [Vendor],
									 [Vendor_address])
									VALUES
									 (@Item,
									 @Item_count,
									 @Item_price,
									 @Item_description,
									 @ReportId,
									 @Vendor,
									 @Vendor_address)", item);
			}
		}
	}

}