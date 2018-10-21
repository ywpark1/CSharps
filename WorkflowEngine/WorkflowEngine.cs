using System.Collections.Generic;

namespace WorkflowEngine {
    public class WorkflowEngine {
        private readonly List<IActivity> _activity;

        public WorkflowEngine () {
            _activity = new List<IActivity> ();
        }

        public void Run () {
            var counter = 1;
            foreach (var activity in _activity) {
                System.Console.Write (counter + " - ");
                activity.Execute ();
                counter++;
            }
        }

        public void RegisterWorkflow (IActivity activity) {
            _activity.Add (activity);
        }
    }
}