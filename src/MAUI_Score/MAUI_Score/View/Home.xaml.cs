using MAUI_Score.Interfaces;
using MAUI_Score.Models;
using MAUI_Score.Services;
using MAUI_Score.ViewModels;

namespace MAUI_Score
{
    public partial class Home : ContentPage
    {
        int count = 10;

        public Home(HomePageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
