using Logic.DalInterfaces;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class CommentManager : ICommentManager
    {
        private ICommentDataManager CommentDataManager;
         
        public CommentManager(ICommentDataManager commentDataManager)
        {
            CommentDataManager = commentDataManager;
        }

        public void AddComment(string msg)
        {
            CommentDataManager.AddComment(msg);
        }

        public List<string> GetComments()
        {
            
            return CommentDataManager.GetComments();
        }
    }
}
