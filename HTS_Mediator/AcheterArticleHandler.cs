namespace HTS_Mediator
{
    internal class AcheterArticleHandler : ICommandHandler<AcheterArticle>
    {
        public Task HandleAsync(AcheterArticle commande)
        {
            Console.WriteLine("Article acheté : " + commande.Article);
            return Task.CompletedTask;
        }
    }
}
