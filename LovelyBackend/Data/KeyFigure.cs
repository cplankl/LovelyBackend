using System;

namespace LovelyBackend.Data
{
    public class KeyFigure
    {
        public Guid KeyFigureId { get; set; } = Guid.NewGuid();
        public int VMax { get; set; }
        public float VMid { get; set; }
        public int VSum { get; set; }
        public int TotalProcessingTime { get; set; }
        public float AvgProcessingTime { get; set; }
    }
}