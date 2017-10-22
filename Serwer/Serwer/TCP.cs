using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

public class TCP
{
    private static string HostIpAdress;
    private static int Port;

    public TCP(string _HostIpAdress, int _Port)
    {
        HostIpAdress = _HostIpAdress;
        Port = _Port;
    }
    public void Listen()
    {
        try
        {
            //Przypisanie adresu ip serwera i portu 
            IPAddress ipAd = IPAddress.Parse(HostIpAdress);

            //Utworzenie obiektu serwera z ip i portem
            TcpListener server = new TcpListener(ipAd, Port);
            
            //Start serwera
            server.Start();

            //Bufory danych
            Byte[] bytes = new Byte[256];
            String data = null;

            while (true)
            {
                //Otwarcie nasluchiwania klientow
                TcpClient client = server.AcceptTcpClient();

                //Wyzerowanie bufora
                data = null;

                //
                NetworkStream stream = client.GetStream();

                int i;

                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", data);

                    // Process the data sent by the client.
                    data = data.ToUpper();
                    Serwer.Program.IncomingMsg(data);
                    
                }

                //Zamkniecie polaczenia
                client.Close();
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }
}