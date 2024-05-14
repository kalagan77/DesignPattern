namespace HTS_Mediator
{
    internal interface IMediator
    {
        void RegisterHandler<T>(ICommandHandler<T> handler) where T : ICommand;
        Task Handle<T>(T command) where T : ICommand;
    }
}