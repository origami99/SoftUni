using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    public Team(string name, string creator, List<string> members)
    {
        Name = name;
        Creator = creator;
        Members = members;
    }

    public string Name { get; set; }
    public List<string> Members { get; set; }
    public string Creator { get; set; }
}

public class Program
{
    public static void Main()
    {
        int teamsCount = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        for (int i = 0; i < teamsCount; i++)
        {
            string[] teamData = Console.ReadLine().Split('-');

            string teamCreator = teamData[0];
            string teamName = teamData[1];

            if (teams.Any(x => x.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (teams.Any(x => x.Creator == teamCreator))
            {
                Console.WriteLine($"{teamCreator} cannot create another team!");
            }
            else
            {
                Team team = new Team(teamName, teamCreator, new List<string>());
                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                teams.Add(team);
            }
        }

        string line = Console.ReadLine();

        while (!line.Equals("end of assignment"))
        {
            string[] userData = line
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string userName = userData[0];
            string teamName = userData[1];

            if (teams.Any(x => x.Name == teamName))
            {
                Team currentTeam = teams
                    .Where(x => x.Name == teamName)
                    .First();

                if (teams.Any(x => x.Creator == userName) || 
                    teams.Select(x => x.Members).Any(x => x.Contains(userName)))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    currentTeam.Members.Add(userName);
                }
            }
            else
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }

            line = Console.ReadLine();
        }

        var teamsWithMembers = teams
            .OrderByDescending(x => x.Members.Count())
            .ThenBy(x => x.Name)
            .Where(x => x.Members.Count > 0)
            .ToList();

        foreach (var team in teamsWithMembers)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");

            foreach (var member in team.Members.OrderBy(x => x))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        List<Team> disbandTeams = teams
          .OrderBy(x => x.Name)
          .Where(x => x.Members.Count() == 0)
          .ToList();

        Console.WriteLine("Teams to disband:");
        foreach (var team in disbandTeams)
        {
            Console.WriteLine(team.Name);
        }
    }
}
