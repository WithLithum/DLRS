using DLRS;

[assembly: log4net.Config.XmlConfigurator(Watch = false)]

Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "serve");
var server = await new Server().Configure();
await server.Start();