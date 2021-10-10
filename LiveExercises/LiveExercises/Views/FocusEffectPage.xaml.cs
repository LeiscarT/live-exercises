using LiveExercises.ViewModels;
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
    public partial class FocusEffectPage : ContentPage
    {
        public FocusEffectPage()
        {
            var entry = new Entry
            {
                Text = "Effect attached to an Entry",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,

            };

            entry.Effects.Add(Effect.Resolve($"MyCompany.{nameof(FocusEffect)}"));

            Content = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children =
                {
                    new Label
                    {
                        Text = "Effect",
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    },
                    entry
                }
            };
        }
    }
}