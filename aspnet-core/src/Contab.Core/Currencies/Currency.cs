using Abp.Domain.Entities;
using Contab.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contab.Currencies
{
    public class Currency : Entity<CurrencyEnum>
    {
        public Currency(CurrencyEnum id)
        {
            Id = id;
            Name = id.ToString();
            Description = id.GetEnumDescription();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override CurrencyEnum Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)]
        public virtual string Name { get; set; }

        [StringLength(50, MinimumLength = 10)]
        public virtual string Description { get; set; }

        public static implicit operator Currency(CurrencyEnum @enum) => new Currency(@enum);

        public static implicit operator CurrencyEnum(Currency currency) => currency.Id;
    }
}
