using S4.LigaFutbol.FrontEnd.ServiciosHelper.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddBlazorise()
    .AddFluentUI2Providers()
    .AddFluentUIIcons();




var config = builder.Configuration;
// Asegura que las bases terminan en '/'
string EnsureSlash(string s) => string.IsNullOrWhiteSpace(s) ? s : (s.EndsWith("/") ? s : s + "/");
// Obtener configuración
var rutaApi = EnsureSlash(config["RutaApi"] ?? throw new InvalidOperationException("Falta 'RutaApi'"));
var baseApi = new Uri(rutaApi);

// Construye URIs hijas con Uri, no con concatenación de strings
Uri apiUriCatalogos = new Uri(baseApi, EnsureSlash(config["Catalogos"]));
Uri apiUriEstadisticas = new Uri(baseApi, EnsureSlash(config["Estadisticas"]));
Uri apiUriOperacion = new Uri(baseApi, EnsureSlash(config["Operacion"]));

// Validaciones
if (!apiUriCatalogos.IsAbsoluteUri) throw new InvalidOperationException("'Catalogos' no generó una URL absoluta");
if (!apiUriEstadisticas.IsAbsoluteUri) throw new InvalidOperationException("'Estadisticas' no generó una URL absoluta");
if (!apiUriOperacion.IsAbsoluteUri) throw new InvalidOperationException("'Operacion' no generó una URL absoluta");

// Registrar clientes
//Catalogos
builder.Services.AddClientesCatalogos(apiUriCatalogos);
builder.Services.AddClientesEstadistica(apiUriEstadisticas);
builder.Services.AddClientesOperacion(apiUriOperacion);

// Servicio componente Gloabal Toast
builder.Services.AddScoped<IAppToasts, AppToasts>();

await builder.Build().RunAsync();
