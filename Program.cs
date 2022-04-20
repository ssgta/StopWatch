namespace StopWatchExercise {
    class Program {
        static void Main() {
            RunStopWatch();
        }

        private static void RunStopWatch() {
            var stopWatch = new StopWatch();
            bool runStopWatch = true;

            while (runStopWatch) {
                if (stopWatch != null) {
                    var userChoice = GetUserInput();

                    switch (userChoice) {
                        case 1:
                            stopWatch.Start();
                            break;
                        case 2:
                            stopWatch.Stop();
                            break;
                        case 3:
                            stopWatch.Reset();
                            break;
                        default:
                            runStopWatch = false;
                            break;
                    }
                }
            }
        }

        private static int GetUserInput() {
            Console.Write("Please key a number to: " +
                "\n 1. Start" +
                "\n 2. Stop " +
                "\n 3. Reset" +
                "\n 4. Exit \n");

            Console.Write("Choice: ");
            var decision = Console.ReadLine();

            if (decision is not null) {
                try {
                    var choice = Int32.Parse(decision);

                    return choice switch {
                        1 => 1,
                        2 => 2,
                        3 => 3,
                        _ => 4
                    };
                }
                catch (Exception) {
                    Console.WriteLine("Invalid choice. Exiting.");
                    return 4;
                }
            }
            else {
                return 4;
            }
        }
    }
}
