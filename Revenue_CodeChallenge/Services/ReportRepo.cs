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
									 ([ReportName])
									VALUES
									 (@ReportName)", report);
			}
		}

		public Report GetReport(string reportName)
		{
			using (var db = GetDb())
			{
				db.Open();
				return db.QueryFirst<Report>(@"SELECT * FROM [dbo].[Report]
												  WHERE ReportName = @reportName", new { reportName});
			}
		}
	}
}