using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GUI.Tabellen
{
    public partial class MarktverwaltungssystemContext : DbContext
    {

        public MarktverwaltungssystemContext()
        {
        }

        public MarktverwaltungssystemContext(DbContextOptions<MarktverwaltungssystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<CreditChecks> CreditChecks { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<EmployeeRoles> EmployeeRoles { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Inspectors> Inspectors { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItem { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Landlords> Landlords { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Places> Places { get; set; }
        public virtual DbSet<QualityChecks> QualityChecks { get; set; }
        public virtual DbSet<RentalPermissions> RentalPermissions { get; set; }
        public virtual DbSet<RentalProperties> RentalProperties { get; set; }
        public virtual DbSet<RentalPropertyReservations> RentalPropertyReservations { get; set; }
        public virtual DbSet<SalaryOrders> SalaryOrders { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionsOrders> SubscriptionsOrders { get; set; }
        public virtual DbSet<Visitors> Visitors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=34.65.73.57;Database=Marktverwaltungssystem;User ID=;Password=;Trusted_Connection=True;Integrated Security=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_Places");
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.AdditionalInfo)
                    .HasColumnName("additional_info")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.LandlordId).HasColumnName("landlord_id");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Square)
                    .HasColumnName("square")
                    .HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Areas_Addresses");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Areas_Employees");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Areas_Landlords");
            });

            modelBuilder.Entity<CreditChecks>(entity =>
            {
                entity.HasKey(e => e.CreditCheckId);

                entity.Property(e => e.CreditCheckId).HasColumnName("credit_check_id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.ApprovedOn)
                    .HasColumnName("approved_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.VisitDate)
                    .HasColumnName("visit_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CreditChecks)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditChecks_Employees");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.CreditChecks)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditChecks_Sellers");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.HasIndex(e => e.District)
                    .HasName("UQ_district")
                    .IsUnique();

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeRoles>(entity =>
            {
                entity.HasKey(e => e.EmployeeRoleId);

                entity.Property(e => e.EmployeeRoleId).HasColumnName("employee_role_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employee_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeRoleId).HasColumnName("employee_role_id");

                entity.Property(e => e.HourlySalary)
                    .HasColumnName("hourly_salary")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((30.00))");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Employees)
                    .HasForeignKey<Employees>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Persons");

                entity.HasOne(d => d.EmployeeRole)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_EmployeeRoles");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_Areas");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_Employees");
            });

            modelBuilder.Entity<Inspectors>(entity =>
            {
                entity.HasKey(e => e.InspectorId);

                entity.Property(e => e.InspectorId)
                    .HasColumnName("inspector_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HourlySalary)
                    .HasColumnName("hourly_salary")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((25.00))");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Inspectors)
                    .HasForeignKey<Inspectors>(d => d.InspectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inspectors_Persons");
            });

            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.Property(e => e.InvoiceItemId).HasColumnName("invoice_item_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceItem)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceItem_Invoices");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.InvoiceItem)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceItem_Orders");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("created_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidOn)
                    .HasColumnName("paid_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((7.70))");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_Persons");
            });

            modelBuilder.Entity<Landlords>(entity =>
            {
                entity.HasKey(e => e.LandlordId);

                entity.Property(e => e.LandlordId)
                    .HasColumnName("landlord_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Landlords)
                    .HasForeignKey<Landlords>(d => d.LandlordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Landlords_Persons");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("created_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.HasIndex(e => e.Email)
                    .HasName("UQ_Email")
                    .IsUnique();

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.PhoneNr)
                    .HasColumnName("phone_nr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlUserId).HasColumnName("sql_user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persons_Addresses");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Persons_Persons");
            });

            modelBuilder.Entity<Places>(entity =>
            {
                entity.HasKey(e => e.PlaceId);

                entity.Property(e => e.PlaceId)
                    .HasColumnName("place_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Places_Districts");
            });

            modelBuilder.Entity<QualityChecks>(entity =>
            {
                entity.HasKey(e => e.QualityCheckId);

                entity.Property(e => e.QualityCheckId).HasColumnName("quality_check_id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.ApprovedOn)
                    .HasColumnName("approved_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.InspectorId).HasColumnName("inspector_id");

                entity.Property(e => e.RoundCheck)
                    .HasColumnName("round_check")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.HasOne(d => d.Inspector)
                    .WithMany(p => p.QualityChecks)
                    .HasForeignKey(d => d.InspectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QualityChecks_Inspectors");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.QualityChecks)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QualityChecks_Sellers");
            });

            modelBuilder.Entity<RentalPermissions>(entity =>
            {
                entity.HasKey(e => e.RentalPermissionId);

                entity.Property(e => e.RentalPermissionId).HasColumnName("rental_permission_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.RentalPermissions)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalPermissions_Areas");
            });

            modelBuilder.Entity<RentalProperties>(entity =>
            {
                entity.HasKey(e => e.RentalPropertyId);

                entity.Property(e => e.RentalPropertyId).HasColumnName("rental_property_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Square)
                    .HasColumnName("square")
                    .HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.RentalProperties)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalProperties_Areas");
            });

            modelBuilder.Entity<RentalPropertyReservations>(entity =>
            {
                entity.HasKey(e => new { e.SellerId, e.RentalPropertyId });

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.RentalPropertyId).HasColumnName("rental_property_id");

                entity.HasOne(d => d.RentalProperty)
                    .WithMany(p => p.RentalPropertyReservations)
                    .HasForeignKey(d => d.RentalPropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalPropertyReservations_RentalProperties");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.RentalPropertyReservations)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalPropertyReservations_Seller");
            });

            modelBuilder.Entity<SalaryOrders>(entity =>
            {
                entity.HasKey(e => e.SalaryOrderId);

                entity.Property(e => e.SalaryOrderId)
                    .HasColumnName("salary_order_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SalaryOrders)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalaryOrders_Persons");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.SalaryOrders)
                    .HasForeignKey<SalaryOrders>(d => d.SalaryOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalaryOrders_Orders");
            });

            modelBuilder.Entity<Sellers>(entity =>
            {
                entity.HasKey(e => e.SellerId);

                entity.Property(e => e.SellerId)
                    .HasColumnName("seller_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Sellers)
                    .HasForeignKey<Sellers>(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sellers_Persons");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.Sellers)
                    .HasForeignKey(d => d.SubscriptionId)
                    .HasConstraintName("FK_Sellers_Subscriptions");
            });

            modelBuilder.Entity<Subscriptions>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RentalPropertiesQuantity).HasColumnName("rental_properties_quantity");
            });

            modelBuilder.Entity<SubscriptionsOrders>(entity =>
            {
                entity.HasKey(e => e.SubscriptionOrderId);

                entity.Property(e => e.SubscriptionOrderId)
                    .HasColumnName("subscription_order_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionsOrders)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionsOrders_Subscriptions");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.SubscriptionsOrders)
                    .HasForeignKey<SubscriptionsOrders>(d => d.SubscriptionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionsOrders_Orders");
            });

            modelBuilder.Entity<Visitors>(entity =>
            {
                entity.HasKey(e => e.VisitorId);

                entity.Property(e => e.VisitorId)
                    .HasColumnName("visitor_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("text");

                entity.Property(e => e.WantsNewsletter).HasColumnName("wants_newsletter");

                entity.HasOne(d => d.Visitor)
                    .WithOne(p => p.Visitors)
                    .HasForeignKey<Visitors>(d => d.VisitorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visitors_Persons");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
