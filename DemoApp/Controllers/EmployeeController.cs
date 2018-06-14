using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using DemoDAO.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using DemoDAO;

namespace DemoApp.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public JsonResult<List<Employee>> GetEmployeesByLocation(string location)
        {
            Repository repo = new Repository();
            return Json(repo.GetEmployeesByLocation(location));       
        }
    }
}