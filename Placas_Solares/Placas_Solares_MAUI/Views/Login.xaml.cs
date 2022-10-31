using _07_Pages_Maui.Models;
namespace Placas_Solares_MAUI;

public partial class Login : ContentPage
{


	public Login()
	{
		InitializeComponent();
	}

	private async void Submit(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PaginaPrincipal() { BindingContext=usuario()});
	}

	private clsLogin usuario() {



        clsLogin persona1 = new clsLogin();
        persona1.
        persona1.Apellido = eApellido.Text;

        return persona1;


        return usuario;
	}
}

