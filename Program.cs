using System;

namespace GameSelling2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gm = new GamerManager(new UserValidationManager( ));
            gm.Add(new Gamer { Id = 1, FirstName = "Egin", IdentityNumber = true, LastName = "Eren" ,BirthDate=1985}) ;
            OrderManager om = new OrderManager();
            //om.Buy(new Gamer({ FirstName = "Furkan", Id = 3, BirthDate = 1900, LastName = "Eren", IdentityNumber = true });) ; new Game({ GameName = "Farcry", Id = 1 }); 
        }
    }
}
