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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Example1.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {

        private SaveFile SaveFile;
        public BlankPage1()
        {
            this.InitializeComponent();
            this.SaveFile = new SaveFile();
        }

        private async System.Threading.Tasks.Task SaveFileButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            this.SaveFile.fileName = this.NameFile.Text;
            this.SaveFile.content = this.Content.Text;

            Windows.Storage.StorageFolder storageFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
            await storageFolder.CreateFileAsync("file.txt",
            Windows.Storage.CreationCollisionOption.ReplaceExisting);
            var savePicker = new Windows.Storage.Pickers.FileSavePicker();
            savePicker.SuggestedStartLocation =
                Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = "New Document";
        }
    }
}
