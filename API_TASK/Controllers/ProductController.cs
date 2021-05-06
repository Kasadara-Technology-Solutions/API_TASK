using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_TASK.Controllers
{
    public class ProductController : Controller
    {
        public IEnumerable<Productline>GetProductlines()
        {
            using (API_TaskEntities entities = new API_TaskEntities())
            {
                return entities.Productlines.ToList();
            }
        }
        
        public Productline Get(int ID)
        {
            using (API_TaskEntities entities = new API_TaskEntities())
            {
                return entities.Productlines.FirstOrDefault(e => e.ID == ID);
            }
        }

        }
    }
