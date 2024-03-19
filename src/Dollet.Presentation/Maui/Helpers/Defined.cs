using Dollet.Helpers.Fonts;
using System.Collections.ObjectModel;

namespace Dollet.Helpers
{
    internal static class Defined
    {
        public static ObservableCollection<string> Icons =>
        [
            MaterialDesignIcons.Account_balance,
            MaterialDesignIcons.Account_balance_wallet,
            MaterialDesignIcons.Wallet,
            MaterialDesignIcons.Savings,
            MaterialDesignIcons.Credit_card,
            MaterialDesignIcons.Paid,
            MaterialDesignIcons.Euro,
            MaterialDesignIcons.Wallet_giftcard,
            MaterialDesignIcons.Currency_exchange
        ];

        public static ObservableCollection<string> Colors =>
        [
            "#d2b7b7", "#a76e6e", "#88af95", "#819a78", "#7782b0", "#606a9f", "#e39e83",
            "#855e5c", "#f7e2a9", "#d3bae1", "#f0e6ab", "#ffc8c8", "#979393", "#fe4f78"
        ];

        public static ObservableCollection<string> Currencies =>
        [
            "PLN", "EUR", "USD", "CHF", "GBP"
        ];
    }
}
