using MAUI_Score.Interfaces;
using MAUI_Score.Models;
using MAUI_Score.Services;
using MAUI_Score.ViewModels;
using Microsoft.Maui.Controls;

namespace MAUI_Score
{
    public partial class Home : ContentPage
    {


        public Home(HomePageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        void OnScoreTapped(object sender, EventArgs e)
        {
            DetailsSection.IsVisible = !DetailsSection.IsVisible;
        }

    }
}
