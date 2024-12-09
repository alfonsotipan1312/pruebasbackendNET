using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PruebaBackend
{
    public class AutoMarca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Estado { get; set; }
    }

    public class AutosMarcaConfiguration : IEntityTypeConfiguration<AutoMarca>
    {
        public void Configure(EntityTypeBuilder<AutoMarca> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                   .ValueGeneratedOnAdd(); // Asegúrate de usar esta configuración.
        }
    }
}