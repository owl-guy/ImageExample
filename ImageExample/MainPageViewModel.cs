using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImageExample
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public ImageSource ImageSource
        {
            get
            {
                var source = ImageSource.FromResource("ImageExample.Resources.Images.dotnet_bot.png", Assembly.GetExecutingAssembly());
                return source;
            }
        }
    }
}
