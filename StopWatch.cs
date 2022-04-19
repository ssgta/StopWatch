namespace StopWatchExercise {
    class StopWatch {
        private TimeOnly _startTime;
        private TimeSpan _duration;

        public TimeSpan Duration {
            get => _duration;
            private set => _duration = value;
        }

        public void Start() {
            Console.WriteLine("Stopwatch started...\n");
            _startTime = TimeOnly.FromDateTime(DateTime.Now);
        }

        public void Stop() {
            Console.WriteLine("Stopwatch paused...\n");
            Duration += TimeOnly.FromDateTime(DateTime.Now) - _startTime;
            _startTime = default;
        }

        public void Reset() {
            Console.WriteLine("Stopwatch reset.\n");
            _startTime = default;
            Duration = default;
        }
    }
}