using System.ComponentModel;

namespace Contab.Currencies
{
    public enum CurrencyEnum
    {
        [Description("Euro")]
        EUR = 1,

        [Description("Pound sterling")]
        GBP,

        [Description("Romanian leu")]
        RON
    }
}
