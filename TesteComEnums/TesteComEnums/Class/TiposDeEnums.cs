using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TesteComEnums.Class
{

    public static class ExtensionTiposDeEnums
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            
            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }

    public class TiposDeEnums
    {
        public enum Tipos
        {
            [Description("Número 1")]
            numero1 = 1,

            [Description("Número 2")]
            numero2 = 2,

            [Description("Número 3")]
            numero3 = 3,

            [Description("Número 4")]
            numero4 = 4,
        }
    }
}
