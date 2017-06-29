using System;
using System.Collections.Generic;
using System.Linq;

class Arm
{
    public int Energy { get; set; }
    public int ReachDistance { get; set; }
    public int FingersCount { get; set; }
}

class Leg
{
    public int Energy { get; set; }
    public int Strength { get; set; }
    public int Speed { get; set; }
}

class Torso
{
    public int Energy { get; set; }
    public decimal CpuSize { get; set; }
    public string Material { get; set; }
}

class Head
{
    public int Energy { get; set; }
    public int IQ { get; set; }
    public string Material { get; set; }
}

class Robot
{
    public List<Head> Heads { get; set; }
    public List<Arm> Arms { get; set; }
    public List<Leg> Legs { get; set; }
    public List<Torso> Torsos { get; set; }
}

class Jarvis
{
    static void Main()
    {
        long maxEnergy = long.Parse(Console.ReadLine());

        Robot robot = new Robot();
        robot.Arms = new List<Arm>();
        robot.Legs = new List<Leg>();
        robot.Heads = new List<Head>();
        robot.Torsos = new List<Torso>();

        string input = Console.ReadLine();
        while (input != "Assemble!")
        {
            switch (input.Split(' ').First())
            {
                case "Arm":
                    Arm arm = ReadArm(input);
                    robot.Arms.Add(arm);
                    break;
                case "Leg":
                    Leg leg = ReadLeg(input);
                    robot.Legs.Add(leg);
                    break;
                case "Torso":
                    Torso torso = ReadTorso(input);
                    robot.Torsos.Add(torso);
                    break;
                case "Head":
                    Head head = ReadHead(input);
                    robot.Heads.Add(head);
                    break;

            }
            input = Console.ReadLine();
        }

        if (robot.Arms.Count >= 2 && robot.Heads.Count >= 1 &&
            robot.Legs.Count >= 2 && robot.Torsos.Count >= 1)
        {
            long consumedEnergy =
                robot.Arms.OrderBy(x => x.Energy).First().Energy +
                robot.Arms.OrderBy(x => x.Energy).Skip(1).Take(1).First().Energy +
                robot.Legs.OrderBy(x => x.Energy).First().Energy +
                robot.Legs.OrderBy(x => x.Energy).Skip(1).Take(1).First().Energy +
                robot.Heads.OrderBy(x => x.Energy).First().Energy +
                robot.Torsos.OrderBy(x => x.Energy).First().Energy;

            if (consumedEnergy <= maxEnergy)
            {
                Console.WriteLine("Jarvis:");
                foreach (var item in robot.Heads.OrderBy(x => x.Energy).Take(1))
                {
                    Console.WriteLine($"#Head:");
                    Console.WriteLine($"###Energy consumption: {item.Energy}");
                    Console.WriteLine($"###IQ: {item.IQ}");
                    Console.WriteLine($"###Skin material: {item.Material}");
                }
                foreach (var item in robot.Torsos.OrderBy(x => x.Energy).Take(1))
                {
                    Console.WriteLine($"#Torso:");
                    Console.WriteLine($"###Energy consumption: {item.Energy}");
                    Console.WriteLine($"###Processor size: {item.CpuSize:f1}");
                    Console.WriteLine($"###Corpus material: {item.Material}");
                }
                foreach (var item in robot.Arms.OrderBy(x => x.Energy).Take(2))
                {
                    Console.WriteLine($"#Arm:");
                    Console.WriteLine($"###Energy consumption: {item.Energy}");
                    Console.WriteLine($"###Reach: {item.ReachDistance}");
                    Console.WriteLine($"###Fingers: {item.FingersCount}");
                }
                foreach (var item in robot.Legs.OrderBy(x => x.Energy).Take(2))
                {
                    Console.WriteLine($"#Leg:");
                    Console.WriteLine($"###Energy consumption: {item.Energy}");
                    Console.WriteLine($"###Strength: {item.Strength}");
                    Console.WriteLine($"###Speed: {item.Speed}");
                }
            }
            else
            {
                Console.WriteLine("We need more power!");
            }
        }
        else
        {
            Console.WriteLine("We need more parts!");
        }
    }

    private static Arm ReadArm(string input)
    {
        string[] componentData = input.Split(' ');

        Arm arm = new Arm()
        {
            Energy = int.Parse(componentData[1]),
            ReachDistance = int.Parse(componentData[2]),
            FingersCount = int.Parse(componentData[3])
        };

        return arm;
    }

    private static Leg ReadLeg(string input)
    {
        string[] componentData = input.Split(' ');

        Leg leg = new Leg()
        {
            Energy = int.Parse(componentData[1]),
            Strength = int.Parse(componentData[2]),
            Speed = int.Parse(componentData[3])
        };

        return leg;
    }

    private static Torso ReadTorso(string input)
    {
        string[] componentData = input.Split(' ');

        Torso torso = new Torso()
        {
            Energy = int.Parse(componentData[1]),
            CpuSize = decimal.Parse(componentData[2]),
            Material = componentData[3]
        };

        return torso;
    }

    private static Head ReadHead(string input)
    {
        string[] componentData = input.Split(' ');

        Head head = new Head()
        {
            Energy = int.Parse(componentData[1]),
            IQ = int.Parse(componentData[2]),
            Material = componentData[3]
        };

        return head;
    }
}
