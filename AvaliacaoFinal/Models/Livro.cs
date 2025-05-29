using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal.Models
{
    public class Livro
    {
        private string _titulo;
        private string _autor;
        private int _id;
        private string _estado;
        
        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Estado
        {
            get => _estado;
            set => _estado = value;
        }

        public Livro(string titulo, string autor, int id)
        {
            _titulo = titulo;
            _autor = autor;
            _id = id;
            _estado = "Disponível";
        }
    }
}
