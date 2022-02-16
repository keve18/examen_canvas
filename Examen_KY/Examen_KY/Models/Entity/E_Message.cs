using System.Data;

namespace Examen_KY.Models.Entity
{
    public class E_Message
    {
        /// <summary>
        /// Mensaje
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Obtener dataset con mensaje
        /// </summary>
        /// <param name="message">Mensaje</param>
        /// <returns>dtsMessage</returns>
        public DataSet GetMessage(object message)
        {
            DataSet dtsMessage = new DataSet();
            DataTable dt = new DataTable("Message");
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Rows.Add(message);
            dtsMessage.Tables.Add(dt);
            return dtsMessage;
        }
    }
}