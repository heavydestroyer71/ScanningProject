using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OrganizerSvc.Models;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace OrganizerSvc.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpPost]
        public void AddApp(SendContent dataString)
        {
            string path = ConfigurationManager.AppSettings["copyPath"].ToString();
            path = Path.Combine(path, dataString.challan_no, dataString.userName, dataString.box_no, dataString.batch_no);
            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
                System.IO.Directory.CreateDirectory(path);

            using (Image image = Image.FromStream(new MemoryStream(dataString.image)))
            {
                image.Save(Path.Combine(path, dataString.fileName), ImageFormat.Jpeg);  // Or Png
            }
            //return "Success";
        }

        //duplicate check at server
        //[HttpPost]
        //public string AddApp(SendContent dataString)
        //{
        //    string path = ConfigurationManager.AppSettings["copyPath"].ToString();
        //    path = Path.Combine(path, dataString.challan_no, dataString.userName, dataString.box_no, dataString.batch_no);
        //    bool exists = System.IO.Directory.Exists(path);

        //    if (!exists)
        //        System.IO.Directory.CreateDirectory(path);

        //    using (Image image = Image.FromStream(new MemoryStream(dataString.image)))
        //    {
        //        bool file = File.Exists(Path.Combine(path, dataString.fileName));
        //        if (file)
        //        {
        //            return "Exist!";
        //        }
        //        else
        //        {
        //            image.Save(Path.Combine(path, dataString.fileName), ImageFormat.Jpeg);  // Or Png
        //            return "Success";
        //        }
        //    }
        //    //return "Success";
        //}

        // GET api/values
        public string Get(string userName)
        {
            return userName;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}