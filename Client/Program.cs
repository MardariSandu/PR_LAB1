using Client;

ClientSocket client = new ClientSocket();
Console.CancelKeyPress += new ConsoleCancelEventHandler(ConsoleCancelHandler);

client.Connect("127.0.0.1", 8000);

client.SendLoop();


void ConsoleCancelHandler(object sender, ConsoleCancelEventArgs e)
{
    e.Cancel = true;

    client.CloseClientSocket();

    Environment.Exit(0);
}