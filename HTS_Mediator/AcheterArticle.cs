using System;
namespace HTS_Mediator
{
    internal class AcheterArticle : ICommand
    {
        public string Article { get; set; }
        public AcheterArticle(string article)
        {
            Article = article;
        }
    }
}
