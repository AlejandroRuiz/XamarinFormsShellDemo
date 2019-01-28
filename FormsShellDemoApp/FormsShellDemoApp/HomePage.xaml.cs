using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsShellDemoApp
{
    [QueryProperty("Text", "text")]
    public partial class HomePage : ContentPage
    {
        string _text;

        public HomePage()
        {
            InitializeComponent();
        }

        public string Text
        {
            get => _text;
            set => _text = textLabel.Text = value;
        }
    }
}
