using System.ComponentModel.DataAnnotations.Schema;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.DTOs;

public class CustomerDto
{
    public string name { get; set; }
    public string email { get; set; }
    
    public int creditBalance { get; set; }

    public Customer customerParse(CustomerDto customerDto)
    {
        Customer customer = new Customer();
        customer.email = customerDto.email;
        customer.name = customerDto.name;
        customer.creditBalance = customerDto.creditBalance;
        return customer;
    }
}