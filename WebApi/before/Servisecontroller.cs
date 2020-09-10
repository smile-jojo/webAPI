using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi
{
    public class ServiseController
    {


        [HttpPost]
        public string GetChargingDate()
        {
            return "123123";
        }
        [HttpPost]
        public bool SaveData()
        {
            return true;
        
        }

    }
}
