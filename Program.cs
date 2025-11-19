public class OrderItem
{
    public string ProductId { get; }
    public int Quantity { get; private set; }

    public OrderItem(string productId, int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.", nameof(quantity));

        ProductId = productId;
        Quantity = quantity;
    }

    public void Increase(int delta)
    {
        if (delta <= 0)
            throw new ArgumentException("Delta must be greater than zero.", nameof(delta));

        Quantity += delta;
    }

    public void Decrease(int delta)
    {
        if (delta <= 0)
            throw new ArgumentException("Delta must be greater than zero.", nameof(delta));

        if (Quantity - delta <= 0)
            throw new InvalidOperationException("Decrease would result in quantity less than or equal to zero.");

        Quantity -= delta;
    }
}
