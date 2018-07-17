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
	public class ReportRepo
	{
		private static SqlConnection GetDb()
		{
			return new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCart"].ConnectionString);
		}

		public int AddReport(Report report)
		{
			using (var db = GetDb())
			{
				db.Open();
				return db.Execute(@"INSERT INTO [dbo].[Report]
									 ([ItemId])
									VALUES
									 ([@ItemId])", report);
			}
		}

		public ReportDto getReport(int reportId)
		{
			using (var db = GetDb())
			{
				db.Open();
				return db.QueryFirst<ReportDto>(@"SELECT * FROM [dbo].[[Report]
												  WHERE ReportId = @ReportId", new { reportId });
			}
		}
	}
}