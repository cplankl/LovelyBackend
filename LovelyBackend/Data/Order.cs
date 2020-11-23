using System;
using System.Collections.Generic;

namespace LovelyBackend.Data
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public int ReleaseDate { get; set; }
        public int TargetDate { get; set; }
        public List<Workstep> WorkstepList { get; set; } = new List<Workstep>();
    }
}