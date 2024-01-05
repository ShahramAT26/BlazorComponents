using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Models
{
    public class CustomerTypesPizzaSelection
    {
        public CustomerTypesPizzaSelection()
        {
            SelectedPizzas = new List<Pizza>
            {   
                new Pizza(1, "Pepperoni", "Hot"),
                new Pizza(2, "Margarita", "Cheesy")
            };

            CustomerTypes = new List<CustomerTypes>
            {
                BlazorTest.Models.CustomerTypes.Legal,
                BlazorTest.Models.CustomerTypes.NotCustomerAtAll
            };
        }

        [MinLength(1, ErrorMessage = "Atleast One Type Of Pizza Must Be Selected")]
        public IEnumerable<Pizza> SelectedPizzas { get; set; }

        [MinLength(1, ErrorMessage = "Select CustomerTypes")]
        public IEnumerable<CustomerTypes> CustomerTypes { get; set; }

        [MinLength(1, ErrorMessage = "Select Titles")]
        public IEnumerable<string> SelectedTitle { get; set; }
    }
}
