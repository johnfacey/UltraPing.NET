using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace UltraPing.NET
{
    class Whois
    {
        

     public string WhoisDomain(string domain)
     {
         Socket s = null;
         string ret = "";
         try
         {

         if (domain == null) throw new ArgumentNullException();
         int ccStart = domain.LastIndexOf(".");
         if (ccStart < 0 || ccStart == domain.Length) throw new ArgumentException();
         
         
         
             string cc = domain.Substring(ccStart + 1);
             s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
             s.Connect(new IPEndPoint(Dns.GetHostEntry(cc + ".whois-servers.net").AddressList[0], 43));
             s.Send(Encoding.ASCII.GetBytes(domain + Environment.NewLine));
             byte[] buffer = new byte[1024];
             int recv = s.Receive(buffer);
             while ((recv > 0)) {
                 ret += Encoding.ASCII.GetString(buffer, 0, recv);
                 recv = s.Receive(buffer);
             }
             s.Shutdown(SocketShutdown.Both);
         }
         catch {
             return "Error Finding Whois Information";
         }
         finally {
             if ((s != null)) s.Close();
         }
         return ret;
     }


    }
}
