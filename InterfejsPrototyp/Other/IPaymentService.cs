namespace InterfejsPrototyp.Other
{
    public interface IPaymentService
    {
        Task<bool> ProcessPaymentAsync(int orderId, decimal amount);
    }
}
