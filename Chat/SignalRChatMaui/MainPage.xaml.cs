using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRChatMaui
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;

        public MainPage()
        {
            InitializeComponent();

            _connection = new HubConnectionBuilder()
                .WithUrl("https://signalrchatss.azurewebsites.net/ChatHub")
                .Build();

            _connection.On<string, string>("ReceiveMessage", (user ,message) =>
            {
                chatMessages.Text += $"{Environment.NewLine}{user + ": "}{message}";
            });

            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                await _connection.StartAsync());
            });
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await _connection.InvokeCoreAsync("SendMessage", args: new[] {"Ruben", myChatMessage.Text }); ;

            myChatMessage.Text = String.Empty;
        }
    }
}