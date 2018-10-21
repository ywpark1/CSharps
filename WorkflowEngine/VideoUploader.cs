namespace WorkflowEngine
{
    public class VideoUploader : IActivity {
        public void Execute () {
            System.Console.WriteLine ("Upload a video to a cloud storage.");
        }
    }
}