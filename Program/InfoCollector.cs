namespace Program
{
    public class InfoCollector
    {
        private readonly double _handleTime;
        private readonly int _costs;
        public readonly int Intensity;
        public readonly int Number;

        public InfoCollector(int number, double handleTime, int costs, int intensity)
        {
            _handleTime = handleTime;
            _costs = costs;
            Intensity = intensity;
            Number = number;
        }

        public void OutputResults()
        {
            Console.WriteLine($"{Number}\t{Math.Abs(Math.Round(Intensity * _handleTime / (1.0 / _handleTime - Intensity), 2))}\t   {Intensity * _costs}");
        }
    }
}

