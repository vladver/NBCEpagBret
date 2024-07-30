using System.Text;

namespace NBCEpagBret.Tool
{
    public static class StringExtensions
    {
        /// <summary>
        /// Возвращает строку с первым символом в верхнем регистре, а остальными
        /// в нижнем.
        /// </summary>
        public static String FirstCharToUpper(this String value)
        {
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                return String.Empty;
            }
            var result = new StringBuilder();
            if (value.Length > 1)
            {
                result.Append(Char.ToUpper(value[0])).Append(value[1..].ToLower());
            }
            else
            {
                result.Append(Char.ToUpper(value[0]));
            }
            return result.ToString();
        }
    }
}