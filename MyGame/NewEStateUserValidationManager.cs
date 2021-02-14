using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
