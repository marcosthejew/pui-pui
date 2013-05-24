using System.Data.SqlClient;

namespace PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion
{
    public interface IConexionSqlServer
    {
        void AbrirConexion();

        void CerrarConexion();

        SqlConnection ObjetoConexion();
    }
}