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
            return Char.ToUpper(value[0]) + value[1..].ToLower();
        }
    }
}