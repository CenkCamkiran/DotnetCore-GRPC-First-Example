//Create a channel for your gRPC Service
using Grpc.Core;
using Grpc.Net.Client;
using Protos;
using System.Threading;

var grpcHost = Environment.GetEnvironmentVariable("GRPC_HOST");
if (string.IsNullOrEmpty(grpcHost))
    throw new Exception("GRPC_HOST env Variable not set!");

var channel = GrpcChannel.ForAddress(grpcHost);
//Create SalesService Client to open a connection
var client = new SalesService.SalesServiceClient(channel);
//Invoke the method 
try
{
    using var call = client.GetSalesData(new Request { Filters = "" }, deadline: DateTime.UtcNow.AddSeconds(5));
    int Count = 0;
    //Get response stream
    await foreach (var each in call.ResponseStream.ReadAllAsync())
    {
        Console.WriteLine(String.Format("New Order Receieved from {0}-{1},Order ID = {2}, Unit Price ={3}, Ship Date={4}", each.Country, each.Region, each.OrderID, each.UnitPrice, each.ShipDate));
        Count++;
    }
    Console.WriteLine("Stream ended: Total Records: " + Count.ToString());
    Console.Read();
}
catch (RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
{
    Console.WriteLine(ex.Message.ToString());
}
catch (Exception)
{

	throw;
}