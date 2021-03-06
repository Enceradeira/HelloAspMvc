namespace HelloApsMvc.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class BookContext : DbContext
	{
		public BookContext()
			: base("name=BookContext")
		{
		}

		public virtual DbSet<Book> Books { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>()
				.Property(e => e.Title)
				.IsUnicode(false);
		}
	}
}
