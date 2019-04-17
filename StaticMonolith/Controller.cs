namespace StaticMonolith
{
    public class Controller
    {
        public Widget PostValidate(Widget widget)
        {
            return Processor.PreProcess(widget);
        }

        public void PostCommit(Widget widget)
        {
            widget = Processor.Process(widget);
            Processor.NotifyComplete(widget);
        }
    }
}
