using LiveExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiveExercises.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomRenderPage : ContentPage
    {
        public CustomRenderPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Hello, Custom Renderer !",
                    },
                    new MyEntry
                    {
                        Text = "In Shared Code",
                    }
                },
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
               
            };
        }
    }
}