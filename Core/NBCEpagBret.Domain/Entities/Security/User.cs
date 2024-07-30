using System.Text;
using NBCEpagBret.Domain.Common;
using NBCEpagBret.Tool;

namespace NBCEpagBret.Domain.Entities.Security
{
    /// <summary>
    /// Сущность: пользователь.
    /// </summary>
    public class User : BaseAuditableEntity
    {
        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        public String Email { get; set; } = default!;

        /// <summary>
        /// Хеш пароля.
        /// </summary>
        public String PasswordHash { get; set; } = default!;

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public String Surname { get; set; } = default!;

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public String? Name { get; set; }

        /// <summary>
        /// Отчество пользователя.
        /// </summary>
        public String? Patronymic { get; set; }

        /// <summary>
        /// Возвращает ФИО пользователя в формате 'Фамилия Имя Отчество'.
        /// </summary>
        public String LongSNP
        {
            get
            {
                var result = new StringBuilder(Surname.FirstCharToUpper());
                if (!String.IsNullOrEmpty(Name))
                {
                    result.Append(' ').Append(Name.FirstCharToUpper());
                    if (!String.IsNullOrEmpty(Patronymic))
                    {
                        result.Append(' ').Append(Patronymic.FirstCharToUpper());
                    }
                }
                return result.ToString();
            }
        }

        /// <summary>
        /// Возвращает ФИО пользователя в формате 'Фамилия И. О.'.
        /// </summary>
        public String ShortSNP
        {
            get
            {
                var result = new StringBuilder(Surname.FirstCharToUpper());
                if (!String.IsNullOrEmpty(Name))
                {
                    result.Append(' ')
                        .Append(Char.ToUpper(Name[0]))
                        .Append('.');
                    if (!String.IsNullOrEmpty(Patronymic))
                    {
                        result.Append(' ')
                            .Append(Char.ToUpper(Patronymic[0]))
                            .Append('.');
                    }
                }
                return result.ToString();
            }
        }
    }
}