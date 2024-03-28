using MAUI_Score.ViewModels;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls;
using System;

namespace MAUI_Score
{
    public partial class MatchView : ContentPage
    {

        public MatchView(MatchViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
