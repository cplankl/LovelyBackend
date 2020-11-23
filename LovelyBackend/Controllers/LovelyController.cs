using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LovelyBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LovelyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "from API with love";
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet("{taskId}")]
        public ActionResult<Data.Task> GetTask(string taskId) => Ok(Repository.GetTaskData(taskId));

        [HttpGet("casestudies")]
        public ActionResult<Data.CaseStudy[]> GetAllCaseStudies() => Ok(Repository.GetCaseStudies());


        [HttpPost("keyfigures")]
        public ActionResult<Data.Task> PostTask([FromBody] Data.Task task)
        {
            // Calculation //
            task.KeyFigure = new Data.KeyFigure
            {
                AvgProcessingTime = 99,
                TotalProcessingTime = 88,
                VMax = 77,
                VMid = 66,
                VSum = 55
            };

            return task;
        }

    }
}