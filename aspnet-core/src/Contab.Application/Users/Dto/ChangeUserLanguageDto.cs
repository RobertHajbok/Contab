using System.ComponentModel.DataAnnotations;

namespace Contab.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}