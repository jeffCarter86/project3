using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Player
    {
        //Member Variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        //Constructor
        public Player()
        {
            name = "Player 1";
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        

        // member methods (CAN DO)
    }
}
