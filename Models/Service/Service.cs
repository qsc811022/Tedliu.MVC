using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Tedliu.MVC.Models.DomainModel;
using Tedliu.MVC.Models.Repository;

namespace Tedliu.MVC.Models.Service
{
    public class Service
    {
        FoodRepository repo =new FoodRepository();
        public void Create(FoodTable Model)
        {
            repo.Create(Model);
        }
    }
}