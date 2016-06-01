using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.Domain.Entities;
namespace Application.DAL
{
    internal class ClaimConfiguration : EntityTypeConfiguration<Application.Domain.Entities.Claim>
    {
        internal ClaimConfiguration()
        {
            ToTable("Claim");

            HasKey(x => x.ClaimId)
                .Property(x => x.ClaimId)
                .HasColumnName("ClaimId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.UserId)
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            Property(x => x.ClaimType)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar")
                .IsMaxLength()
                .IsOptional();

            Property(x => x.ClaimValue)
                .HasColumnName("ClaimValue")
                .HasColumnType("nvarchar")
                .IsMaxLength()
                .IsOptional();

            HasRequired(x => x.User)
                .WithMany(x => x.Claims)
                .HasForeignKey(x => x.UserId);
        }
    }
}
