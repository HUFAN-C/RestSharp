namespace RestSharp.Serializers.NewtonsoftJson;

[PublicAPI]
public static class RestClientExtensions {
    /// <summary>
    /// Use Newtonsoft.Json serializer with default settings
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public static RestClient UseNewtonsoftJson(this RestClient client) => client.UseSerializer(() => new JsonNetSerializer());

    /// <summary>
    /// Use Newtonsoft.Json serializer with custom settings
    /// </summary>
    /// <param name="client"></param>
    /// <param name="settings">Newtonsoft.Json serializer settings</param>
    /// <returns></returns>
    public static RestClient UseNewtonsoftJson(this RestClient client, JsonSerializerSettings settings)
        => client.UseSerializer(() => new JsonNetSerializer(settings));
}