using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTestApp.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string password = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string username = string.Empty;

        private bool CanLogin()
        {
            return Username.Length > 0 && Password.Length > 0;
        }

        [RelayCommand(CanExecute = nameof(CanLogin), IncludeCancelCommand = true)]
        private Task LoginAsync(CancellationToken cancelToken)
        {
            return Task.CompletedTask;
        }
    }
}
