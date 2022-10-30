using System;
using System.Collections.Generic;
using System.Linq;

namespace P05TeamWorkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            InitaliazeTeams(teamsCount, teams);

            JoinTeam(teams);

            PrintValidTeams(teams);

            PrintEmptyTeams(teams);
        }

        private static void JoinTeam(List<Team> teams)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] commArgs = input
                    .Split("->");

                string user = commArgs[0];
                string teamName = commArgs[1];

                if (!TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsPlayerAlreadyInTeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams
                        .First(t => t.Name == teamName);
                    teamToJoin.AddMember(user);
                }
            }
        }

        private static void InitaliazeTeams(int teamsCount, List<Team> teams)
        {
            for (int i = 0; i < teamsCount; i++)
            {
                string[] commArgs = Console.ReadLine()
                    .Split("-");
                string creator = commArgs[0];
                string teamName = commArgs[1];
                Team currTeam = new Team(teamName, creator);
                if (IsTeamAlreadyCreated(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(currTeam);
                    Console.WriteLine($"Team {currTeam.Name} has been created by {currTeam.Creator}!");
                }
            }
        }

        private static void PrintValidTeams(List<Team> teams)
        {
            List<Team> validTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(t => t))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        private static void PrintEmptyTeams(List<Team> teams)
        {
            List<Team> emptyTeams = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (Team disbandName in emptyTeams)
            {
                Console.WriteLine($"{disbandName.Name}");
            }
        }

        static bool IsTeamAlreadyCreated(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.Name == teamName);
        }

        static bool AlreadyCreatedATeam(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator);
        }

        static bool TeamExists(List<Team> teams, string teamName)
        {
            return teams.Any(n => n.Name == teamName);
        }

        static bool IsPlayerAlreadyInTeam(List<Team> teams, string user)
        {
            return teams.Any(t => t.Members.Contains(user)) ||
                   teams.Any(t => t.Creator == user);
        }
    }

    public class Team
    {
        private readonly List<string> members;
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;

            this.members = new List<string>();
        }

        public string Name { get; private set; }

        public string Creator { get; private set; }

        public List<string> Members 
            => this.members;

        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }


    }
}
