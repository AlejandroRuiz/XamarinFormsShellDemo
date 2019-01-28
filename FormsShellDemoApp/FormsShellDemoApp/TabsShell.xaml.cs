using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsShellDemoApp
{
    public partial class TabsShell : Shell
    {
        public TabsShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("myawesomepage", typeof(HomePage));
        }

        public void Handle_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            //Cancel Navigation if needed
           // e.Cancel();
        }
    }
}
