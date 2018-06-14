using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using DemoDAO.Models;

namespace DemoDAO
{
    public class Repository
    {
        MongoClient client;
        IMongoDatabase mongoDB;
        public Repository()
        {
            client = new MongoClient(@"mongodb+srv://Kevin_Muppattayil:openpass@democluster-hw2bw.gcp.mongodb.net/test?retryWrites=true");
            mongoDB = client.GetDatabase("DemoDatabase");
        }

        public List<Employee> GetEmployeesByLocation(string location)
        {
            IMongoCollection<Employee> employees = mongoDB.GetCollection<Employee>("Employees");
            return employees.Find("{location: {'$eq': '" + location + "' }}").ToList<Employee>();
        }

    }
}