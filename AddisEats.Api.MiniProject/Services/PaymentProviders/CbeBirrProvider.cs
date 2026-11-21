namespace AddisEats.Services.PaymentProviders;

public class CbeBirrProvider : IPaymentProvider
{
    public var Pay(decimal price)
    {
        return $"Payder {price} in CBE Birr";
    }
}