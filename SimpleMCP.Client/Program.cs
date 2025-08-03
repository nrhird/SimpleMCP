using MCPSharp;
using MCPSharp.Model;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SimpleMCP.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MCPClient(
                name: "SimpleMCP Client",
                version: "v0.00.001",
                server: "..\\SimpleMCP.Server\\bin\\Debug\\net9.0\\SimpleMCP.Server.exe"
            );

            var resultA = await client.CallToolAsync(
                name: "addition",
                parameters: new Dictionary<string, object> 
                {
                    { "firstNumber", 5 },
                    { "secondNumber", 10 }
                }
            );
            Console.WriteLine(resultA.Content[0].Text);

            var resultS = await client.CallToolAsync(
                name: "subtraction",
                parameters: new Dictionary<string, object>
                {
                    { "firstNumber", 15 },
                    { "secondNumber", 10 }
                }
            );
            Console.WriteLine(resultS.Content[0].Text);

        }
    }
}
