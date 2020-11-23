using System;

namespace LovelyBackend.Data
{
    public class Workstep
    {
        public Guid WorkstepId { get; set; } = Guid.NewGuid();
        public int PhysicallId { get; set; }
        public int Station { get; set; }
        public int Duration { get; set; }
        public bool Priority { get; set; }
        public int StartSolution { get; set; }
    }
}