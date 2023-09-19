using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Models
{
    public class BibliotecaViewModel
    {
        public int ID { get; set; }
        public Int64 Año { get; set; }
        public string Lugar { get; set; }
        public string Editorial { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string TipoDePublicacion { get; set; }
        public Int64 Paginas { get; set; }
    }
}
