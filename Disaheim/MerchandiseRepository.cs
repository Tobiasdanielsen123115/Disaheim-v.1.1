using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises;
        Utility utility = new Utility();


        public MerchandiseRepository()
        {
            merchandises = new List <Merchandise>();
        }
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            {
                for (int i = 0; i < merchandises.Count; i++)//foreach kan også bruge så starter vi med at sige result = null 
                {
                    if (merchandises[i].ItemId == itemId)
                    {
                        return merchandises[i];

                    }

                }
                return null;


            }

        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < merchandises.Count; i++)
            {
                totalValue = totalValue + utility.GetValueOfMerchandise(merchandises[i]);
                //totalValue += totalValue.utility.GetValueOfAmulet(amulets[i]);//same 

            }
            return totalValue;

        }

    }
}
