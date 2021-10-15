using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Yapıldı");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
          
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
           
        }
    }
}
