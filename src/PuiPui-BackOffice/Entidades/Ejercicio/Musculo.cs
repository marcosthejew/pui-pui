
namespace PuiPui_BackOffice.Entidades.Ejercicio
{
    public class Musculo
    {
        private int _idMusculo;
        private string _nombreMusculo;

        #region MetodosGetSet
        public string NombreMusculo
        {
            get { return _nombreMusculo; }
            set { _nombreMusculo = value; }
        }

        public int IdMusculo
        {
            get { return _idMusculo; }
            set { _idMusculo = value; }

        }
        #endregion MetodoGetSet

        #region Constructores
        public Musculo(int id, string nombre)
        {
            _idMusculo = id;
            _nombreMusculo = nombre;
        }

        public Musculo(string nombre)
        {
            _nombreMusculo = nombre;
        }

        public Musculo()
        {

        }
        #endregion Constructores
    }
}