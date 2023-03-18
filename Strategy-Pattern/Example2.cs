interface IPayment
{
    bool Pay(PaymentOptions paymentOptions);
}
public class PaymentOptions
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string ExpirationDate { get; set; }
    public string Cvv { get; set; }
    public decimal Amount { get; set; }
}

class PaymentService
{
    private IPayment payment;

    public PaymentService(){}
    
    public PaymentService(IPayment payment)
    {
        this.payment = payment;
    }

    public void SetPayment(IPayment payment)
    {
        this.payment = payment;
    }

    public bool PayViaStrategy(PaymentOptions options)
    {
        return payment.Pay(options);
    }
}


public class GarantiBankPaymentService : IPayment
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Garanti Bankası ile ödeme yapıldı.");
        return true;
    }
}

public class YapiKrediBankPaymentService : IPayment
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Yapı Kredi Bankası ile ödeme yapıldı.");
        return true;
    }
}

public class IsBankasiBankPaymentService : IPayment
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("İş Bankası ile ödeme yapıldı.");
        return true;
    }
}



