using MAUI_Score.ViewModels;
using Microsoft.Maui.Controls;

namespace MAUI_Score.View;

public partial class PlayerTeamView : ContentPage
{
	public PlayerTeamView(PlayerTeamViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}