using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Utils
{
    public static class Extensions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        public static DataTable ToDisplayDataTable<T>(this IEnumerable<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                Type type = prop.PropertyType;
                if (type.IsClass)
                    type = typeof(string);
                var attributes = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                if (!attributes.Any())
                {
                    tb.Columns.Add(prop.Name, type);
                }
                else
                {
                    var displayName = attributes.Cast<DisplayNameAttribute>().Single().DisplayName;
                    tb.Columns.Add(String.IsNullOrEmpty(displayName) ? prop.Name : displayName, type);
                }
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    var enumerable = props[i].GetValue(item, null) as IEnumerable;
                    if (enumerable == null || (enumerable is string))
                        values[i] = props[i].GetValue(item, null);
                    else
                        values[i] = IEnumerableToString(enumerable);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        private static string IEnumerableToString(IEnumerable items)
        {
            var sb = new StringBuilder();
            Type type = null;
            PropertyInfo[] props = null;
            type = items.GetType().GetGenericArguments()[0];
            props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in items)
            {
                for (int i = 0; i < props.Length; i++)
                {
                    var prop = props[i];
                    var attributes = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    if (!attributes.Any())
                        sb.Append($"{prop.Name} : ");
                    else
                    {
                        var displayName = attributes.Cast<DisplayNameAttribute>().Single().DisplayName;
                        var title = String.IsNullOrEmpty(displayName) ? prop.Name : displayName;
                        sb.Append($"{title} : ");
                    }

                    var enumerable = props[i].GetValue(item, null) as IEnumerable;
                    if (enumerable == null || (enumerable is string))
                        sb.Append(props[i].GetValue(item, null));
                    else
                        sb.Append(IEnumerableToString(enumerable));
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

        // 取得 Enum 列舉 Attribute Description 設定值
        public static string GetDescriptionText(this System.Enum source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : source.ToString();
        }

        public static System.Enum ConvertDescriptionToEnum(this string str, System.Enum enu)
        {
            foreach (System.Enum brand in System.Enum.GetValues(enu.GetType()))
            {
                if (str.Equals(brand.GetDescriptionText()))
                {
                    return brand;
                }
            }

            return null;
        }
    }
}