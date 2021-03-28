using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam r1 = new ResearchTeam("Ooooo", "Org1", 111, TimeFrame.Long);
            r1.AddMembers(new Person());
            r1.AddPapers(new Paper(), new Paper(), new Paper());
            ResearchTeam r2 = new ResearchTeam("Aaaaa", "Org2", 333, TimeFrame.TwoYears);
            r2.AddMembers(new Person(), new Person());
            r2.AddPapers(new Paper());
            ResearchTeam r3 = new ResearchTeam("Zzzzz", "Org3", 222, TimeFrame.Year);
            r3.AddMembers(new Person(), new Person(), new Person());
            r3.AddPapers(new Paper(), new Paper(), new Paper());
            ResearchTeamCollection rr = new ResearchTeamCollection();
            rr.AddDefaults();
            rr.AddResearchTeams(r1, r2, r3);
            Console.WriteLine("             ОБЪЕКТ ResearchTeamCollection");
            Console.WriteLine();
            Console.WriteLine(rr.ToString());
            Console.WriteLine("             СОРТИРОВКА ПО НОМЕРУ РЕГИСТРАЦИИ");
            rr.SortRegNum();
            Console.WriteLine(rr.ToShortString());
            Console.WriteLine();
            Console.WriteLine("             СОРТИРОВКА ПО НАЗВАНИЮ ТЕМЫ ИССЛЕДОВАНИЙ");
            rr.SortTopic();
            Console.WriteLine(rr.ToShortString());
            Console.WriteLine();
            Console.WriteLine("             СОРТИРОВКА ПО ЧИСЛУ ПУБЛИКАЦИЙ");
            rr.SortNumPapers();
            Console.WriteLine(rr.ToShortString());
            Console.WriteLine();
            Console.WriteLine("Минимальный регистрационный номер:  " + rr.MinRegNum);
            Console.WriteLine("Проекты с продолжительностью TwoYears:");
            foreach (ResearchTeam r in rr.TwoYears)
                Console.WriteLine("   *  " + r.ToShortString());
            Console.WriteLine();
            Console.WriteLine("          Группа с 1 публикацией:");
            foreach (ResearchTeam r in rr.NGroup(1))
                Console.WriteLine(r.ToShortString());
            Console.WriteLine();
            Console.WriteLine("          Группа с 3 публикациями:");
            foreach (ResearchTeam r in rr.NGroup(3))
                Console.WriteLine(r.ToShortString());

            TestCollections test = new TestCollections(1000000);
            test.SearchTime(1000000);
        }
    }
}
