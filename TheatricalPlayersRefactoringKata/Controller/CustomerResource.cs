
using Microsoft.AspNetCore.Mvc;
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Service;

namespace TheatricalPlayersRefactoringKata.Controller;

[ApiController]
[Route("/api/customer")]
public class CustomerResource
{
    private readonly CustomerService _customerService = new CustomerService();
    
    [HttpGet("/getByIdCustomer/{id}")]
    public Customer? GetById(int id)
    {
        return _customerService.GetById(id);
    }
    
    [HttpGet("/getAllCustomer")]
    public List<Customer> GetAll()
    {
        return _customerService.GetAll();
    } 
    
    [HttpPost("/createCustomer")]
    public Customer Post(CustomerDto customerDto)
    {
        return _customerService.Save(customerDto);
    }
    
    [HttpPut("/updatecCustomer/{id}")]
    public  ActionResult<Customer> Update(int id, CustomerDto customerDto)
    {
        return _customerService.Update(id, customerDto);
    }

    [HttpDelete("/deletceCustomer/{id}")]
    public void Delete(int id)
    {
        _customerService.Delete(id);
    }
}