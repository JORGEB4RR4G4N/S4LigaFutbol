var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddBlazorise()
    .AddFluentUI2Providers()
    .AddFluentUIIcons();



// Asegura que las bases terminan en '/'
var cfg = builder.Configuration;
string EnsureSlash(string s) => string.IsNullOrWhiteSpace(s) ? s : (s.EndsWith("/") ? s : s + "/");
// Obtener configuración
var rutaApi = EnsureSlash(cfg["RutaApi"] ?? throw new InvalidOperationException("Falta 'RutaApi'"));
var baseApi = new Uri(rutaApi);

// Construye URIs hijas con Uri, no con concatenación de strings
Uri apiUriCatalogos = new Uri(baseApi, EnsureSlash(cfg["Catalogos"]));
Uri apiUriEstadisticas = new Uri(baseApi, EnsureSlash(cfg["Estadisticas"]));
Uri apiUriOperacion = new Uri(baseApi, EnsureSlash(cfg["Operacion"]));

// Validaciones
if (!apiUriCatalogos.IsAbsoluteUri) throw new InvalidOperationException("'Catalogos' no generó una URL absoluta");
if (!apiUriEstadisticas.IsAbsoluteUri) throw new InvalidOperationException("'Estadisticas' no generó una URL absoluta");
if (!apiUriOperacion.IsAbsoluteUri) throw new InvalidOperationException("'Operacion' no generó una URL absoluta");

// Registrar clientes
builder.Services.AddClientesCatalogos(apiUriCatalogos);


await builder.Build().RunAsync();
