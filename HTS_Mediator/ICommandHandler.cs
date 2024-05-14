namespace HTS_Mediator
{
    internal interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T commande);
    }
}
