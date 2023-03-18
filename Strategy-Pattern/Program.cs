class Program
{
    static void Main(string[] args)
    {
        //Example 1--------------------------------
        
        var character = new Character(new AgressiveCombatStrategy());
        character.ApplyAttactStrategy();
        character.SetCombatStrategy(new DefensiveCombatStrategy());
        character.ApplyAttactStrategy();

        //Example2 --------------------------------
        
        PaymentOptions  paymentOptions = new()
        {
            CardNumber = "10954389229",
            CardHolderName = "Sait Han Uzun",
            ExpirationDate = "12/25",
            Cvv = "123",
            Amount = 1000
        };
        //garanti bank
        var paymentService = new PaymentService(new GarantiBankPaymentService());
        paymentService.PayViaStrategy(paymentOptions);
        //Is Bank
        paymentService.SetPayment(new IsBankasiBankPaymentService());
        paymentService.PayViaStrategy(paymentOptions);
        //YapiKredi Bank
        paymentService.SetPayment(new YapiKrediBankPaymentService());
        paymentService.PayViaStrategy(paymentOptions);
    }
}