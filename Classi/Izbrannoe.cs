using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegistOS.Classi
{
    public partial class DIzbrannoe
    {
        public string idNazDoc
        {
            get
            {
                if (idDocumenta.Equals(DDocument.idDocumenta))
                    return DDocument.Nazvanie;
                return idDocumenta.ToString();
            }
        }
    }

    public partial class DDocument
    {
        public string nazDoc
        {
            get
            {
                return Nazvanie;
            }
        }
    }
}
