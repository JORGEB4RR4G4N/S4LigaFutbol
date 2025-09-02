namespace S4.LigaFutbol.Repositorio.Cliente.Helper;

public static class HttpJsonConvenienceExtensions
{
    public static async Task<TResponse> PostJsonAsync<TRequest, TResponse>(this HttpClient http,
                                                                             string url,
                                                                             TRequest body,
                                                                             JsonSerializerOptions jsonOptions = null,
                                                                             CancellationToken ct = default)
    {
        using var resp = await http.PostAsJsonAsync(url, body, jsonOptions, ct);
        resp.EnsureSuccessStatusCode();

        if (resp.StatusCode == HttpStatusCode.NoContent)
            return default;

        if (resp.StatusCode == HttpStatusCode.Created &&
            resp.Content.Headers.ContentLength is 0 &&
            resp.Headers.Location is Uri loc)
        {
            return await http.GetFromJsonAsync<TResponse>(loc, jsonOptions, ct);
        }

        return await resp.Content.ReadFromJsonAsync<TResponse>(jsonOptions, ct);
    }
    public static async Task<TResponse> PutJsonAsync<TRequest, TResponse>(this HttpClient http,
                                                                           string url,
                                                                           TRequest body,
                                                                           JsonSerializerOptions jsonOptions = null,
                                                                           CancellationToken ct = default)
    {
        using var resp = await http.PutAsJsonAsync(url, body, jsonOptions, ct);
        resp.EnsureSuccessStatusCode();

        if (resp.StatusCode == HttpStatusCode.NoContent)
            return default;

        return await resp.Content.ReadFromJsonAsync<TResponse>(jsonOptions, ct);
    }
    public static async Task<TResponse> DeleteAndReadJsonAsync<TResponse>(this HttpClient http,
                                                                        string url,
                                                                        JsonSerializerOptions jsonOptions = null,
                                                                        CancellationToken ct = default)
    {
        using var resp = await http.DeleteAsync(url, ct);
        resp.EnsureSuccessStatusCode();

        if (resp.StatusCode == HttpStatusCode.NoContent)
            return default;

        return await resp.Content.ReadFromJsonAsync<TResponse>(jsonOptions, ct);
    }


    public static Task<T> PostAndReadJsonAsync<T>(this HttpClient http, string url, T body, JsonSerializerOptions jsonOptions = null, CancellationToken ct = default) => http.PostJsonAsync<T, T>(url, body, jsonOptions, ct);
    public static Task<T> PutAndReadJsonAsync<T>(this HttpClient http, string url, T body, JsonSerializerOptions jsonOptions = null, CancellationToken ct = default) => http.PutJsonAsync<T, T>(url, body, jsonOptions, ct);


}
