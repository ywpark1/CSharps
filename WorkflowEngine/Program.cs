using System;

namespace WorkflowEngine {
    class Program {
        static void Main (string[] args) {
            WorkflowEngine workflow = new WorkflowEngine ();

            workflow.RegisterWorkflow (new VideoUploader ());
            workflow.RegisterWorkflow (new WebServiceCaller ());
            workflow.RegisterWorkflow (new EmailSender ());
            workflow.RegisterWorkflow (new StatusChanger ());

            workflow.Run ();
        }
    }
}