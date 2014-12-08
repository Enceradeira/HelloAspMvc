using System;
using System.Threading.Tasks;
using HelloApsMvc.Models;

namespace HelloApsMvc.Tests.Features.Support
{
	public class DatabaseCleaner
	{
		public static async Task<int> Clean()
		{
			var cmds = new[]
			{
				"EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'",
				"EXEC sp_MSForEachTable 'ALTER TABLE ? DISABLE TRIGGER ALL'",
				"EXEC sp_MSForEachTable 'DELETE FROM ?'",
				"EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'",
				"EXEC sp_MSForEachTable 'ALTER TABLE ? ENABLE TRIGGER ALL'"
			};

			var batch = string.Join(";", cmds);

			var ctx = new BookContext();
			return await ctx.Database.ExecuteSqlCommandAsync(batch);
		}
	}
}