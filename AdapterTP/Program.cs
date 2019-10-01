using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTP
{

    /*
     * Le pattern est utilisé dans les cas suivants :
     * pour intégrer dans un système un objet dont l’interface ne correspond pas 
     * à l’interface requise au sein de ce système ;
     * pour fournir des interfaces multiples à un objet lors de sa conception
     */
    class Program
    {
        static void Main(string[] args)
        {
            IDocument document1, document2;
            document1 = new DocumentHtml();
            document1.contenu = "Hello";
            document1.dessine();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.contenu = "Bonjour";
            document2.dessine();
            Console.ReadKey();
        }
    }
}
