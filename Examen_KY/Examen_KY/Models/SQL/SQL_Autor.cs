namespace Examen_KY.Models.SQL
{
    public class SQL_Autor
    {
        #region Procedimientos almacenados
        /// <summary>
        /// Constante de SP de obtener Autor(es)
        /// </summary>
        public const string SP_GET_AUTOR = "Get_Autor";

        /// <summary>
        /// Constante de SP de insertar Autor(es)
        /// </summary>
        public const string SP_INS_AUTOR = "Ins_Autor";

        /// <summary>
        /// Constante de SP de eliminar Autor(es)
        /// </summary>
        public const string SP_DEL_AUTOR = "Del_Autor";
        #endregion
        #region Nombres de Parametros
        /// <summary>
        /// Constante de parametro de id Libro
        /// </summary>
        public const string PARAM_AUTOR_ID = "@IdAutor";

        /// <summary>
        /// Constante de parametro de id Libro
        /// </summary>
        public const string PARAM_AUTOR_NOMBRES = "@Nombres";

        /// <summary>
        /// Constante de parametro de id Libro
        /// </summary>
        public const string PARAM_AUTOR_APELLIDOS = "@Apellidos";
        #endregion
    }
}