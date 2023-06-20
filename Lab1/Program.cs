using Server;

Console.ForegroundColor = ConsoleColor.Green;

Console.ResetColor();
ServerSocket server = new ServerSocket("127.0.0.1", 8000);

server.BindAndListen(15);
server.AcceptAndReceive();