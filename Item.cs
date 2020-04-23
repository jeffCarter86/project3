using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public abstract class Item
    {

        // liskov principle example: you can easily
        //exchange each specific item with the Item Class and the functionality will be the same and they all 
        //have the same property of name.
        public string name;
        public Item()
        {

        }
    }
}
