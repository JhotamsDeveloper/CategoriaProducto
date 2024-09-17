namespace CategoriaProducto.Domain.Options;

public class DescuentoOptions
{
    public int Electronica { get; set; }
    public int Ropa { get; set; }
    public int Alimento { get; set; }
    public int Otro { get; set; }

    public static class Fact
    {
        public static string SectionName { get => "Descuento"; }
    }
}
