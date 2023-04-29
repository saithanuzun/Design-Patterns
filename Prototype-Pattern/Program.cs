/*
 * Prototype design pattern is used to create a duplicate object or clone of the current object to enhance performance.
 * This pattern is used when the creation of an object is costly or complex.
 */

class Program
{
    public static void Main(string[] args)
    {
        List<IBlock> grid = new List<IBlock>();
        grid.Add(BlockFactory.Create("Hello World"));
        grid.Add(BlockFactory.Create("3"));
        grid.Add(BlockFactory.Create("28/01/2001"));
        
        var block3 = (DateBlock)grid[2].Clone();
        block3.Format = "MM/dd/yyyy";
        grid.Add(block3);
        
        var block4 = (DateBlock)grid[3].Clone();
        block4.Date = DateTime.UtcNow;
        grid.Add(block4);
    }
}

interface IBlock
{
    string Render { get; }
    IBlock Clone();
}

class BlockFactory
{
    public static IBlock Create(string content)
    {
        if (DateTime.TryParse(content,out var date))
        {
            return new DateBlock() { Date = date, Format = "dd/MM/yyyy" };
        }
        else if (int.TryParse(content, out int number))
        {
            return new NumberBlock() { Number = number };
        }
        else
        {
            return new TextBlock() { Content = content };
        }
    }
}
class TextBlock : IBlock
{
    public string Content { get; set; }
    public string Render => Content;
    
    public IBlock Clone() => new TextBlock() { Content = Content };
}
class NumberBlock : IBlock
{
    public int Number { get; set; }
    public string Render => Number.ToString();
    public IBlock Clone() => new NumberBlock() { Number = Number };
}

class DateBlock : IBlock
{
    public DateTime Date { get; set; }
    public string Format { get; set; }
    public string Render => Date.ToString();
    public IBlock Clone() => new DateBlock() { Date = Date ,Format = Format};
}
