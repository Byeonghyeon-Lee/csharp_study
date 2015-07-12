using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Simple_Chat
{
    public class chatServer
    {
        public class AsyncObject
        {
            public Byte[] buffer;
            public Socket WorkingSocket;
            public AsyncObject(Int32 bufferSize)
            {
                this.buffer = new Byte[bufferSize];
            }
        }
    }
}
