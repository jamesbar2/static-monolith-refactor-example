namespace StaticMonolith
{
    public class Service
    {
        public void Run(Widget widget)
        {
            widget = Processor.PreProcess(widget);
            widget = Processor.Process(widget);
            Processor.NotifyComplete(widget);
        }
    }
}