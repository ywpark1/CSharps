using System;
using System.Collections.Generic;

namespace SimpleStack {
    class Stack {
        private List<object> _list;

        public Stack () {
            _list = new List<object> ();
        }

        public void Push (object obj) {
            _list.Add (obj);
        }

        public object Pop () {
            if (_list.Count == 0) {
                throw new InvalidOperationException ("Current Stack is empty.");
            }
            var item = _list[_list.Count - 1];
            _list.Remove (item);

            return item;
        }

        public void Clear () {
            _list.Clear ();
        }
    }
}