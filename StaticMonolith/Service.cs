namespace StaticMonolith
{
    public class Service
    {
        private readonly IProcessor _processor;

        public Service(IProcessor processor)
        {
            _processor = processor;
        }
        public void Run(Widget widget)
        {
            widget = _processor.PreProcess(widget);
            widget = _processor.Process(widget);
            _processor.NotifyComplete(widget);
        }
    }
}