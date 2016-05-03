using API.Models;
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

        static List <Product> listaProdutos = new List <Product>();
 
        
        //public ProductController - metodo construtor
        public ProductController() {

            // List<Product> listaProdutos = new List<Product>();
            //variavel produto(x) recebe os parametros da classe Product
            var produto1 = new Product { Id = 1, Name = "Yo- yo", Category = "Brinquedos", Price = 3.50m };
            var produto2 = new Product { Id = 2, Name = "Placa mãe", Category = "Hardware", Price = 400m };
            var produto3 = new Product { Id = 3, Name = "Chocolate", Category = "doces", Price = 4.40m };

            listaProdutos.Add(produto1);
            listaProdutos.Add(produto2);
            listaProdutos.Add(produto3);
           
        }

        // GET: api/Product        
        public IHttpActionResult Get() { 
        
            var produto1 = new Product{Id = 1, Name = "Yo- yo", Category = "Brinquedos", Price = 3.50m };
            var produto2 = new Product{Id = 2, Name = "Placa mãe", Category = "Hardware", Price = 400m };
            var produto3 = new Product{Id = 3, Name = "Chocolate", Category = "doces", Price = 4.40m };

            listaProdutos.Add(produto1);
            listaProdutos.Add(produto2);
            listaProdutos.Add(produto3);

            return Ok(listaProdutos);

        }


        // GET: api/Product/5
        public IHttpActionResult Get(int id)
        {
                       
            //Busca o Id de um produto, e retorna o resultado (se o id foi encontrado)
            var produto = listaProdutos.Find(x => x.Id == id);
            return Ok(produto);

        }

        // POST: api/Product
        public IHttpActionResult Post([FromBody] Product produto)
        {
            listaProdutos.Add(produto);
            return Ok();
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
