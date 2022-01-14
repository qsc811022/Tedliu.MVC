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

        List<FoodTable>Edit(int id);

        List<FoodTable> getall();

        List<FoodTable> getId(int id);

        void Delete(int id);

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

        public List<FoodTable> Edit(int id)
        {
            using (var conn = new SqlConnection(sql))
            {
                var sql = $"Update set {Table} FoodName=@FoodName,FoodPrice=@FoodPrice,dep=@dep,Name=@Name where id=@id";
                return conn.Query<FoodTable>(sql,new{id}).ToList();

            }
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
            using (var conn = new SqlConnection(sql))
            {
                var sql = $"select * From {Table} where id =@id";
                return conn.Query<FoodTable>(sql).ToList();

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}