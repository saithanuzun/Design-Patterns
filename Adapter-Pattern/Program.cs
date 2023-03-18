class TransferTransaction
{
    public string FromIBAN { get; set; }
    public string ToIBAN { get; set; }
    public decimal Amount { get; set; }
}
interface IBankApi
{
    bool ExecuteTransaction(TransferTransaction transaction);
}
class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var json = $$""""
                      {
                        ""FromIBAN"": ""{{transaction.FromIBAN}}"",
                        ""ToIBAN"":   ""{{transaction.ToIBAN}}"",
                        ""Amount"":   ""{{transaction.Amount:C2}}""
                      }
                     """";
        Console.WriteLine($"{GetType().Name} worked with;");
        Console.WriteLine(json);
        return true;
    }
}

class XmlBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"""
                    <TransferTransaction>
                        <FromIBAN>{transaction.FromIBAN}</FromIBAN>
                        <ToIBAN>{transaction.ToIBAN}</ToIBAN>
                        <Amount>{transaction.Amount:C2}</Amount>
                    </TransferTransaction>
                  """;

        // Call bank api with XML
        Console.WriteLine($"{GetType().Name} worked with;");
        Console.WriteLine(xml);
        return true;
    }
}

class XmlBankApiAdapter : IBankApi
{
    private readonly XmlBankApi xmlBankApi;

    public XmlBankApiAdapter()
    {
        xmlBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return xmlBankApi.ExecuteTransaction(transaction);
    }
}

class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi jsonBankApi;

    public JsonBankApiAdapter()
    {
        jsonBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return jsonBankApi.ExecuteTransaction(transaction);
    }
}

class Program
{
    static void Main(String[] Args)
    {
        var trans = new TransferTransaction() { Amount = 100, FromIBAN = "1096784781087", ToIBAN = "109763409122" };
        
        // you can change the Adapter
        var adapter = new JsonBankApiAdapter();
        var result = adapter.ExecuteTransaction(trans);

        Console.WriteLine("Result: {0}", result);
    }
}