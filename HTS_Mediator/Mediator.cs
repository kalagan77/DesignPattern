namespace HTS_Mediator
{
    internal class Mediator : IMediator
    {
        private Dictionary<Type, List<object>> handlers = new Dictionary<Type, List<object>>();

        public async Task Handle<T>(T command) where T : ICommand
        {
            List<object> localHandlers;
            if(handlers.TryGetValue(command.GetType(), out localHandlers))
            {
                foreach (var handler in localHandlers)
                {
                    await ((ICommandHandler<T>)handler).HandleAsync(command);
                }
            }
        }

        public void RegisterHandler<T>(ICommandHandler<T> handler) where T : ICommand
        {
            Type commandType = typeof(T);
            if(handlers.ContainsKey(commandType)){
                handlers[commandType].Add(handler);
            }
            else
            {
                handlers.Add(commandType, new List<object>() { handler});
            }

        }
    }
}
