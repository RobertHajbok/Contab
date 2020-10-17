using Abp.Domain.Entities.Auditing;
using Contab.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace Contab.Operations
{
    public class Operation : AuditedEntity
    {
        public virtual long UserId { get; set; }

        public User User { get; set; }

        public virtual decimal AddSubtract { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 100)]
        public virtual string Reason { get; set; }

        public virtual DateTime OperationDate { get; set; }
    }
}
