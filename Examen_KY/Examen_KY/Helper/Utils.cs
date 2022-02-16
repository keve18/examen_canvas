using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen_KY.Helper
{
    public class Utils
    {
        /// <summary>
        /// Verificar si variable es nulo para retornar DBNull
        /// </summary>
        /// <param name="value">Valor</param>
        /// <returns>DBNull</returns>
        public static object CheckNullValue(object value)
        {
            Type typeInt = typeof(int);
            Type typeDecimal = typeof(decimal);
            var type = (value != null) ? value.GetType() : null;
            bool cond = (type == typeInt) || (type == typeDecimal) ? (Convert.ToInt32(value) == 0) : (value == null);
            return cond ? DBNull.Value : value;
        }

        /// <summary>
        /// Convertir DataTable a List de una clase
        /// </summary>
        /// <typeparam name="T">Clase</typeparam>
        /// <param name="dt">DataTable</param>
        /// <returns>Lista de una clase</returns>
        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row => {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        try
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                return objT;
            }).ToList();
        }
    }
}