using System;
using System.Collections.Generic;
using System.Text;

namespace GameSelling2
{
     class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDate==1985 && gamer.FirstName=="Engin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
