namespace WorkflowEngine
{
    public class WebServiceCaller : IActivity {
        public void Execute () {
            System.Console.WriteLine ("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding. ");
        }
    }
}