namespace StopWatchExercise {
    class StopWatch {
        private TimeOnly _startTime;
        private TimeSpan _duration;
        private bool _isRunning;

        public TimeSpan Duration {
            get => _duration;
            private set => _duration = value;
        }

        public void Start() {
            if (_isRunning) { return; }

            Console.WriteLine("Stopwatch started...\n");
            _startTime = TimeOnly.FromDateTime(DateTime.Now);
            _isRunning = true;
        }

        public void Stop() {
            Console.WriteLine("Stopwatch paused...\n");
            Duration += TimeOnly.FromDateTime(DateTime.Now) - _startTime;
            _startTime = default;
            _isRunning = false;
            Console.WriteLine($"Duration: {Duration.ToString("hh':'mm':'ss")}");
        }

        public void Reset() {
            Console.WriteLine("Stopwatch reset.\n");
            _startTime = default;
            _isRunning = false;
            Duration = default;
            Console.WriteLine($"Duration: {Duration.ToString("hh':'mm':'ss")}");
        }
    }
}