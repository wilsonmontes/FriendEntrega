﻿using FriendEntrega.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendEntrega.Model
{
    public class FriendRepository
    {
        public IList<Friend> Friends { get; set; }
        public FriendRepository()
        {
            Task.Run(async () =>
                Friends = await App.Database.GetFriendsAsync()).Wait();
        }
        public IList<Friend> GetAll()
        {
            return Friends;
        }
        public ObservableCollection
            <Grouping<string, Friend>>
            GetAllGrouped()
        {
            IEnumerable<Grouping<string, Friend>> sorted = new Grouping<string, Friend>[0];
            if (Friends != null)
            {
                sorted =
                from f in Friends
                orderby f.Nombre
                group f by f.Nombre[0].ToString()
                into theGroup
                select
                new Grouping<string, Friend>
                (theGroup.Key, theGroup);
            }
             
            return new
                ObservableCollection
                <Grouping<string, Friend>>(sorted);
        }
    }
}
