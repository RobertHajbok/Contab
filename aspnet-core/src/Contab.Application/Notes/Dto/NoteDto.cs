using Abp.Application.Services.Dto;
using Contab.Users.Dto;
using System.ComponentModel.DataAnnotations;

namespace Contab.Notes.Dto
{
    public class NoteDto : AuditedEntityDto<int>
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public virtual string Title { get; set; }

        [Required]
        [StringLength(5000, MinimumLength = 20)]
        public virtual string Text { get; set; }

        public UserDto User { get; set; }
    }
}
