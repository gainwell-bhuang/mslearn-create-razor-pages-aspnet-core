using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public interface IPizzaService
    {
        void AddPizza(Pizza pizza);
        void DeletePizza(int id);
        IList<Pizza> GetPizzas();
    }
}
