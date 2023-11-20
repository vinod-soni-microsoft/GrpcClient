#region snippet2
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

#region snippet
// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://grpcgreeter.azurewebsites.net");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Vinod Soni calling... " });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
#endregion
#endregion
