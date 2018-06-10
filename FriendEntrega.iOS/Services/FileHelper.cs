
using FriendEntrega.iOS.Services;
using FriendEntrega.Services;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace FriendEntrega.iOS.Services
{
    public class FileHelper : IfileHelper
    {
        public FileHelper()
        {

        }
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder,"..", "DataBases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);

            }
            return Path.Combine(libFolder,fileName);
        }
    }
}