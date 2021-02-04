using System;
using System.Collections.Generic;
using System.Text;

namespace GameSelling2
{
    interface IOrderService
    {
        void Buy(Gamer gamer,Game game);
    }
}
