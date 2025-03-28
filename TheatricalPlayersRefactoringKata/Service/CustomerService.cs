using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Info;
using TheatricalPlayersRefactoringKata.Repository;

namespace TheatricalPlayersRefactoringKata.Service;

public class CustomerService : ICustomerRepository
{
    private readonly DbConfig _config = new DbConfig();
    
    public Customer? GetById(int id)
    {
        return _config.Customers.Find(id);
    }

    public List<Customer> GetAll()
    {
        return _config.Customers.ToList();
    }

    public Customer Save(CustomerDto customerDto)
    {
        Customer customer = customerDto.customerParse(customerDto);
        _config.Customers.Add(customer);
        _config.SaveChanges();
        return _config.Customers.Find(customer.id) ?? throw new KeyNotFoundException();
    }

    public Customer Update(int id, CustomerDto customerDto)
    {
        if (id.Equals(null))
        {
            throw new ArgumentException("Cliente não encontrado.");
        }
        Customer customer = customerDto.customerParse(customerDto); 
        _config.Customers.Update(customer);
        _config.SaveChanges();
        return GetById(customer.id) ?? throw new KeyNotFoundException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

}