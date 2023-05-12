using Microsoft.EntityFrameworkCore;
using OrderManagement.DAL.Entities;

namespace OrderManagement.DAL.Data
{
    public class OrderMgtDbContext : DbContext
    {
        public OrderMgtDbContext(DbContextOptions<OrderMgtDbContext> options) : base(options)
        {
        }

        public virtual DbSet<StateDto> State { get; set; }
        public virtual DbSet<ElementTypeDto> ElementType { get; set; }
        public virtual DbSet<ElementDto> Element { get; set; }
        public virtual DbSet<WindowDto> Window { get; set; }
        public virtual DbSet<OrderDto> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateDto>().ToTable("State");

            modelBuilder.Entity<ElementTypeDto>().ToTable("ElementType"); 

            modelBuilder.Entity<ElementDto>(entity =>
            {
                entity.ToTable("Element");

                entity.HasOne(d => d.ElementType)
                 .WithMany(p => p.Elements)
                 .HasForeignKey(d => d.ElementTypeId);
            });

            modelBuilder.Entity<WindowDto>(entity =>
            {
                entity.ToTable("Window");

                entity.HasOne(d => d.Order)
                 .WithMany(p => p.Windows)
                 .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<OrderDto>(entity =>
            {
                entity.ToTable("Order");

                entity.HasOne(d => d.State)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.StateId);
            });

        }

    }
}
