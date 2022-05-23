using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai4_java_c_shap
{
    
    class Town
    {
        ArrayList families = new ArrayList();
        public Town()
        {
            this.Families = new ArrayList();
        }
        public ArrayList Families { get => families; set => families = value; }

        public void addFamily(Family family)
        {
            this.families.Add(family);
        }
    }
}
