using CommunityToolkit.Mvvm.ComponentModel;
using Dollet.Core.Entities;

[QueryProperty(nameof(Account), "Account")]
public partial class EditAccountPageViewModel : ObservableObject
{
    private Account account;

    public Account Account
    {
        get => account;
        set
        {
            SetProperty(ref account, value);
        }
    }

    public EditAccountPageViewModel()
    {
        
    }
}