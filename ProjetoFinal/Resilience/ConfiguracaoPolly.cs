using Polly;
using Polly.Extensions.Http;

namespace ApiDarioProjetoFinal.Resilience
{
    public static class ConfiguracaoPolly
    {
        public static IAsyncPolicy<HttpResponseMessage> CriarPoliticaRetry()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(
                    3,
                    tentativa => TimeSpan.FromSeconds(tentativa)
                );
        }
    }
}