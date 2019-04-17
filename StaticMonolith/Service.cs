namespace StaticMonolith
{
    public class Service
    {
        public void Run(Widget widget)
        {
            widget = Processor.Instance.PreProcess(widget);
            widget = Processor.Instance.Process(widget);
            Processor.Instance.NotifyComplete(widget);
        }
    }
}