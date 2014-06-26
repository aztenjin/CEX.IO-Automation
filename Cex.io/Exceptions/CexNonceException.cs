using System.Net.Http;

namespace Nextmethod.Cex.Exceptions
{
    public class CexNonceException : CexApiException
    {

        public CexNonceException(HttpResponseMessage response, string message) : base(response, message) {}

    }
}
