using System;
using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;
namespace FormsShellDemoApp
{
    public class TabsShellViewModel : BaseViewModel
    {
        public TabsShellViewModel()
        {
            NavigateCommand = new Command<string>(InvokeNavigateCommand);
        }

        public ICommand NavigateCommand { get; }

        public void InvokeNavigateCommand(string id)
        {
            Shell.CurrentShell.GoToAsync($"app:///home/tabs/favorites/myfavorites?text={id}", true);
            Shell.CurrentShell.FlyoutIsPresented = false;
        }
    }
}
