using DAL;

namespace _08_Layout_ListViews;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        ListViewClsPersona.ItemsSource = ListaClsPersona.listadoPersona();
    }


}

