/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System.IO;
using Xamarin.Forms;
using SQLite.Helpers;
using Windows.Storage;
using DRS_Mobile_MVVM.UWP.Helpers;

[assembly: Dependency(typeof(FileHelper))]
namespace DRS_Mobile_MVVM.UWP.Helpers
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
