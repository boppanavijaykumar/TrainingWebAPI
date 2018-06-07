using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Trainee.Controllers
{
    public class Trainee
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
   
        public int TraineeAge { get; set; }
    }
    public class TraineeController : ApiController
    {
        /*Trainee[] trainees=new Trainee[] {
                new Trainee{TraineeId=1,TraineeName="Renuka",TraineeAge=21},
                new Trainee{TraineeId=2,TraineeName="Shishika",TraineeAge=20},
                new Trainee{TraineeId=3,TraineeName="Surya",TraineeAge=25}
            };*/
        List<Trainee> trainees = new List<Trainee>{
                new Trainee{TraineeId=1,TraineeName="Vijay",TraineeAge=21},
                new Trainee{TraineeId=2,TraineeName="Ajay",TraineeAge=20},
                new Trainee{TraineeId=3,TraineeName="Srujay",TraineeAge=25}
            };
        public IEnumerable<Trainee> GetAllTrainees()
        {
            return trainees;
        }
        //we should create two methods with same functionality
        //if i want to use pass different parameters
        /*public List<string> Get()
        {
            return (from trainee in trainees select trainee.TraineeName).ToList();
        }*/
        public List<Trainee> Post(Trainee trainee)
        {
            trainees.Add(trainee);
            return trainees;
        }
        public List<Trainee> Delete(int id)
        {
            var DeletedRecord = trainees.Where(p => p.TraineeId == id).FirstOrDefault();
            trainees.Remove(DeletedRecord);
            return trainees;
        }
        public List<Trainee> Put(Trainee trainee)
        {
            var index = trainees.FindIndex(p => p.TraineeId == trainee.TraineeId);
            //var UpdatedRecord=trainees.Where()
            trainees.RemoveAt(index);
            trainees.Add(trainee);
            // trainees = trainees.Select(x => { if (x.TraineeId == trainee.TraineeId) { x = trainee; } return x; }).ToList();
            return trainees;
        }
    }

}


