﻿using System;

namespace StaticMonolith
{
    public class Processor
    {
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
            var repo = new RepositoryA();
            widget = repo.Set(widget.Id, widget.Value);
            return widget;
        }

        private void CalculateFoo(Widget widget)
        {
            Console.WriteLine("Calculating Foo");
        }
    }

}