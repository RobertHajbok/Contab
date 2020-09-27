using Abp.Domain.Entities.Auditing;
using Contab.Authorization.Users;
using Contab.Currencies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contab.Cards
{
    public class Card : AuditedEntity
    {
        [Required]
        [StringLength(2, MinimumLength = 15)]
        public virtual string Name { get; set; }

        public virtual CardTypeEnum CardTypeId { get; set; }

        [ForeignKey(nameof(CardTypeId))]
        public CardType CardType { get; set; }

        public virtual CurrencyEnum CurrencyId { get; set; }

        [ForeignKey(nameof(CurrencyId))]
        public Currency Currency { get; set; }

        public virtual long UserId { get; set; }

        public User User { get; set; }
    }
}
