namespace DSA.practice;

public class FCFS
{
    public class Process
    {
        internal int Number { get; set; }
        public int BurstTime { get; set; }
        public int ArrivalTime { get; set; }
        public int StartTime { get; set; } = 0;

        public Process(int number, int burstTime, int arrivalTime)
        {
            Number = number;
            BurstTime = burstTime;
            ArrivalTime = arrivalTime;
        }
    }

    //private record InternalProcess(int Number, int BurstTime, int ArrivalTime, int StartTime) : Process(Number, BurstTime, ArrivalTime);

    public float AvgWaitingTime(List<Process> processes)
    {
        processes.Sort((a, b) => a.ArrivalTime - b.ArrivalTime);

        int startTime = processes[0].ArrivalTime;
        int totalWaitTime = 0;
        foreach (Process process in processes)
        {
            process.StartTime = startTime;
            totalWaitTime += startTime - process.ArrivalTime;
            //Console.WriteLine($"{startTime}, {process.ArrivalTime}, {process.BurstTime}, {process.Number}");
            startTime += process.BurstTime;
        }

        return totalWaitTime / processes.Count;
    }
    
    public static void Run()
    {
        List<Process> processes = new()
        {
            new Process(1,6,2),
            new Process(2,5,5),
            new Process(3,8,1),
            new Process(4,3,0),
            new Process(5,4,4),
        };

        var fcfs = new FCFS();
        Console.WriteLine(fcfs.AvgWaitingTime(processes));
    }
}