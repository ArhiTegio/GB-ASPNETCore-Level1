using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WebStore.Models
{
    public interface IModelBlogPost
    {
        string Title { get; set; }
        string User { get; set; }
        string Clock { get; set; }
        string Date { get; set; }
        string Pic { get; set; }
        string Context { get; set; }
    }

    public class ModelBlogPost : IModelBlogPost
    {
        public string Title { get; set; }
        public string User { get; set; }
        public string Clock { get; set; }
        public string Date { get; set; }

        public string Pic { get; set; }
        public string Context { get; set; }

        public ModelBlogPost(string title, string user, string clock, string date, string pic, string context)
        {
            Title = title;
            User = user;
            Clock = clock;
            Date = date;
            Pic = pic;
            Context = context;
        }
    }
}
