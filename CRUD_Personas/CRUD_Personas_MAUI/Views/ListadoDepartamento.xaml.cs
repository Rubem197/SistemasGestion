using CRUD_Personas_MAUI.ViewModels;

namespace CRUD_Personas_MAUI.Views;

public partial class ListadoDepartamento : ContentPage
{
	public ListadoDepartamento()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        ((clsListadoDepartamentosVM)(this.BindingContext)).actualizarLista();
        base.OnAppearing();

    }
}