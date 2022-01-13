using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

using Tedliu.MVC.Models.DomainModel;

namespace Tedliu.MVC.Models.Repository
{
    interface IRepository
    {
        void Create(FoodTable model);

        void Edit(int id);

        List<FoodTable> getall();

        List<FoodTable> getId(int id);

        void Update(int id,FoodTable model);

    }

    public class Repository : IRepository
    {
        public string sql = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public void Create(FoodTable model)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<FoodTable> getall()
        {
            throw new NotImplementedException();
        }

        public List<FoodTable> getId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, FoodTable model)
        {
            throw new NotImplementedException();
        }
    }
}