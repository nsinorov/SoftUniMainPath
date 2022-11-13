using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var currTeamInfo = Console.ReadLine().Split("-");
                var creator = currTeamInfo[0];
                var teamName = currTeamInfo[1];

                if (teams.Any(currTeam => currTeam.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var membersInfo = Console.ReadLine();

            while (membersInfo != "end of assignment")
            {
                var memberInfo = membersInfo.Split(new string[] { "->" }, StringSplitOptions.None);

                var memberName = memberInfo[0];
                var teamToJoin = memberInfo[1];

                if (teams.Any(team => team.Members.Contains(memberName)) || teams.Any(creator => creator.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (!teams.Any(team => team.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currTeam = teams.Find(team => team.Name == teamToJoin);
                    currTeam.Members.Add(memberName);
                }

                membersInfo = Console.ReadLine();
            }

            var completedTeams = teams.Where(x => x.Members.Count > 0);

            var disbannedTeams = teams.Where(team => team.Members.Count == 0);

            foreach (var team in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            if (disbannedTeams != null)
            {
                foreach (var disbannedTeam in disbannedTeams.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{disbannedTeam.Name}");
                }
            }
        }
    }

    class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
