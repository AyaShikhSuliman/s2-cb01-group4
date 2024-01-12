using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface ILoginManager
    {
        bool IsAdmin(string username, string password);
        bool IsScheduler(string username, string password);



    }
}
