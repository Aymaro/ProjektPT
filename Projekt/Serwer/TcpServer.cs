using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Klient
{
    class TcpServer
    {
        private int HostPort = 13000;
        MySqlEngineSerwer msql = new MySqlEngineSerwer();
        //konstruktory
        public TcpServer()
        {
            
        }
        public TcpServer(int _HostPort)
        {
            HostPort = _HostPort;
        }
        private string DateNow()
        {
            string Data = null;
            return Data += DateTime.Now.Year +
                            "-" + DateTime.Now.Month +
                            "-" + DateTime.Now.Day +
                            " " + DateTime.Now.Hour +
                            ":" + DateTime.Now.Minute +
                            ":" + DateTime.Now.Second;
        }
        


        public void Listen()
        {
            //Stworzenie nasluchiwacza
            TcpListener server = null;
            

            try
            {
                
                
                //Listener dostaje dane o ip i porcie
                server = new TcpListener(IPAddress.Any, HostPort);

                //start serwera nasluchiwania
                server.Start();

                Byte[] bytes = new Byte[256];
                String data = null;
                string UID = null;
                string EPOCH = null;
                string RDR = null;
                List<string> ListaUID = new List<string>();
                ListaUID = msql.SelectUID();
                
                

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    NetworkStream stream = client.GetStream();

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Raw data: {0}", data);

                        
                        RDR = data.Remove(3);
                        data = data.Remove(0, 4);
                        EPOCH = null;
                        UID = data.Remove(16);
                        UID = UID.Replace("0x", "");
                        UID = UID.ToUpper();

                     
                        for (int j = 17; j < data.Length; j++)
                        {
                            EPOCH += data[j];
                        }

                        Console.WriteLine("RDR: {0}", RDR);
                        Console.WriteLine("UID: {0}", UID);
                        Console.WriteLine("EPOCH: {0}", EPOCH);

                        if (ListaUID.Contains(UID) == false)
                        {
                            ListaUID.Add(UID);
                            msql.InsertUserUnknown(UID);
                        }

                        
                        msql.Insert(RDR ,UID, DateNow());

                    }
                    client.Close();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.Stop();
            }
            Console.Read();
        }

    }
}
