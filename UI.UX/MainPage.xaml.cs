using Microsoft.Maui;
using static System.Net.Mime.MediaTypeNames;

namespace UI.UX
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
             //< Entry
             //       Text = "{Binding Text}"
             //       Placeholder = "Логин"
             //   />

             //   < Entry
             //       Placeholder = "Пароль"
             //       IsPassword = "True"
             //       Text = "{Binding Password}"

             //   />
                //Text text = new Text
                //{
                //    text = "логин",
                //    HorizontalOptions = LayoutOptions.Center,
                //    VerticalOptions = LayoutOptions.Center
                //}

            Button button = new Button
            {
                Text = "Войти",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Authorization());
            };

            Content = button;
        }

        

        
    }
}