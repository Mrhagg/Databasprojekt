using DataLagring.Services;


namespace DataLagring;

internal class ConsoleUi
{
    private readonly TeamService _teamService;

    public ConsoleUi(TeamService teamService)
    {
        _teamService = teamService;
    }

    public void CreateTeam_UI()
    {
        Console.Clear();
        Console.WriteLine("------- Skapa Lag -------");

        Console.Write("Team: ");
        var teamName = Console.ReadLine();

        Console.Write("Teamcolor: ");
        var teamColor = Console.ReadLine();

        Console.Write("Player: ");
        var playerName = Console.ReadLine();

        Console.Write("Position: ");
        var positionName = Console.ReadLine();

        Console.Write("Coach: ");
        var coachName = Console.ReadLine();

        Console.Write("Country: ");
        var countryName = Console.ReadLine();

        Console.Write("Stadium: ");
        var stadiumName = Console.ReadLine();

        var result = _teamService.CreateTeam(teamName, teamColor, playerName, positionName, coachName, countryName, stadiumName);
        if (result != null)
        {
            Console.Clear();
            Console.WriteLine("Team was Created");
            Console.ReadKey();
        }


    }

    public void GetTeams_UI()
    {
        Console.Clear();

        var teams = _teamService.GetTeams();
        foreach (var team in teams)
        {
            Console.WriteLine($"{team.TeamName}, {team.TeamColor}, {team.Player.PlayerName}, {team.Player.PositionName}, {team.Coach.CoachName}, {team.Country.CountryName}, {team.Stadium.StadiumName}");
        }
        Console.ReadKey();
    }

   public void TeamUpdate_UI()
    {
        Console.Clear();
        Console.Write("Enter Team Id: ");
        var id = int.Parse(Console.ReadLine()!);
        var team = _teamService.GetTeamById(id);
        if (team != null)
        {
            Console.WriteLine($"{team.TeamName}, {team.TeamColor}, {team.Player.PlayerName}, {team.Player.PositionName}, {team.Coach.CoachName}, {team.Country.CountryName}, {team.Stadium.StadiumName}");
            Console.WriteLine();

            Console.Write("New Team: ");
            team.TeamName = Console.ReadLine()!;

            var newTeam = _teamService.UpdateTeam(team);
            Console.WriteLine($"{team.TeamName}, {team.TeamColor}, {team.Player.PlayerName}, {team.Player.PositionName}, {team.Coach.CoachName}, {team.Country.CountryName}, {team.Stadium.StadiumName}");

        }
        else
        {
            Console.WriteLine("No team found. ");
        }

        Console.ReadKey();
    }

    public void DeleteTeam_UI()
    {
        Console.Clear();
        Console.Write("Enter Team Id: ");
        var id = int.Parse (Console.ReadLine()!);

        var team = _teamService.GetTeamById(id);
        if (team != null)
        {
            _teamService.DeleteTeam(team.Id);
            Console.WriteLine("Team was Deleted");
        }
        else
        {
            Console.WriteLine("No Team was found. ");
        }

        Console.ReadKey();
    }
}

