using System;

namespace Stopwatch
{
    public class Stopwatch {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _isStarted = false;

        public void Start () {
            if (_isStarted)
                throw new InvalidOperationException ("Please STOP the Stopwatch before starting!");

            this._startTime = DateTime.Now;
            _isStarted = !_isStarted;
            System.Console.WriteLine("Stopwatch is started!!");
        }

        public void Stop () {
            if (!_isStarted)
                throw new InvalidOperationException ("Please START the Stopwatch before stopping!");

            this._endTime = DateTime.Now;
            _isStarted = !_isStarted;
            System.Console.WriteLine("Stopwatch is stopped!!");
            CalculateDuration();
        }

        private void CalculateDuration () {
            if(_isStarted)
                throw new InvalidOperationException ("Cannot calculate the duration properly!");

            System.Console.WriteLine("Duration is : {0}", (this._endTime - this._startTime));
        }
    }
}