using System;
using System.Collections.Generic;
using System.Text;

namespace Game_project
{
    class UserValidationManager : IUserValidaitonService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Engin" && gamer.IdentityNumber == 12345)
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
