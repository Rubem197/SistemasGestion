using CRUD_Personas_MAUI.Views;

namespace CRUD_Personas_MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("EditarPersona", typeof(EditarPersona));
        Routing.RegisterRoute("InsertarPersona", typeof(InsertarPersona));
    }
}
