using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuth.Models
{
    public class ArticleModel
    {
        private readonly ArticleContext context;
        public Article GetArticleById(int id)
        {
            return context.Articles.Single(x => x.Id == id);
        }
    }
}
