using System.ComponentModel.DataAnnotations;

namespace Contab.Notes.Dto
{
    public class CreateNoteDto
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public virtual string Title { get; set; }

        [Required]
        [StringLength(5000, MinimumLength = 20)]
        public virtual string Text { get; set; }
    }
}
