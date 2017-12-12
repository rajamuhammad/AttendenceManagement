using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiniAttandanceSystem.Controllers
{
    public class BatchController : ApiController
    {
        Database1Entities db = new Database1Entities();

        [Route("api/GetAllBatches")]
        public List<Batch> GetAllBatches()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Batches.ToList();
        }

        
        [Route("api/GetStudntsByBatch/{batch}")]
        public List<Student> GetStudntsByBatch(string batch)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Students.Where(s => s.Batch.BatchCode == batch).ToList();
        }
    }
}
