using System;

namespace StaticMonolith
{
    public interface IProcessor
    {
        Widget PreProcess(Widget widget);
        Widget Process(Widget widget);
        void NotifyComplete(Widget widget);
    }

    public class Processor : IProcessor
    {
        private readonly IRepositoryA _repositoryA;
        private static readonly Lazy<IProcessor> LazyProcessor = new Lazy<IProcessor>(() => new Processor());
        public static IProcessor Instance => LazyProcessor.Value;

        private Processor() : this(new RepositoryA())
        {
            // don't allow this to be constructed without dependencies
            // if this class is needed, .Instance must be called, otherwise, DI!
        }

        public Processor(IRepositoryA repositoryA)
        {
            _repositoryA = repositoryA;
        }

        public Widget PreProcess(Widget widget)
        {
            CalculateFoo(widget);
            return widget;
        }

        public Widget Process(Widget widget)
        {
            CommitFoo(widget);
            return widget;
        }

        public void NotifyComplete(Widget widget)
        {
            // send an e-mail or something...
        }

        private Widget CommitFoo(Widget widget)
        {
            widget = _repositoryA.Set(widget.Id, widget.Value);
            return widget;
        }

        private void CalculateFoo(Widget widget)
        {
            Console.WriteLine("Calculating Foo");
        }
    }

}