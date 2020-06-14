using ApiTestAC.Data.DataAccess.Configuration;
using ApiTestAC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiTestAC.Data.DataAccess
{
    public partial class db_test_ACC1Context : DbContext
    {
        public db_test_ACC1Context()
        {
        }

        public db_test_ACC1Context(DbContextOptions<db_test_ACC1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Operator> Operator { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OperatorConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
