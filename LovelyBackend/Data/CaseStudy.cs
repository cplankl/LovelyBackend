using System;
using System.Collections.Generic;
// ReSharper disable InconsistentNaming

namespace LovelyBackend.Data
{
    public class CaseStudy
    {
        public Guid CaseStudyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool PhysicalAvailable { get; set; }
        public List<string> TaskIdList { get; set; } = new List<string>();
    }
}