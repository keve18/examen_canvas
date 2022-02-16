using System.Data;
using Examen_KY.Models.Entity;

namespace Examen_KY.Models.Interface
{
    interface I_Libro
    {
        DataSet GetLibro(int IdLibro, string Nombre_Libro,string NomAutor);
        string InsertLibro(E_Libro dataLibro);
        string UpdateLibro(E_Libro dataLibro);
        string DeleteLibro(int IdLibro);
    }
}
