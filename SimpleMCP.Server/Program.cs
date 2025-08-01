using MCPSharp;

namespace SimpleMCP.Server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MCPServer.Register<CalculatorTool>();

            await MCPServer.StartAsync(
                serverName: "SimpleMCP Server", 
                version: "v0.00.001");
        }

        public class CalculatorTool
        {
            [McpTool(name: "addition", Description = "This tool adds two numbers")]
            public static int Addition(
                [McpParameter(required:true, description: "The first number")] int firstNumber,
                [McpParameter(required:true, description: "The second number")] int secondNumber) 
            {
                return firstNumber + secondNumber;
            }

            [McpTool(name: "subtraction", Description = "This tool subtracts two numbers")]
            public static int Subtraction(
                [McpParameter(required: true, description: "The first number")] int firstNumber,
                [McpParameter(required: true, description: "The second number")] int secondNumber)
            {
                return firstNumber - secondNumber;
            }
        }
    }
}
