namespace Examen_KY.Models.SQL
{
    public class SQL_Libro
    {
        #region Procedimientos almacenados
        /// <summary>
        /// Constante de SP de obtener Libro(s)
        /// </summary>
        public const string SP_GET_LIBRO = "Get_Libro";
        /// <summary>
        /// Constante de SP de insertar Libro(s)
        /// </summary>
        public const string SP_INS_LIBRO = "Ins_Libro";
        /// <summary>
        /// Constante de SP de eliminar Libro(s)
        /// </summary>
        public const string SP_DEL_LIBRO = "Del_Libro";
        #endregion
        #region Nombres de Parametros
        /// <summary>
        /// Constante de parametro de id Libro
        /// </summary>
        public const string PARAM_LIBRO_ID = "@IdLibro";

        /// <summary>
        /// Constante de parametro de nombre Libro
        /// </summary>
        public const string PARAM_LIBRO_NOMBRE = "@NomLibro";

        /// <summary>
        /// Constante de parametro de descripcion Libro
        /// </summary>
        public const string PARAM_LIBRO_DESCRIPCION = "@DesLibro";
        #endregion
    }
}