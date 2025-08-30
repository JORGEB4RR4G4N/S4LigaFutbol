namespace S4.LigaFutbol.FrontEnd.Componentes.Catalogos;

public partial class CatalogosComponent
{
    string selectedTab = "home";

    private Task OnSelectedTabChanged(string name)
    {
        selectedTab = name;

        return Task.CompletedTask;
    }
}
