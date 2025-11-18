using Lwrp.LivewireClient.MockDevice;

var store = new PasswordStore();
var router = new CommandRouter(store);
var server = new MockLwrpServer(router);

Console.WriteLine("Starting LWRP Mock Device on TCP port 93...");
await server.StartAsync();
