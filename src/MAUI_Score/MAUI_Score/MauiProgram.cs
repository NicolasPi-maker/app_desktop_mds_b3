using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using MAUI_Score.Models;
using MAUI_Score.Interfaces;
using MAUI_Score.ViewModels;
using MAUI_Score.Services.ModelServices;
using MAUI_Score.Services.DataServices;
using MAUI_Score.View;
using Microsoft.Maui.Controls.Hosting;

namespace MAUI_Score
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string matchDataFilePath = "Datas/Match.json";
            builder.Services.AddSingleton<DataManagerInterface<Models.Match>>(provider =>
            {
                return new DataManager<Models.Match>(matchDataFilePath);
            });
            builder.Services.AddSingleton<MatchService>();

            string gameDataFilePath = "C:\\Users\\nicol\\source\\repos\\Projet\\src\\MAUI_Score\\MAUI_Score\\Datas\\Game.json";
            builder.Services.AddSingleton<DataManagerInterface<Game>>(provider =>
            {
                return new DataManager<Game>(gameDataFilePath);
            });
            builder.Services.AddSingleton<GameService>();

            string playerDataFilePath = "Datas/Player.json";
            builder.Services.AddSingleton<DataManagerInterface<Models.Player>>(provider =>
            {
                return new DataManager<Models.Player>(playerDataFilePath);
            });
            builder.Services.AddSingleton<PlayerService>();

            string teamDataFilePath = "Datas/Team.json";
            builder.Services.AddSingleton<DataManagerInterface<Team>>(provider =>
            {
                return new DataManager<Team>(teamDataFilePath);
            });
            builder.Services.AddSingleton<TeamService>();
            builder.Services.AddSingleton<DataInitializer>();

            builder.Services.AddSingleton<Home>();
            builder.Services.AddSingleton<HomePageViewModel>();

            builder.Services.AddSingleton<PlayerTeamView>();
            builder.Services.AddSingleton<PlayerTeamViewModel>();

            builder.Services.AddSingleton<MatchView>();
            builder.Services.AddSingleton<MatchViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
