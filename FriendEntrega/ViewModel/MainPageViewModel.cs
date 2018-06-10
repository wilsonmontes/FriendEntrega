using FriendEntrega.Helpers;
using FriendEntrega.Model;
using FriendEntrega.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendEntrega.ViewModel
{
    public class MainPageViewModel : Notificable
    {
        private FriendRepository friendRepository;
        public ObservableCollection
            <Grouping<string, Friend>> Friends { get; set; }
        public Command AddFriendCommand { get; set; } 
        public Command SearchCommand { get; set; }
        public Command ITemTappedCommand { get; set; }
        private Friend currentFriend;

        public  Friend CurrentFrient
        {
            get {
                return currentFriend;
            }
            set {
                SetValue(ref currentFriend, value);
            }
        }
        private string filter;

        public string Filter
        {
            get {
                return filter;
            }
            set {
                SetValue(ref filter, value);
            }
        }

        private INavigation Navigation;
        public MainPageViewModel(INavigation navigation)
        {
            friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllGrouped();
            Navigation = navigation;
            AddFriendCommand = new Command(async () => await AddFriend());
            SearchCommand = new Command(async () => await Search());
            ITemTappedCommand = new Command(async () => await NavigationToEditFriendView());
        }

        private async Task NavigationToEditFriendView()
        {
            await Navigation.PushAsync(new FriendPage(CurrentFrient));
        }

        public async Task AddFriend()
        {
            await Navigation.PushAsync(new FriendPage());
        }
    }
}
