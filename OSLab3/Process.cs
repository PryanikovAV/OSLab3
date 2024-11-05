namespace OSLab3
{
    public class Process
    {
        public int Id { get; set; }
        public int ArrivalTime { get; set; }  // Время появления процесса
        public int BurstTime { get; set; }  // Время выполнения процесса
        public int Memory { get; set; }  // Требуемая память
        public int RemainingTime { get; set; }  // Изначально == времени исполнения

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
