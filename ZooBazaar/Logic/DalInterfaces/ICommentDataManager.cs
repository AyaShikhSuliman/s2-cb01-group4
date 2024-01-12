using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DalInterfaces
{
    public interface ICommentDataManager
    {
        void AddComment(string msg);
        List<string> GetComments();
    }
}
