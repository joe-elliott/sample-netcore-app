namespace sample_netcore_app.Providers
{
    public class FibonacciProvider : IFibonacciProvider
    {
        public FibonacciProvider()
        {
        }

        public int calculateFibonacciValue(int position)
        {
            return calculateFibonacciValueRecursive(0, 1, 1, position);
        }

        private int calculateFibonacciValueRecursive(int a, int b, int counter, int len)  
        {  
            if (counter <= len)  
            {  
                return calculateFibonacciValueRecursive(b, a + b, counter+1, len);  
            }  

            return b;
        }  
    }
}