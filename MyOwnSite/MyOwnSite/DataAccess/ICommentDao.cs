using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnSite.Models;

namespace MyOwnSite.DataAccess
{
    public interface ICommentDao
    {

        Comment Get(int id);

        List<Comment> List(int postId);

        void Insert(Comment comment);

        void Update(Comment comment);

        void Delete(int id);

        List<Comment> GetCommentsByUser(int id);
    }
}
