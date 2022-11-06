using fall_project_2.enums;

namespace fall_project_2.interfaces;

public interface IWalletService
{
    Wallet CreateWallet(User user, string walletName, Currency currency);

    ICollection<Wallet> GetUserWallets(User user);
}