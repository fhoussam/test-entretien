using System.Text.RegularExpressions;

public static class Exo_13
{
    public static void Main() 
    {
        var result = 0;
        var input = "21 + 1 - 7 * 5 + 18 / 3 - 4 * 30"; //-910
        result = Process(input);
        Console.WriteLine($"result : {result}");
    }

    public static int Process(string input) 
    {
        var result = 0;
        input = input.Replace(" ", "");
        input = NeutralizeMultiOperation('/', input);
        input = NeutralizeMultiOperation('*', input);
        result = input.Replace("-", "+-").Split("+").Select(x => int.Parse(x)).Sum();
        return result;
    }

    public static string NeutralizeMultiOperation(char operation, string input) 
    {
        while (input.Contains(operation))
        {
            var effectiveOperation = operation == '*' ? $"\\{operation}" : operation.ToString();
            var match = new Regex($"(\\d+){effectiveOperation}(\\d+)").Match(input);

            if (!match.Success) 
            {
                return input;
            }

            var divParts = match.Value.Split(operation);

            int operationResult = 0;
            if (operation == '/')
            {
                operationResult = int.Parse(divParts[0]) / int.Parse(divParts[1]); ;
            }
            else if (operation == '*')
            {
                operationResult = int.Parse(divParts[0]) * int.Parse(divParts[1]); ;
            }
            else
            {
                throw new NotSupportedException();
            }

            input = input.Replace(match.Value, operationResult.ToString());
        }
        return input;   
    }
}
