using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowIT
{
    public class Item
    {
        private string itemName;
        private string who;
        
        public string GetItemName()
        {
            return itemName;
        }

        public string GetWho()
        {
            return who;
        }

        public void SetItemName(string itn)
        {
            itemName = itn;
        }

        public void SetWho(string w)
        {
            who = w;
        }

        public Item (string itn, string w)
        {
            itemName = itn;
            who = w;
        }
    }
}
