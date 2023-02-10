using SampleRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SampleRestApi.Controllers
{
    public class AsyncCustomerController : ApiController
    {
        [ResponseType(typeof(CustomerTable))]
        public async Task<IHttpActionResult> GetCustomer(int id)
        {
            var context = new ProductEntites();
            var customer = context.CustomerTables.FirstOrDefault((c) => c.CstId == id);
            if (customer == null)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"No Customer by Id {id} found"),
                    ReasonPhrase = "Customer Not found"
                };
                throw new HttpResponseException(response);
            }
            return await Task.Run<IHttpActionResult>(() => Ok(customer));
        }
        
        [ResponseType(typeof(List<CustomerTable>))]
        public async Task<IHttpActionResult> GetAllCustomers()
        {
            var context = new ProductEntites();
            var customers = context.CustomerTables.ToList();
            return await Task.Run<IHttpActionResult>(()=> Ok(customers));
        }
    }
}
