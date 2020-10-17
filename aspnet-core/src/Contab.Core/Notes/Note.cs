using Abp.Domain.Entities.Auditing;
using Contab.Authorization.Users;
using System.ComponentModel.DataAnnotations;

namespace Contab.Notes
{
    public class Note : AuditedEntity
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public virtual string Title { get; set; }

        [Required]
        [StringLength(5000, MinimumLength = 20)]
        public virtual string Text { get; set; }

        public virtual long UserId { get; set; }

        public User User { get; set; }
    }
}
