﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FriendEntrega.Helpers
{
    public class Grouping<K, T>: ObservableCollection<T>
    {
        public K Key { get; set; }
        public Grouping(K key, IEnumerable<T> items)
        {
            this.Key = key;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
