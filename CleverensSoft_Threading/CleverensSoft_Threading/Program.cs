const int CLIENTS_COUNT = 20;

for (int i = 0; i < CLIENTS_COUNT; i++)
{
    Thread clientThread = new Thread(new Client().Run);
    clientThread.Name = "Client_" + i;
    clientThread.Start();
}

Console.ReadLine();