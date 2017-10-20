using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDemoLayout.ViewModel;
using Xamarin.Forms;

namespace WorkingDemoLayout
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            //DateLabel.Text = DateTime.Now.ToFileTimeUtc().ToString();

            DateLabel.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff");
            vm = new MainPageViewModel();
            BindingContext= vm;
        }
    }
}
