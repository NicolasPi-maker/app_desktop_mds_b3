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
    }
}
