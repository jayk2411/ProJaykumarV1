using System.ComponentModel.DataAnnotations;

namespace ProJaykumarV1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}