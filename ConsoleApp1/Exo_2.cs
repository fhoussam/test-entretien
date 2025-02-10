public interface IDescription
{
    string GetDescription();
}

public class MyDescription : IDescription
{
    public string GetDescription() { return "my description"; }
}

public class MetaDescription<T> where T : IDescription
{
    public string GetMetaDescription(T t)
    {
        return t.GetDescription();
    }
}

public static class Solution
{
    public static void Main() 
    {
        var myDesc = new MyDescription();
        var myMetaDesc = new MetaDescription<MyDescription>();
        Console.WriteLine(myMetaDesc.GetMetaDescription(myDesc));
    }
}
