namespace PruebaBackend
{
    public static class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                if (!context.AutosMarca.Any())
                {
                    context.AutosMarca.AddRange(
                        new AutoMarca { Descripcion = "Toyota", Estado = "A",  Marca = "Sport" },
                        new AutoMarca { Descripcion = "Honda" , Estado = "A",  Marca = "Evolution" },
                        new AutoMarca { Descripcion = "Ford" , Estado = "A",  Marca = "Moderno" }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}