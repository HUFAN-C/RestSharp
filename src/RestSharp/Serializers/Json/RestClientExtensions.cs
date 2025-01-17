using System.Text.Json;

namespace RestSharp.Serializers.Json; 

[PublicAPI]
public static class RestClientExtensions {
    /// <summary>
    /// Use System.Text.Json serializer with default settings
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public static RestClient UseSystemTextJson(this RestClient client) => client.UseSerializer(() => new SystemTextJsonSerializer());

    /// <summary>
    /// Use System.Text.Json serializer with custom settings
    /// </summary>
    /// <param name="client"></param>
    /// <param name="options">System.Text.Json serializer options</param>
    /// <returns></returns>
    public static RestClient UseSystemTextJson(this RestClient client, JsonSerializerOptions options)
        => client.UseSerializer(() => new SystemTextJsonSerializer(options));
}