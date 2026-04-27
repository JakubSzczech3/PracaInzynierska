namespace InterfejsPrototyp.Other
{
    public class MockPaymentService : IPaymentService
    {
        public async Task<bool> ProcessPaymentAsync(int orderId, decimal amount)
        {
            await Task.Delay(2000);

            if (amount <= 0) return false;

            return true;
        }
    }
}
