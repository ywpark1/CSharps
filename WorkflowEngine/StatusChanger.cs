namespace WorkflowEngine
{
    public class StatusChanger : IActivity {
        public void Execute () {
            System.Console.WriteLine ("Change the status of the video record in the database to 'Processing'.");
        }
    }
}