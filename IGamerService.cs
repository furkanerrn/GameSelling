using System;
using System.Collections.Generic;
using System.Text;

namespace GameSelling2
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
