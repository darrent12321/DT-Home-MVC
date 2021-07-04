using System;
using System.Collections.Generic;

namespace DTBlog.Models
{
    public static class Repository
    {
        private static List<Blog> responses = new List<Blog>();
        public static IEnumerable<Blog> Responses => responses;
        public static void AddBlog(Blog blog)
        {
            responses.Add(blog);
        }

        public static IEnumerable<Blog> GetStaticBlogs()
        {
            return new List<Blog>
            {
                new Blog{BlogID=1, PostDate=DateTime.Parse("05-01-2021"), PosterName="DT", Title="Blog Post #1 - Basic Home Page First Draft!", PostText="Lorem ipsum dolor sit amet consectetur adipisicing elit."},
                new Blog{BlogID=2, PostDate=DateTime.Parse("05-01-2021"), PosterName="DT", Title="CSS is so easy! HAIYAA!", PostText="Lorem ipsum dolor sit amet consectetur adipisicing elit."},
                new Blog{BlogID=3, PostDate=DateTime.Parse("05-01-2021"), PosterName="DT", Title="Javascript", PostText="Well compared to CSS, Javascript is much more intuitive! Read through the basic <a href='https://www.w3schools.com/js/default.asp' target='_blank'>w3schools.com</a> tutorials first then went onto Ania Kub&oacutews <a href='https://www.youtube.com/c/AniaKub%C3%B3w/' target='_blank'>YouTube</a> channel to go through a few of the Javascript tutorials. I followed along and built a few of the games, with the intention of adding a few bits of my own to them. This led me to a deeper investigation of Javascript timers and the DOM and then further wrestling with CSS! <br>For my Javascript efforts see <a href='/Ania/ania.html'>here</a>. I only had time to style the <a href='Ania/Flappy/index.html'>Flappy Birds</a> game, but this is something I intend to come back to every now and then to brush up on both my Javascript and CSS skills."},
                new Blog{BlogID=4, PostDate=DateTime.Parse("05-01-2021"), PosterName="DT", Title="C# MVC", PostText="Lorem ipsum dolor sit amet consectetur adipisicing elit."},
                new Blog{BlogID=5, PostDate=DateTime.Parse("05-01-2021"), PosterName="DT", Title="MVC Models", PostText="Lorem ipsum dolor sit amet consectetur adipisicing elit."},
                new Blog{BlogID=6, PostDate=DateTime.Parse("05-01-2021"), PosterName="DT", Title="Partial Views", PostText="Lorem ipsum dolor sit amet consectetur adipisicing elit."}
            };
        }
    }
}