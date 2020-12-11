     using System;
     using System.Collections.Generic;
     using System.ComponentModel;
     using System.Net;
     using System.Net.Sockets;
     using System.Text;

/*namespace MyServer
{
    class Program
    {
        // 宣告客戶端清單
        public static List<Client> ClientList;

        public static void Main(string[] args)
        {
            //產生 BackgroundWorker 負責處理每一個 socket client 的 reuqest
            BackgroundWorker bgwSocket = new BackgroundWorker();
            bgwSocket.DoWork += new DoWorkEventHandler(bgwSocket_DoWork);
            bgwSocket.RunWorkerAsync();
            while (true)
            {
                BoardCast("伺服器端：" + Console.ReadLine());
            }
        }

        private static void bgwSocket_DoWork(object sender, DoWorkEventArgs e)
        {
            // 設定連線接聽阜值
            const int ServerPort = 80;

            // 設定半開連接數
            const int BackLog = 10;

            // 初始化客戶端清單
            ClientList = new List<Client>();

            // 初始化客戶端序列號
            int PlayerNum = 0;

            // 建立接聽Socket
            Socket ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 綁定接聽Socket的IP與Port
            ListenSocket.Bind(new IPEndPoint(IPAddress.Any, ServerPort));

            // 開始接聽
            ListenSocket.Listen(BackLog);

            // 輸出伺服器端起始訊息
            Console.WriteLine("開始接聽客戶端連線...");

            // 持續等待客戶端接入
            while (true)
            {
                ClientList.Add(new Client(PlayerNum, ListenSocket.Accept()));
                PlayerNum++;
            }
        }

        public static void BoardCast(string serverResponse)
        {
            foreach (Client myClient in Program.ClientList)
            {
                myClient.SendToPlayer(serverResponse);
                Console.WriteLine("廣播訊息：{0}", serverResponse);
            }
        }

        public static void RemoveClient(int PlayerNum)
        {
            foreach (Client myClient in Program.ClientList)
            {
                if (myClient.CurrentPlayerNum.Equals(PlayerNum))
                {
                    Program.ClientList.Remove(myClient);
                    break;
                }
            }
        }
    }

    class Client
    {
        public int CurrentPlayerNum { get; set; }
        public Socket PlayerSocket { get; set; }
        public int CurrentStatus { get; set; }
        public Client(int PlayerNum, Socket mySocket)
        {
            this.CurrentPlayerNum = PlayerNum;
            this.PlayerSocket = mySocket;
            this.CurrentStatus = 1;
            DoCommunicate();
        }

        public void DoCommunicate()
        {
            //產生 BackgroundWorker 負責處理每一個 socket client 的 reuqest
            BackgroundWorker bgwSocket = new BackgroundWorker();
            bgwSocket.DoWork += new DoWorkEventHandler(bgwSocket_DoWork);
            bgwSocket.RunWorkerAsync();
        }

        private void bgwSocket_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //server & client 已經連線完成
                Console.WriteLine("客戶端No.{0}已連結.", CurrentPlayerNum.ToString());
                Program.BoardCast("客戶端No." + CurrentPlayerNum.ToString() + "已連結.");
                while (PlayerSocket.Connected)
                {
                    byte[] readBuffer = new byte[PlayerSocket.ReceiveBufferSize];
                    int count = 0;

                    if ((count = PlayerSocket.Receive(readBuffer)) > 0)
                    {
                        string clientRequest = Encoding.UTF8.GetString(readBuffer, 0, count);
                        Program.BoardCast("客戶端No." + CurrentPlayerNum.ToString() + "：" + clientRequest);
                        Console.WriteLine("客戶端No.{0}：{1}", CurrentPlayerNum.ToString(), clientRequest);
                    }
                }
            }
            catch
            {
                Program.BoardCast("客戶端No." + CurrentPlayerNum.ToString() + "已斷開連結.");
                Console.WriteLine("客戶端No.{0}已斷開連結.", CurrentPlayerNum.ToString());
            }
            finally
            {
                PlayerSocket.Close();
                this.CurrentStatus = 0;
                Program.RemoveClient(this.CurrentPlayerNum);
            }
        }

        public int SendToPlayer(string serverResponse)
        {
            if (this.CurrentStatus.Equals(1))
            {
                try
                {
                    byte[] sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                    return PlayerSocket.Send(sendBytes);
                }
                catch
                {
                    return 0;
                }
            }
            else
                return 0;
        }
    }
}*/