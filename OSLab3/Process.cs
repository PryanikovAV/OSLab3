namespace OSLab3
{
    public class Process
    {
        public enum ProcessStatus
        {
            WaitingToStart,
            WaitingForMemory,
            Running,
            Completed
        }

        public int Id { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int Memory { get; set; }
        public int RemainingTime { get; set; }
        public ProcessStatus Status { get; set; } = ProcessStatus.WaitingToStart;  // Изначально ОЖИДАНИЕ

        public Process(int id, int arrivalTime, int burstTime, int memory)
        {
            Id = id;
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
            Memory = memory;
            RemainingTime = burstTime;
        }
    }
}
