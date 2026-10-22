using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;

namespace TmdbApi.Extensions;

/// <summary>
/// TMDB extension class for DI registration.
/// </summary>
public static class TmdbServiceCollectionExtension
{
    /// <param name="serviceCollection"><see cref="IServiceCollection"/></param>
    extension(IServiceCollection serviceCollection)
    {
        /// <summary>
        /// Add HTTP client.
        /// </summary>
        /// <returns><see cref="IServiceCollection"/></returns>
        public IServiceCollection AddTmdbClient()
        {
            serviceCollection.AddHttpClient<ITmdbClient, TmdbClient>(options =>
            {
                options.BaseAddress = new Uri("https://api.tmdb.ru");
                options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");
            });
            return serviceCollection;
        }

        /// <summary>
        /// Add HTTP client.
        /// </summary>
        /// <param name="configureClient">Client configuration.</param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public IServiceCollection AddTmdbClient(Action<HttpClient> configureClient)
        {
            serviceCollection.AddHttpClient<ITmdbClient, TmdbClient>(configureClient);
            return serviceCollection;
        } 
    }
}