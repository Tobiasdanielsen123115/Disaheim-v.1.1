using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public abstract class Merchandise // vi kan ikke længere instanisere fra denne klasse da den er abstract, vi kan KUN nedarve
    {

        private string itemId; // det merchandise kan, kan amulet og book også grundet nedarvining.

        
        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

       

        public override string ToString()
        {
            return "ItemId: " + itemId;
        }














    }
}
