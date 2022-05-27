using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using loja_depr.Models;

namespace loja_depr.Models.Map
{
    public class DepartamentsMap : IEntityTypeConfiguration<Departaments>
    {
        public void Configure(EntityTypeBuilder<Departaments> builder)
        {
            builder.HasKey(d => d.Id);
        }
    }
}