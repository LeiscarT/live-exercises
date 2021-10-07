using LiveExercises.Models;
using LiveExercises.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace LiveExercises.ViewModels
{
    public class OrientationViewModel : INotifyPropertyChanged
    {
      
        public string Orientation { get; set; }

        public ICommand GetOrientationCommand { get; }



        public OrientationViewModel()
        {
             
            GetOrientationCommand = new Command(GetOrientation);
        }

        private void GetOrientation()
        {
            DeviceOrientation getServiceOrientation = DependencyService.Get<IDeviceOrientationService>().GetDeviceOrientation();
            Orientation = getServiceOrientation.ToString();
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
