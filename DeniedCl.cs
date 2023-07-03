using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_esercizi
{
    public class DeniedCl
    {
         private string _private = "private";
        protected string _protected = "protected";
        internal string _internal = "internal";
        public string _public = "public";

        public string Get_Private () { return _private; }
        public string Get_Protected() {  return _protected; }
        public string Get_Iinternal() { return _internal; }
        public string Get_Public() { return _public; }
    }
}