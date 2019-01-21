using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradeculator
{
    struct Functions
    {
        double conv1,unit;
        decimal output;
        internal string Func1 (string box1,decimal conv2, out string result)
        {
            conv1 = double.Parse(box1);
            if ((conv1>74) && (conv1<101))
            {
                unit = 4.00;
            }
            else if (conv1>69 && conv1<75)
            {
                unit = 3.50;
            }
            else if (conv1>64 && conv1<70)
            {
                unit = 3.25;
            }
            else if (conv1>59 && conv1<65)
            {
                unit = 3.00;
            }
            else if (conv1>54 && conv1<60)
            {
                unit = 2.75;
            }
            else if (conv1>49 && conv1<55)
            {
                unit = 2.50;
            }
            else if (conv1>44 && conv1<50)
            {
                unit = 2.25;
            }
            else if (conv1>39 && conv1<45)
            {
                unit = 2.00;
            }
            else
            {
                unit = 0.00;
            }
            output = (decimal)unit * conv2;
            result = output.ToString();
            return result;
        }
    }
}
