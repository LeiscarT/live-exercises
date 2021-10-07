using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LiveExercises.ViewModels
{
    public class FocusEffectViewModel : RoutingEffect
    {
        public FocusEffectViewModel() : base($"MyCompany.{nameof(FocusEffectViewModel)}")
        {

        }
    }
}
