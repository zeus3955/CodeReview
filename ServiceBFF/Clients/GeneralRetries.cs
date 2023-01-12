using System.Net;
using Polly;
using Polly.Retry;

namespace ServiceBFF.Clients
{
    public static class GeneralRetries
    {
        public static IAsyncPolicy<HttpResponseMessage> GetRetryablePolicyFromPollyThatShouldBeUsedOnAllAndIMeanAllHttpCalls()
        {
            return Policy.Handle<HttpRequestException>()
                .Or<TaskCanceledException>()
                .OrResult<HttpResponseMessage>(response =>
                    response.StatusCode == HttpStatusCode.RequestTimeout ||
                    response.StatusCode == HttpStatusCode.BadGateway ||
                    response.StatusCode == HttpStatusCode.GatewayTimeout ||
                    response.StatusCode == HttpStatusCode.ServiceUnavailable
                ).WaitAndRetryForeverAsync<HttpResponseMessage>((i) => TimeSpan.FromSeconds(3));
        }
    }
}
