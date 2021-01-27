using System;
using System.Collections.Generic;
using System.Text;

namespace Game_project
{
    interface ICampainManager
    {

        void CampainEntry(Gamer gamer);
        void CampainDelete(Gamer gamer);
        void CampainUpdate(Gamer gamer);

    }
}
