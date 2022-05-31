using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bai_HDT_02
{
    class ManagerDocument
    {
        List<Document> documents;

        public ManagerDocument()
        {
           this.documents = new List<Document>();
        }
        public void addDocument(Document document)
        {
            this.documents.Add(document);
        }

        public void showInfor()
        {
            foreach( Document document in documents)
            {
                
            }
            
        }

    }
}
