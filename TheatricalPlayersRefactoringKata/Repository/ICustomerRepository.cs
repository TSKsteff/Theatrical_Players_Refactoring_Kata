using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Repository;

public interface ICustomerRepository
{
    public Customer? GetById(int id);
    public List<Customer> GetAll(); 
    public Customer Save(CustomerDto customerDto);
    public Customer Update(int id, CustomerDto customerDto);
    public void Delete(int id); 
    
}