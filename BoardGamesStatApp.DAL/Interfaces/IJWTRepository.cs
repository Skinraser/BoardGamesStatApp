using BoardGamesStatApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.DAL.Interfaces
{
    public interface IJWTRepository
    {
        Tokens Authentificate(User user);
    }
}
