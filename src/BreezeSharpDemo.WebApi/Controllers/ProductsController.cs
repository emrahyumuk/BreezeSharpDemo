using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using BreezeSharpDemo.Models;
using Newtonsoft.Json.Linq;

namespace BreezeSharpDemo.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        readonly EFContextProvider<DemoDbEntities> _contextProvider =
           new EFContextProvider<DemoDbEntities>();

        [HttpGet]
        public string Metadata() {
            return _contextProvider.Metadata();
        }
        [HttpGet]
        public IQueryable<Product> Products() {
            return _contextProvider.Context.Products;
        }
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle) {
            return _contextProvider.SaveChanges(saveBundle);
        }
    }
}
