using System.Collections.Generic;

namespace WorkflowEngine {
    public class Workflow : IWorkflow {

        private readonly List<IActivity> _activity;

        public Workflow () {
            _activity = new List<IActivity> ();
        }

        public void Add (IActivity activity) {
            _activity.Add (activity);
        }

        public void Remove (IActivity activity) {
            _activity.Remove (activity);
        }

        public IEnumerable<IActivity> GetActivities () {
            return _activity;
        }
    }
}