using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using loja_depr.Models.Colaborator;
using loja_depr.Models;

namespace loja_depr.Models.Map
{
    public class ColaboratorsMap : IEntityTypeConfiguration<Colaborators>
    {
        public void Configure(EntityTypeBuilder<Colaborators> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(om => om.Departament)
                .WithMany(d => d.Colaborators)
                .HasForeignKey(om => om.DepartamentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}