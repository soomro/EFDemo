namespace EFDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBooks : DbContext
    {
        public ModelBooks()
            : base("name=ModelBooks")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Categories)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Employees>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Employees)
                .HasForeignKey(e => e.EmployeeID);

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.ID);

            modelBuilder.Entity<Products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shippers>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shippers)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Suppliers)
                .HasForeignKey(e => e.SupplierID);
        }
    }
}
