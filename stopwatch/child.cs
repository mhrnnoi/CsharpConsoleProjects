using System;
using System.Collections.Generic;
using System.Collections;


namespace intermediate
{
    public class StopWatch
    {
        private DateTime _time;
        public TimeSpan _duration { get; private set; }

        public void Stop()
        {
            if (_time == DateTime.MinValue)
                throw new Exception();

            _duration = (DateTime.Now - _time );
            _time = DateTime.MinValue;

        }

        public void Start()
        {
            if (_time != DateTime.MinValue )
                throw new Exception();
            _time = DateTime.Now;
        }
    }
}
