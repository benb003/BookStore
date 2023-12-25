namespace BookStore.Models;

public class ShoppingCartVM
{
    public IEnumerable<ShoppingCart> ListCart { get; set; }
    public Order Order { get; set; }    
    
}