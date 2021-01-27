using System;
using System.Collections.Generic;
using System.Text;

namespace Game_project
{
    //MicroService
    class GamerManager : IGamerServices
    {
        IUserValidaitonService _userValidationService;

        public GamerManager(IUserValidaitonService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayit Oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz. Kayit Basarisiz");

            }
        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Güncellendi");
        }
    }
}
