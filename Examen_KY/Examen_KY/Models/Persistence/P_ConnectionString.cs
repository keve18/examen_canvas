using System.Data;
using System.Web.Configuration;

namespace Examen_KY.Models.Persistence
{
    public class P_ConnectionString
    {
        /// <summary>
        /// Cadena de conexion
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public P_ConnectionString()
        {
            this.ConnectionString = WebConfigurationManager.ConnectionStrings["Examen_Canva"].ConnectionString;
        }

        /// <summary>
        /// Obtener dataset con mensaje de error
        /// </summary>
        /// <param name="type">Tipo de error</param>
        /// <param name="message">Mensaje</param>
        /// <returns>dtsErrorMessage</returns>
        public DataSet GetErrorDataSet(string type, string message)
        {
            var dtsErrorMessage = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("message", typeof(string)));
            dt.Rows.Add(type + ": " + message);
            dtsErrorMessage.Tables.Add(dt);
            dtsErrorMessage.Tables[0].TableName = "Error";
            return dtsErrorMessage;
        }
    }
}