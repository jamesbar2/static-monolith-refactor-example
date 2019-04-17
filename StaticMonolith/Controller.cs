namespace StaticMonolith
{
    public class Controller
    {
        public Widget PostValidate(Widget widget)
        {
            return Processor.Instance.PreProcess(widget);
        }

        public void PostCommit(Widget widget)
        {
            widget = Processor.Instance.Process(widget);
            Processor.Instance.NotifyComplete(widget);
        }
    }
}
