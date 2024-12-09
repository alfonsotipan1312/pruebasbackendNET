using Microsoft.EntityFrameworkCore;
using PruebaBackend;
using Xunit;

public class MarcasAutosControllerTests
{
    [Fact]
    public void Get_ReturnsMarcasAutos(Assert Assert)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .Options;

        using (var context = new AppDbContext(options))
        {
            context.AutosMarca.Add(new AutoMarca { Id = 1, Descripcion = "Toyota" });
            context.SaveChanges();
        }

        using (var context = new AppDbContext(options))
        {
            var controller = new MarcasAutosController(context);
            var result = controller.Get();

            Assert.Equal(1, result.Value.Count());
            Assert.Equal("Toyota", result.Value.First().Descripcion);
        }
    }
}
