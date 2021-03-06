﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Notes.ViewModels;


namespace Notes.Views
{
   
    public sealed partial class ReadNote : Page
    {
        

        public ReadNote()
        {
            this.InitializeComponent();
        }

        public ReadViewModel ViewModel => DataContext as ReadViewModel;


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.LoadList();
            base.OnNavigatedTo(e);
        }
    }
}
