using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTP
{
    interface IDocument
    {
        string contenu { set; }
        void dessine();
        void imprime();
    }
}
