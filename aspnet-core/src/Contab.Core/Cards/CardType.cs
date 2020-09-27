using Abp.Domain.Entities;
using Contab.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contab.Cards
{
    public class CardType : Entity<CardTypeEnum>
    {
        public CardType(CardTypeEnum id)
        {
            Id = id;
            Name = id.ToString();
            Description = id.GetEnumDescription();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override CardTypeEnum Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)]
        public virtual string Name { get; set; }

        [StringLength(50, MinimumLength = 10)]
        public virtual string Description { get; set; }

        public static implicit operator CardType(CardTypeEnum @enum) => new CardType(@enum);

        public static implicit operator CardTypeEnum(CardType cardType) => cardType.Id;
    }
}
