using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class ShoppingCart : BaseDomainModel{
    public Guid? ShoppinCartMasterId { get; set; }
    public virtual ICollection<ShoppingCartItem>? ShoppinCartItems { get; set; }
}