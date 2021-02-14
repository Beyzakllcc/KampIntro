using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
