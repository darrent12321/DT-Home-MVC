using System.Collections.Generic;

namespace DTBlog.Models
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> AllBlogs {get; }

    }
}