using System.Collections.Generic;

namespace LovelyBackend.Data
{
    public class Task
    {
        public string TaskId { get; set; }
        public string Description { get; set; }
        public ProductionType ProductionType { get; set; }
        public int NumberOfOrders { get; set; }
        public int NumberOfStations { get; set; }
        public List<string> DescOfStationList { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public KeyFigure KeyFigure { get; set; }
        public SolutionType SolutionType { get; set; }
        public List<Order> OrderList { get; set; }
        public bool PhysicalAvailable { get; set; }
    }
}