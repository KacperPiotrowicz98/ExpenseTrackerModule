using ExpenseTrackerAPI.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI.EF
{
    public class ExpenseContext : DbContext
    {
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<InvoiceProvider> InvoiceProviders { get; set; }
        public virtual DbSet<InvoiceProviderAddress> InvoiceProviderAddresses { get; set; }
        public virtual DbSet<Language> InvoiceStatuses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PurchaseTax> PurchaseTaxes { get; set; }
        public virtual DbSet<UOM> UOMs { get; set; }
        public  DbSet<UserAccount> UserAccounts { get; set; }

        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
    }
}
