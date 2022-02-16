namespace Examen_KY.Models.SQL
{
    public class SQL_Editorial
    {
        #region Procedimientos almacenados
        /// <summary>
        /// Constante de SP de obtener Editorial(es)
        /// </summary>
        public const string SP_GET_EDITORIAL = "Get_Autor";

        /// <summary>
        /// Constante de SP de obtener Editorial(es)
        /// </summary>
        public const string SP_INS_EDITORIAL = "Ins_Autor";

        /// <summary>
        /// Constante de SP de obtener Editorial(es)
        /// </summary>
        public const string SP_DEL_EDITORIAL = "Del_Autor";
        #endregion
        #region Nombres de Parametros
        /// <summary>
        /// Constante de parametro de id Editorial
        /// </summary>
        public const string PARAM_EDITORIAL_ID = "@IdEditorial";
        public const string PARAM_EDITORIAL_NOMBRE = "@NomEditorial";
        #endregion
    }
}