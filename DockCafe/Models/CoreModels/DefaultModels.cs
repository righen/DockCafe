using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace DockCafe.Models.CoreModels
{
    public class DefaultModels : DbContext
    {
        public DefaultModels()
            : base("name=DefaultModels")
        {

            var adapter = (IObjectContextAdapter) this;
            var objectContext = adapter.ObjectContext;
            objectContext.CommandTimeout = 48 * 60; // value in seconds
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CRTransaction> CRTransactions { get; set; }
        public virtual DbSet<CRTransactionType> CRTransactionTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
               .Property(e => e.CategoryName)
               .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.ItemCategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerCompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerOfficeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerNID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerGender)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.OrderCustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.ReceiptCustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.OrderItemItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderRemarks)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderItemOrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.PaymentName)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => e.ReceiptPaymentTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.ReceiptDetails)
                .WithRequired(e => e.Receipt)
                .WillCascadeOnDelete(false);
        }
    }
}