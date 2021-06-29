
namespace fruit_shop
{
    class StoreInformation
    {
        private ILogger _logger = null;
        public StoreInformation(ILogger logger)
        {
            _logger = logger;
        }
        public void Store(string content)
        {
            _logger.Log(content);
        }
        public void Store()
        {
            _logger.Log("\n");
        }
    }
}