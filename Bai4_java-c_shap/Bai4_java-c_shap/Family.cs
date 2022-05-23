using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_java_c_shap
{
    class Family
    {
        private List<Person> presons;
        private String address;

        public Family(List<Person> presons, String address)
        {
            this.Presons = presons;
            this.Address = address;
        }

        public string Address { get => address; set => address = value; }
        internal List<Person> Presons { get => presons; set => presons = value; }

    
        public String toString()
            {
                return "Family{" +
                        "presons=" + presons +
                        ", address='" + address + '\'' +
                        '}';
            }

    }
}
