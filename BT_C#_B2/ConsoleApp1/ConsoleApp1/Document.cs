using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_HDT_B2
{
    class Document
    {
        private String id;
        private String nxb;
        private int number;

        protected string Id { get => id; set => id = value; }
        protected string Nxb { get => nxb; set => nxb = value; }
        protected int Number { get => number; set => number = value; }
        public Document(String id, String nxb, int number)
        {
            this.Id = id;
            this.Nxb = nxb;
            this.Number = number;
        }



    }
}

