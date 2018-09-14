using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IsBusyPoc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        public bool IsEnabled
        {
            get { return (bool)GetValue(IsEnabledProperty); }
            set { SetValue(IsEnabledProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsEnabled.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.Register("IsEnabled", typeof(bool), typeof(MainPage), new PropertyMetadata(null));



        public bool IsLoadingToolkit
        {
            get { return (bool)GetValue(IsLoadingToolkitProperty); }
            set { SetValue(IsLoadingToolkitProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsLoadingToolkit.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLoadingToolkitProperty =
            DependencyProperty.Register("IsLoadingToolkit", typeof(bool), typeof(MainPage), new PropertyMetadata(null));

        public bool IsLoadingTelerik
        {
            get { return (bool)GetValue(IsLoadingTelerikProperty); }
            set { SetValue(IsLoadingTelerikProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsLoadingTelerik.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLoadingTelerikProperty =
            DependencyProperty.Register("IsLoadingTelerik", typeof(bool), typeof(MainPage), new PropertyMetadata(null));

        public MainPage()
        {
            this.InitializeComponent();

            (this as FrameworkElement).DataContext = this;

            IsEnabled = true;
        }

        private void OnIsLoadingClick(object sender, RoutedEventArgs e)
        {
            IsLoadingToolkit = !IsLoadingToolkit;
            IsEnabled = !IsLoadingToolkit;
        }

        private void OnIsLoading2Click(object sender, RoutedEventArgs e)
        {
            IsLoadingTelerik = !IsLoadingTelerik;
            IsEnabled = !IsLoadingTelerik;
        }
    }
}
