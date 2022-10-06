namespace Task2_2
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string teamName = "";
            string type = "";
            string name = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("comands:{addTeam, addWorker, showGroupInfo, end}");
                Console.WriteLine("Input comand:");
                string comand = "" + Console.ReadLine();
                switch (comand)
                {
                    case "addTeam":
                        Console.WriteLine("Input team name:");
                        teams.Add(new Team("" + Console.ReadLine()));
                        break;

                    case "addWorker":
                        flag = true;
                        while (flag)
                        {
                            Console.WriteLine("Choose team:");
                            foreach (Team team in teams)
                            {
                                Console.Write(team.GetName()+" ");
                            }
                            Console.WriteLine();
                            teamName = "" + Console.ReadLine();
                            foreach (Team team in teams)
                            {
                                if (team.GetName() == teamName) { flag = false; break; }
                            }
                            if (flag) Console.WriteLine("No such team");
                        }
                        flag = true;
                        while (flag)
                        {
                            Console.WriteLine("Choose Manager/Developer:");
                            type = "" + Console.ReadLine();
                            if (type != "Manager" && type != "Developer") Console.WriteLine("No such type");
                            else flag = false;
                        }
                        flag = true;
                        Console.WriteLine("Input worker name:");
                        name = "" + Console.ReadLine();
                        switch (type)
                        {
                            case "Developer":
                                foreach (Team team in teams)
                                {
                                    if (team.GetName() == teamName) { team.AddWorker(new Developer(name)); break; }
                                }
                                break;

                            case "Manager":
                                foreach (Team team in teams)
                                {
                                    if (team.GetName() == teamName) { team.AddWorker(new Manager(name)); break; }
                                }
                                break;
                        }
                        break;

                    case "showGroupInfo":
                        foreach(Team team in teams)
                        {
                            team.PrintFullInfo();
                        }
                        break;

                    case "end":
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("No such comand");
                        break;
                }
            }
        }
    }
}