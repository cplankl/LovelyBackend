
using System.Collections.Generic;

namespace LovelyBackend.Controllers
{
    public static class Repository
    {
        public static List<Data.CaseStudy> GetCaseStudies()
        {
            var caseStudy = new Data.CaseStudy
            {
                Title = "Test",
                Description = "Test Description",
                PhysicalAvailable = false,
                TaskIdList = new List<string> { "1", "2" },
            };

            return new List<Data.CaseStudy> { caseStudy };
        }


        public static Data.Task GetTaskData(string taskId)
        {
            var workStep1 = new Data.Workstep
            {
                Station = 1,
                PhysicallId = 123,
                Duration = 3,
                Priority = false,
                StartSolution = 0
            };

            var workStep2 = new Data.Workstep
            {
                Station = 2,
                PhysicallId = 456,
                Duration = 4,
                Priority = false,
                StartSolution = 5
            };

            var order1 = new Data.Order
            {
                ReleaseDate = 0,
                TargetDate = 5,
                WorkstepList = new List<Data.Workstep> { workStep1, workStep2 }
            };

            var order2 = new Data.Order
            {
                ReleaseDate = 6,
                TargetDate = 10,
                WorkstepList = new List<Data.Workstep> { workStep1, workStep2 }
            };

            var keyFigure = new Data.KeyFigure
            {
                VMax = 10,
                VMid = 10,
                VSum = 10,
                AvgProcessingTime = 10,
                TotalProcessingTime = 10
            };

            var task = new Data.Task
            {
                TaskId = taskId,
                Description = "Task" + taskId,
                ProductionType = Data.ProductionType.LINE_PRODUCTION,
                NumberOfOrders = 2,
                NumberOfStations = 2,
                DifficultyLevel = Data.DifficultyLevel.SIMPLE,
                KeyFigure = keyFigure,
                SolutionType = Data.SolutionType.OPTIMAL,
                OrderList = new List<Data.Order> { order1, order2 },
                PhysicalAvailable = false
            };
            return task;
        }
    }

    //public class Controller
    //{

    //    private Data d;

    //    @GetMapping("/casestudies")
    //public List<CaseStudy> getAllCaseStudies()
    //    {

    //        // CaseStudy
    //        List<String> taskIdList = new ArrayList<>();
    //        taskIdList.add("1");
    //        taskIdList.add("2");

    //        CaseStudy cs = new CaseStudy("Test", "Test description", false, taskIdList);

    //        List<CaseStudy> caseStudyList = new ArrayList<>();
    //        caseStudyList.add(cs);

    //        // Data
    //        //        Data d = new Data(caseStudyList, taskList);

    //        return caseStudyList;
    //    }


    //    @GetMapping("/task/{taskId}")
    //public Task getAllTasks(@PathVariable String taskId)
    //    {

    //        // Workstep
    //        Workstep w1 = new Workstep(1, 123, 3, false, 0);
    //        Workstep w2 = new Workstep(2, 456, 4, false, 5);
    //        List<Workstep> workstepList = new ArrayList<>();
    //        workstepList.add(w1);
    //        workstepList.add(w2);


    //        // Order
    //        Order o1 = new Order(0, 5, workstepList);
    //        Order o2 = new Order(6, 10, workstepList);
    //        List<Order> orderList = new ArrayList<>();
    //        orderList.add(o1);
    //        orderList.add(o2);


    //        // Task
    //        KeyFigure kf = new KeyFigure(10, 10, 10, 10, 10);
    //        Task t = new Task(
    //                taskId,
    //                "Task" + taskId,
    //                ProductionType.LINE_PRODUCTION,
    //                2,
    //                2,
    //                DifficultyLevel.SIMPLE,
    //                kf,
    //                SolutionType.OPTIMAL,
    //                orderList,
    //                false);


    //        //        t.calculateKeyFigures();
    //        //        List<Task> taskList = new ArrayList<>();
    //        //        taskList.add(t);

    //        return t;
    //    }

    //    //    @PostMapping("/keyfigures")
    //    //    public Task postRequest(@RequestBody Task t){
    //    ////        System.out.println(c.getTaskList());
    //    //        return t;
    //    //    }

    //}
}