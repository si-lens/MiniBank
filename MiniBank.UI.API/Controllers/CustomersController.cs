using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniBank.Core.ApplicationService;
using MiniBank.Core.Entities;

namespace MiniBank.UI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly ICustomerService _customerService;

        private void validateCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName))
                throw new ArgumentException("Customer first name is required");
            if (string.IsNullOrEmpty(customer.LastName))
                throw new ArgumentException("Customer last name is required");
        }

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var customers = _customerService.GetAllCustomers();
            if (customers == null)
                return StatusCode(404, "Customer table is empty");
            return Ok(customers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _customerService.GetCustomerWithID(id);
            if (customer == null)
                return StatusCode(404, $"Customer with Id {id} does not exist");
            return Ok(customer);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {
            try
            {
                validateCustomer(customer);
                return _customerService.CreateCustomer(customer);
            }catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, [FromBody] Customer customer)
        {
            if(id != customer.Id)
            {
                return BadRequest($"Invalid customer provided. \nReceived Id: {id}\nReceived Customer Id: {customer.Id}");
            }

            try
            {
                validateCustomer(customer);
                return _customerService.Update(customer);
            }catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Customer> Delete(int id)
        {
            var customer = _customerService.GetCustomerWithID(id);
            if (customer == null)
                return StatusCode(404, $"Customer with id {id} does not exist");
            else
               return _customerService.Delete(customer);

            
        }
    }
}