namespace WiredInterviewTask.Services
{
    /// <summary>
    /// Service Class for Calculations
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        private int result = 0;

        public int Add(int numberToAdd)
        {
            this.result = this.result + numberToAdd;
            return result;
        }

        public int Result()
        {
            return this.result;
        }
    }
}
