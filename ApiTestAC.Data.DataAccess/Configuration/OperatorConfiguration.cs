using ApiTestAC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTestAC.Data.DataAccess.Configuration
{
    public class OperatorConfiguration : IEntityTypeConfiguration<Operator>
    {
        public void Configure(EntityTypeBuilder<Operator> entity)
        {
            entity.Property(e => e.Categoria)
                    .HasColumnName("categoria")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

            entity.Property(e => e.CodigoOperador).HasColumnName("codigoOperador");

            entity.Property(e => e.Epc)
                .HasColumnName("epc")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Estado).HasColumnName("estado");

            entity.Property(e => e.EstadoSaldo).HasColumnName("estadoSaldo");

            entity.Property(e => e.Modalidad)
                .HasColumnName("modalidad")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumeroCliente)
                .HasColumnName("numeroCliente")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Placa)
                .HasColumnName("placa")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Saldo)
                .HasColumnName("saldo")
                .HasColumnType("decimal(18, 0)");

            entity.Property(e => e.SaldoBajo).HasColumnName("saldoBajo");

            entity.Property(e => e.Tid)
                .HasColumnName("tid")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("version")
                .HasColumnType("datetime");
        }
    }
}
