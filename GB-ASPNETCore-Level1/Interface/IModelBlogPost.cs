using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Interface
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
}
