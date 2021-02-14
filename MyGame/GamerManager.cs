using System;

namespace MyGame
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userVlidationServices;
        public GamerManager(IUserValidationService userVlidationServices)
        {
            _userVlidationServices = userVlidationServices;
        }   
        public void Add(Gamer gamer)
        {
            if (_userVlidationServices.Validate(gamer)==true)
            {
            Console.WriteLine("Kayıt Oldu"); 
            }
            else
            {
                Console.WriteLine("Doğrulama Bşarısız. Kayıt Başarısız");
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
