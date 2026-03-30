using Abstracciones.Interfaces.DA;
using Microsoft.Data.SqlClient;
using Dapper;
using Abstracciones.Modelos;

namespace DA
{
    public class CategoriaDA: ICategoriaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;


        public CategoriaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        #region Operaciones
        public async Task<IEnumerable<Categoria>> Obtener()
        {
            string query = @"ObtenerCategoria";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Categoria>(query);
            return resultadoConsulta;
        }

        #endregion
    }
}
