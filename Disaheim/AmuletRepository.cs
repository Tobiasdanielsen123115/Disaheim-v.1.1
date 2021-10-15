using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets; // husk at instanisere den som på 12-15 linje
        Utility utility = new Utility();
        
        public AmuletRepository()
        {
            amulets = new List<Amulet>(); // det der herinde er det der køre, hvis vi kalder AmuletRepository
        }
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            for (int i = 0; i < amulets.Count; i++)//foreach kan også bruge så starter vi med at sige result = null 
            {
                if (amulets[i].ItemId == itemId)
                {
                    return amulets[i];

                }

            }
            return null;


        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < amulets.Count; i++)
            {
                totalValue = totalValue + utility.GetValueOfMerchandise(amulets[i]);
                //totalValue += totalValue.utility.GetValueOfAmulet(amulets[i]);//same 

            }
            return totalValue;

        }
 
    
    }    
      


}
