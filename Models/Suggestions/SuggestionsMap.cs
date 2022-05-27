using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using loja_depr.Models.Suggestion;

namespace loja_depr.Models.Map
{
    public class SuggestionsMap: IEntityTypeConfiguration<Suggestions>
    {
        public void Configure(EntityTypeBuilder<Suggestions> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(om => om.Departament)
                .WithMany(d => d.Suggestions)
                .HasForeignKey(om => om.DepartamentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(om => om.Colaborators)
                .WithMany(d => d.Suggestions)
                .HasForeignKey(om => om.ColaboratorsId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}