var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddBlazorise()
    .AddFluentUI2Providers()
    .AddFluentUIIcons();


// Obtener configuración
var configuration = builder.Configuration;
var rutaApi = configuration["RutaApi"];

if (string.IsNullOrEmpty(rutaApi))
{
    throw new InvalidOperationException("La configuración 'RutaApi' no está definida en appsettings.json");
}

// Validar que la URL sea válida
if (!Uri.TryCreate(rutaApi, UriKind.Absolute, out var apiUri))
{
    throw new InvalidOperationException($"La ruta de API '{rutaApi}' no es una URL válida");
}

// Registrar servicios de catálogos
builder.Services.AddClientesCatalogos(apiUri);


await builder.Build().RunAsync();
