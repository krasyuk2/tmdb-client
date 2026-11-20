using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using TmdbApi.Options;

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
        /// <param name="configure">Client configuration.</param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public IServiceCollection AddTmdbClient(Action<TmdbClientOptions> configure)
        {
            serviceCollection.AddOptions<TmdbClientOptions>()
                .Configure(configure)
                .Validate(o => !string.IsNullOrWhiteSpace(o.AccessToken), "Tmdb: AccessToken not found")
                .ValidateOnStart();
            
            serviceCollection.AddHttpClient<ITmdbClient, TmdbClient>((sp, http) =>
            {
                var o = sp.GetRequiredService<IOptions<TmdbClientOptions>>().Value;
                http.BaseAddress = new Uri(o.BaseUrl);
                http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", o.AccessToken);
            });
            return serviceCollection;
        } 
    }
}