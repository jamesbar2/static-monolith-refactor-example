using System;

namespace StaticMonolith
{
    public class Processor
    {

        public static Widget PreProcess(Widget widget)
        {
            CalculateFoo(widget);
            return widget;
        }

        public static Widget Process(Widget widget)
        {
            CommitFoo(widget);
            return widget;
        }

        public static void NotifyComplete(Widget widget)
        {
            // send an e-mail or something...
        }

        private static Widget CommitFoo(Widget widget)
        {
            var repo = new RepositoryA();
            widget = repo.Set(widget.Id, widget.Value);
            return widget;
        }

        private static void CalculateFoo(Widget widget)
        {
            Console.WriteLine("Calculating Foo");
        }
    }
}