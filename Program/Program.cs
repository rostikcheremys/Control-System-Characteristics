namespace Program
{
    abstract class Program
    {
        public static void Main()
        {
            var collectors = InitializeCollectors();
            var handlers = InitializeHandlers(collectors);
            var commands = InitializeCommands(collectors);

            OutputResults(collectors, handlers, commands);
        }

        private static List<InfoCollector> InitializeCollectors()
        {
            var collectors = new List<InfoCollector>
            {
                new (1, 0.5, 20, 10),
                new (2, 0.8, 25, 7),
                new (3, 0.6, 18, 8),
                new (4, 1.2, 22, 6),
                new (5, 0.7, 30, 9),
                new (6, 1.5, 26, 5),
                new (7, 0.1, 24, 6),
                new (8, 0.4, 32, 10)
            };

            return collectors;
        }

        private static List<InfoHandler> InitializeHandlers(List<InfoCollector> collectors)
        {
            var handlers = new List<InfoHandler>
            {
                new (9, new Dictionary<int, double> { { 1, 0.4 }, { 3, 0.8 } }, new Dictionary<int, int> { { 1, 28 }, { 3, 18 } }, 1.1, collectors[0], collectors[2]),
                new (10, new Dictionary<int, double> { { 2, 0.6 }, { 5, 0.4 } }, new Dictionary<int, int> { { 2, 18 }, { 5, 28 } }, 1.4, collectors[1], collectors[4]),
                new (11, new Dictionary<int, double> { { 4, 0.5 }, { 7, 0.5 } }, new Dictionary<int, int> { { 4, 24 }, { 7, 30 } }, 1.2, collectors[3], collectors[6]),
                new (12, new Dictionary<int, double> { { 6, 0.7 }, { 8, 0.9 } }, new Dictionary<int, int> { { 6, 25 }, { 8, 22 } }, 1.3, collectors[5], collectors[7])
            };

            return handlers;
        }

        private static List<InfoCommand> InitializeCommands(List<InfoCollector> collectors)
        {
            var commands = new List<InfoCommand>
            {
                new (13, new Dictionary<int, double> { { 1, 0.8 }, { 2, 0.5 }, { 3, 0.6 }, { 4, 0.4 } }, new Dictionary<int, int> { { 1, 25 }, { 2, 30 }, { 3, 26 }, { 4, 32 } }, 3.8, collectors[0], collectors[1], collectors[2], collectors[3]),
                new (14, new Dictionary<int, double> { { 5, 0.5 }, { 6, 0.7 }, { 7, 0.6 }, { 8, 0.8 } }, new Dictionary<int, int> {  { 5, 28 },  { 6, 22 }, { 7, 24 }, { 8, 20} }, 4, collectors[4], collectors[5], collectors[6], collectors[7])
            };

            return commands;
        }

        private static void OutputResults(List<InfoCollector> collectors, List<InfoHandler> handlers, List<InfoCommand> commands)
        {
            Console.WriteLine("№\tTime\t  Costs");
            
            foreach (var collector in collectors)
            {
                collector.OutputResults();
            }

            foreach (var handler in handlers)
            {
                handler.OutputResults();
            }

            foreach (var command in commands)
            {
                command.OutputResults();
            }
        }
    } 
}

