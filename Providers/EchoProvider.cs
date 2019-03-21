namespace sample_netcore_app.Providers
{
    public class EchoProvider : IEchoProvider
    {
        public EchoProvider()
        {
        }

        public string calculateEchoValue(string echo)
        {
            return echo;
        }
    }
}