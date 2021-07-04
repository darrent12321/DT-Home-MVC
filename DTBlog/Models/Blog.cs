using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTBlog.Models {
    public class Blog {
        public long BlogID {get; set;}
        public DateTime PostDate { get; set; }
        public string PosterName { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }

    }
}