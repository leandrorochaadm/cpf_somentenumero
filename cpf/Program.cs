using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cpf
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            string cpfEntrada = "";
            foreach (string element in args) {
                cpfEntrada += element;
            }

            string cpf = String.Join("", System.Text.RegularExpressions.Regex.Split(cpfEntrada, @"[^\d]"));
            Clipboard.SetText(cpf);
            /*
            Console.WriteLine("Numero digitado foi: "+ cpfEntrada);
            Console.WriteLine("Numero sem pontos: "+ cpf);
            Console.ReadLine();
            */

        }
    }
}
