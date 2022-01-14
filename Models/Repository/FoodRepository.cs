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

        void Edit(int id,FoodTable model);

        List<FoodTable> getall();

        FoodTable getId(int id);

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

        public void Edit(int id,FoodTable model)
        {
            using (var conn = new SqlConnection(sql))
            {
                var sql = $"Update {Table} set FoodName=@FoodName,FoodPrice=@FoodPrice,dep=@dep,Name=@Name where id=@id";
                conn.Execute(sql, model);
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

        public FoodTable getId(int id)
        {
            using (var conn = new SqlConnection(sql))
            {
                var sql = $"select * From {Table} where id =@id";
                return conn.QuerySingleOrDefault<FoodTable>(sql,new{id});
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(sql))
            {
                var sql = $"Delete From {Table} where id=@id";
                conn.Execute(sql,new{ id});
            }
        }
    }
}