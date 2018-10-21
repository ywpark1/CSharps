using System.Collections.Generic;

namespace WorkflowEngine {
    public class WorkflowEngine {

        public void Run (IWorkflow workflow) {
            var counter = 1;
            foreach (var activity in workflow.GetActivities ()) {
                try {
                    System.Console.Write (counter + " - ");
                    activity.Execute ();
                    counter++;
                } catch (System.Exception) {

                    throw;
                }

            }
        }
    }
}