using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnSite.Models;

namespace MyOwnSite.DataAccess
{
    public interface IPostDao
    {
        List<Post> List();

        Post Get(int id);

        void Insert(Post post);

        void Update(Post post);

        void Delete(int id);

        List<Post> GetPostsByUser(int id);

    }
}
