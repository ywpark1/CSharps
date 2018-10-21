using System.Collections.Generic;

namespace WorkflowEngine {
    public interface IWorkflow {
        void Add (IActivity activity);
        void Remove (IActivity activiy);
        IEnumerable<IActivity> GetActivities ();
    }
}