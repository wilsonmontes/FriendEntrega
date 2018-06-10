using FriendEntrega.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendEntrega.ViewModel
{
    public class FriendViewModel
    {
        public Command SaveFriendCommand { get; set; }
        public Friend FriendModel { get; set; }
        private INavigation Navigation;

        public Command DeleteCommand { get; set; }
        public bool IsEnable { get; set; }

        public FriendViewModel(INavigation navigation)
        {
            FriendModel = new Friend();
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public FriendViewModel(INavigation navigation, Friend friend)
        {
            FriendModel = new Friend();
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public async Task SaveFriend()
        {
            await App.Database.SavefriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }
    }
}
