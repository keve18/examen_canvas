namespace Examen_KY.Models.Entity
{
    public class E_Libro:E_Editorial
    {
        /// <summary>
        /// Codigo del libro
        /// </summary>
        public int IdLibro { get; set; }

        /// <summary>
        /// Nombre del libro
        /// </summary>
        public string Nombre_Libro { get; set; }

        /// <summary>
        /// Descripcion del libro
        /// </summary>
        public string Desc_Libro { get; set; }

        /// <summary>
        /// Codigo del Autor
        /// </summary>
        public int IdAutor { get; set; }

        /// <summary>
        /// Nombre del Autor
        /// </summary>
        public string NomAutor { get; set; }

    }
}