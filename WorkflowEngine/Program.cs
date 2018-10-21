using System;

namespace WorkflowEngine {
    class Program {
        static void Main (string[] args) {
            Workflow workflow = new Workflow ();

            workflow.Add (new VideoUploader ());
            workflow.Add (new WebServiceCaller ());
            workflow.Add (new EmailSender ());
            workflow.Add (new StatusChanger ());

            var engine = new WorkflowEngine ();
            engine.Run (workflow);
        }
    }
}