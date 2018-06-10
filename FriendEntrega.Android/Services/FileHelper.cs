using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FriendEntrega.Droid.Services;
using FriendEntrega.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace FriendEntrega.Droid.Services
{
    public class FileHelper : IfileHelper
    {
        public FileHelper()
        {
        }
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}