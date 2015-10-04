using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;

namespace LocalStorage.Models
{ 

    public class DataModel : INotifyPropertyChanged
    {
        public DataModel()
        { 
            if (DesignMode.DesignModeEnabled)
            {
                FileContent = "AshrafNaser";
            }
        }
        private string fileContent;

        public string FileContent
        {
            get { return fileContent; }
            set
            {
                fileContent = value;
                OnPropertyChanged("FileContent");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
