using LocalStorage.Models;
using LocalStorage.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Popups;

namespace LocalStorage.ViewModel
{
   public class MainViewModel
    {
        public DataModel DataModel { get; set; }
        public SaveCommand SaveCommand { get; set; }
        public ReadCommand ReadCommand { get; set; }
        public MainViewModel()
        {
             
            this.DataModel = new DataModel() { FileContent = "" };
            this.SaveCommand = new SaveCommand(this);
            this.ReadCommand = new ReadCommand(this);
        }

        public async void SaveMethod( string FileContent)
        {
            var LocalFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var File = await LocalFolder.CreateFileAsync("Note"
                , Windows.Storage.CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(File, FileContent);

        }
        public async void ReadMethod(string FileContent)
        {
            var LocalFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var File = await LocalFolder.GetFileAsync("Note");
            FileContent = await FileIO.ReadTextAsync(File);

            await new MessageDialog(FileContent).ShowAsync();
        }
    }
}
