using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using CRUD_Personas_MAUI.ViewModels;
using System.Collections.ObjectModel;

namespace CRUD_Personas_MAUI.Views;

public partial class ListadoPersona : ContentPage
{
	public ListadoPersona()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ObservableCollection<clsPersonas> listadoCompletoPersonas = new ObservableCollection<clsPersonas>(clsListadoPersonaBL.ListadoCompletoPersonas());
        ((clsListadoPersonasVM)(this.BindingContext)).ListadoCompletoPersonas = listadoCompletoPersonas;
    }
}