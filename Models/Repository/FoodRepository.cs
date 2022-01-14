using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

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

    public class FoodRepository : IRepository
    {
        public string sql = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private string Table = "FoodTable";

        public void Create(FoodTable model)
        {
            using (var conn = new SqlConnection(sql))
            {
                var sql =$"INSERT INTO {Table}(FoodName,FoodPrice,dep,Name)VALUES(@FoodName,@FoodPrice,@dep,@Name)";
                conn.Execute(sql,model);

            }
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<FoodTable> getall()
        {
            using (var conn = new SqlConnection(sql))
            {
                var sql = $"select * From {Table}";
                return conn.Query<FoodTable>(sql).ToList();

            }
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