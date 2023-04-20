using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegistOS.Classi
{
    internal class Roli
    {
    }

    public partial class DDocument
    {
        public string AdminContrVidimost
        {
            get
            {
                // 1 - админ, 2 - пользователь
                if (App.dPolzovatel.Rol == 1)
                {
                    return "Visible";
                }
                else if (App.dPolzovatel.Rol == 2)
                {
                    return "Hidden";
                }
                else
                {
                    //return "Collapsed";
                    return "Hidden";
                }
            }
        }
    }

    public partial class DIzdavOrgan
    {
        public string AdminContrVidimost
        {
            get
            {
                // 1 - админ, 2 - пользователь
                if (App.dPolzovatel.Rol == 1)
                {
                    return "Visible";
                }
                else if (App.dPolzovatel.Rol == 2)
                {
                    return "Hidden";
                }
                else
                {
                    //return "Collapsed";
                    return "Hidden";
                }
            }
        }
    }

    public partial class DVid
    {
        public string AdminContrVidimost
        {
            get
            {
                // 1 - админ, 2 - пользователь
                if (App.dPolzovatel.Rol == 1)
                {
                    return "Visible";
                }
                else if (App.dPolzovatel.Rol == 2)
                {
                    return "Hidden";
                }
                else
                {
                    //return "Collapsed";
                    return "Hidden";
                }
            }
        }
    }

    public partial class DRegion
    {
        public string AdminContrVidimost
        {
            get
            {
                // 1 - админ, 2 - пользователь
                if (App.dPolzovatel.Rol == 1)
                {
                    return "Visible";
                }
                else if (App.dPolzovatel.Rol == 2)
                {
                    return "Hidden";
                }
                else
                {
                    //return "Collapsed";
                    return "Hidden";
                }
            }
        }
    }
}
