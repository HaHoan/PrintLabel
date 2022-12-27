using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.App.Extension
{
    public static class ConvertData
    {
        public static Type GetCoreType(Type t)
        {
            if (t != null)
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }

        public static DataTable ToDataTable<T>(this List<T> items)
        {
            //var tb = new DataTable(typeof(T).Name);

            //PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //foreach (PropertyInfo prop in props)
            //{
            //    Type t = GetCoreType(prop.PropertyType);
            //    tb.Columns.Add(prop.Name, t);
            //}


            //foreach (T item in items)
            //{
            //    var values = new object[props.Length];

            //    for (int i = 0; i < props.Length; i++)
            //    {
            //        values[i] = props[i].GetValue(item, null);
            //    }

            //    tb.Rows.Add(values);
            //}
            //return tb;
            PropertyDescriptorCollection props =
       TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in items)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
     
    }
}
