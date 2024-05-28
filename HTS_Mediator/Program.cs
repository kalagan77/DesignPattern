using HTS_Mediator;

var mediator = new Mediator();
mediator.RegisterHandler(new AcheterArticleHandler());

await mediator.Handle(new AcheterArticle("marteur"));
await mediator.Handle(new AcheterArticle("scie"));



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
