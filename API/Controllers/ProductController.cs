using Domain2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> listaProdutos = new List<Product>();


        // GET: api/Product

        public IHttpActionResult Get()
        {
            var produto1 = new Product();
            produto1.ID = 1;
            produto1.Name = "Placa de Rede";
            produto1.Category = "Hardware";
            produto1.Price = 120m;

            var produto2 = new Product { ID = 2, Name = "Placa mãe", Category = "Hardware", Price = 480m };
            var produto3 = new Product { ID = 3, Name = "Antivirus", Category = "Software", Price = 180m };

            listaProdutos.Add(produto1);
            listaProdutos.Add(produto2);
            listaProdutos.Add(produto3);

            return Ok(listaProdutos);
        }        

        // GET: api/Product/5
        public IHttpActionResult Get(int id)
        {
            var produto1 = new Product();
            produto1.ID = 1;
            produto1.Name = "Placa de Rede";
            produto1.Category = "Hardware";
            produto1.Price = 120m;

            var produto2 = new Product { ID = 2, Name = "Placa mãe", Category = "Hardware", Price = 480m };
            var produto3 = new Product { ID = 3, Name = "Antivirus", Category = "Software", Price = 180m };

            listaProdutos.Add(produto1);
            listaProdutos.Add(produto2);
            listaProdutos.Add(produto3);

            var produto = listaProdutos.Find(x => x.ID == id);
            return Ok(produto);
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
