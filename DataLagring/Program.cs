using DataLagring;
using DataLagring.Contexts;
using DataLagring.Repositories;
using DataLagring.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\DatalagringInlamning\DataLagring\DataLagring\Data\local_database.mdf;Integrated Security=True;Connect Timeout=30"));


    services.AddScoped<CoachRepository>();
    services.AddScoped<CountryRepository>();
    services.AddScoped<PlayerRepository>();
    services.AddScoped<StadiumRepository>();
    services.AddScoped<TeamRepository>();

    services.AddScoped<CoachService>();
    services.AddScoped<CountryService>();
    services.AddScoped<PlayerService>();
    services.AddScoped<StadiumService>();
    services.AddScoped<TeamService>();



    services.AddSingleton<ConsoleUi>();

}).Build();

var consoleUI = builder.Services.GetRequiredService<ConsoleUi>();


consoleUI.CreateTeam_UI();
consoleUI.GetTeams_UI();
consoleUI.TeamUpdate_UI();
consoleUI.DeleteTeam_UI();