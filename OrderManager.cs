using System;
using System.Collections.Generic;
using System.Text;

namespace GameSelling2
{
    class OrderManager : IOrderService
    {
        public void Buy(Gamer gamer,Game game)
        {
            Console.WriteLine("{0} adlı oyun {1} tarafından satın alındı ",game.GameName,gamer.FirstName);
        }
    }
}
