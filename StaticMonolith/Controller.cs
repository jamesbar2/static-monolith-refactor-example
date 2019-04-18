namespace StaticMonolith
{
    public class Controller
    {
        private readonly IProcessor _processor;

        public Controller(IProcessor processor)
        {
            _processor = processor;
        }

        public Widget PostValidate(Widget widget)
        {
            return _processor.PreProcess(widget);
        }

        public void PostCommit(Widget widget)
        {
            widget = _processor.Process(widget);
            _processor.NotifyComplete(widget);
        }
    }
}
