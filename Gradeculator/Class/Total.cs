using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradeculator
{
    struct Total
    {
        
        decimal sresult;
        double bresult;
        double b1, b2, b3, b4, b5, b6, b7, b8, b9;
        internal decimal Calkulate(decimal sp1,decimal sp2,decimal sp3, decimal sp4, decimal sp5,decimal sp6, decimal sp7, decimal sp8, decimal sp9,out decimal spres)
        {
            sresult = sp1 + sp2 + sp3 + sp4 + sp5+sp6 + sp7 + sp8 + sp9;
            spres=sresult;
            return spres;
        }
        internal double Calkulate (string bx1,string bx2,string bx3,string bx4,string bx5,string bx6,string bx7, string bx8,string bx9,out double holder)
        {
            b1 = Convert.ToDouble(bx1); b2 = Convert.ToDouble(bx2); b3 = Convert.ToDouble(bx3); b4 = Convert.ToDouble(bx4); b5 = Convert.ToDouble(bx5); b6 = Convert.ToDouble(bx6); b7 = Convert.ToDouble(bx7);
            b8 = Convert.ToDouble(bx8); b9 = Convert.ToDouble(bx9);
            bresult = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9;
            holder = bresult;
            return holder;
        }
    }
}
