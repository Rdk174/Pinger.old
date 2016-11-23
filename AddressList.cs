using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pinger
{
    class Resource
    {
        //public Resource(int id, string name, string ooo, string address, string ip)
        //{
        //    Id = id;
        //    Name = name;
        //    OOO = ooo;
        //    Address = address;
        //    IP = ip;   
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string OOO { get; set; }
        public string Address { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string UTMVer { get; set; }
        public string PKI { get; set; }
        public string Gost { get; set; }    

    }
}
