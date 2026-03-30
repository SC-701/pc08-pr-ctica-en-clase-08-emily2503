using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;


namespace Flujo
{
    public class ProductoFlujo : IProductoFlujo
    {
        private IProductoDA _ProductoDA;
       

        public ProductoFlujo(IProductoDA ProductoDA)
        {
            _ProductoDA = ProductoDA;
        }

        public async Task<Guid> Agregar(ProductoRequest Producto)
        {
            return await _ProductoDA.Agregar(Producto);
        }

        public async Task<Guid> Editar(Guid Id, ProductoRequest Producto)
        {
            return await _ProductoDA.Editar(Id, Producto);
        }

        public async Task<Guid> Eliminar(Guid Id)
        {
            return await _ProductoDA.Eliminar(Id);
        }

        public async Task<IEnumerable<ProductoResponse>> Obtener()
        {
            return await _ProductoDA.Obtener();
        }
        public async Task<ProductoDetalle> Obtener(Guid Id)
        {
            var Producto = await _ProductoDA.Obtener(Id);
            return Producto;
        }
    }
}
