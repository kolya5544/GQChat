﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Server
{
    static public class Data
    {
        static public List<ClientConnectOnly> ClientsOnlyData { get; set; } = new List<ClientConnectOnly>();

        //Прочее

        public class ClientConnectOnly//инфа о клиенте (онлайн) (ТОЛЬКО ДЛЯ СЕРВЕРА)
        {
            public ClientConnectOnly(TcpClient tcpClient, string email, string passworld)
            {
                ClientSocket = tcpClient;
                Email = email;
                Passworld = passworld;
            }

            public TcpClient ClientSocket { get; set; }
            public string Email { get; set; }
            public string Passworld { get; set; }
        }

        /*
        public struct ClientConnectOffline//инфа о клиенте (офнлайн)
        {
            public int ID;
            public string Email;
            public string Passworld;
        }
        

        public struct GeneralChatMess//Сообщение для клиента (Общий чат)
        {
            public int ID;
            public string Text;
        }
        */
    }
}
