using System.ComponentModel.DataAnnotations;


namespace Abstracciones.Modelos
{
    public class ProductoBase
    {
        [Required(ErrorMessage = "La propiedad Nombre es requerida")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string CodigoBarras { get; set; }
    }

    public class ProductoRequest : ProductoBase
    {
        public Guid IdSubCategoria { get; set; }
    }

    public class ProductoResponse : ProductoBase
    {
        public Guid Id { get; set; }
        public string SubCategoria { get; set; }
        public string Categoria { get; set; }
    }
    public class ProductoDetalle : ProductoBase
    {
        public Guid Id { get; set; }
        public Guid IdSubCategoria { get; set; }
        public string SubCategoria { get; set; }
        public string Categoria { get; set; }
    }

}
