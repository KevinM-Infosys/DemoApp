using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using DemoApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DemoApp.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public JsonResult<List<Employee>> GetEmployeesByLocation(string location)
        {
            MongoClient client = new MongoClient(@"mongodb+srv://Kevin_Muppattayil:openpass@democluster-hw2bw.gcp.mongodb.net/test?retryWrites=true");
            IMongoDatabase mongoDB = client.GetDatabase("DemoDatabase");
            IMongoCollection<Employee> employees = mongoDB.GetCollection<Employee>("Employees");

            return Json(employees.Find("{location: {'$eq': '" + location + "' }}").ToList<Employee>());       
        }
    }
}