using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegistOS.Classi
{
    internal class DStatus
    {
    }

    public partial class DDocument
    {
        public string status
        {
            get
            {
                if (Status == 1)
                {
                    return "Действующие";

                }
                else if(Status == 2)
                {
                    return "Не вступившие в силу";

                }
                else 
                {
                    return "Утратившие силу";
                }
            }
        }
    }
}
