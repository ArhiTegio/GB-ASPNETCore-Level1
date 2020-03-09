using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class ModelBlogSingle
    {
        public BlogPostArea Blog_PostArea { get; set; }
        public ModelBlogPost[] Comments { get; set; }

        public string PicSocialshare { get; set; }
        public ModelBlogPost FirstCommit { get; set; }

        public Tag TagItem { get; set; }

        public ModelBlogSingle(BlogPostArea blog, ModelBlogPost comment, ModelBlogPost[] comments, string picSocialshare, Tag tag)
        {
            Blog_PostArea = blog;
            Comments = comments;
            PicSocialshare = picSocialshare;
            FirstCommit = comment;
            TagItem = tag;
        }
    }

    public class BlogPostArea : IModelBlogPost
    {
        public string Title { get; set; }
        public string User { get; set; }
        public string Clock { get; set; }
        public string Date { get; set; }
        public string Pic { get; set; }
        public string Context { get; set; }
        public string[] ArrayContext { get; set; }

        public BlogPostArea(string title, string user, string clock, string date, string pic, string[] context)
        {
            Title = title;
            User = user;
            Clock = clock;
            Date = date;
            Pic = pic;
            ArrayContext = context;
        }
    }

    public class Tag
    {
        public string[] Tags { get; set; }
        public string Vots { get; set; }

        public Tag(string[] tags, string vots)
        {
            Tags = tags;
            Vots = vots;
        }
    }
}
