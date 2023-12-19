namespace Program
{
    public class InfoHandler
    {
        private readonly double _handleTimeRes;
        private readonly double _costsRes;
        private readonly double _aggregation;
        private readonly int _number;
        
        private readonly Dictionary<int, double> _handleTime;
        private readonly Dictionary<int, int> _costs;
    
        public InfoHandler(int number, Dictionary<int, double> handleTime, Dictionary<int, int> costs, double aggregation, InfoCollector hub1, InfoCollector hub2)
        {
            _handleTime = handleTime;
            _costs = costs;
            _aggregation = aggregation;
            _number = number;
        
            double cef = 2 * (1 - hub1.Intensity * _handleTime[hub1.Number] / _aggregation +
                              hub2.Intensity * _handleTime[hub2.Number] / _aggregation);
            _handleTimeRes = hub1.Intensity * Math.Pow(_handleTime[hub1.Number], 2) / cef + _number +
                             hub2.Intensity * Math.Pow(_handleTime[hub2.Number], 2) / cef;
            _costsRes = hub1.Intensity * _costs[hub1.Number] / _aggregation +
                        hub2.Intensity * _costs[hub2.Number] / _aggregation;
        }

        public void OutputResults()
        {
            Console.WriteLine($"{_number}\t{Math.Round(_handleTimeRes, 2)}\t   {Math.Round(_costsRes, 2)}");
        }
    }
}

