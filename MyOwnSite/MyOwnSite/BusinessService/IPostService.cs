using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnSite.Models;

namespace MyOwnSite.BusinessService
{
    public interface IPostService
    {
        List<Post> List();
        List<Post> ListMessageLimit();

        Post Get(int id);

        void Insert(Post post);

        void Update(Post post);

        void Delete(int id);

        List<Post> GetPostsByUser(int id);

    }
}
