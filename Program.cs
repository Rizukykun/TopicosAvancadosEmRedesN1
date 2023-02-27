using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CryptOfDecrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O arquivo textos.txt foi SEQUESTRADO e CRIPTOGRAFADO! Pague (hipoteticamente) o resgate para ter seus dados de volta! (MWAHAHAHAHA)");
            Encriptar();
        }
        static void Encriptar()
        {
            string arquivo = File.ReadAllText("textos.txt");
            File.WriteAllText("backup.txt", arquivo);
            int chave = 12;
            StringBuilder sb = new StringBuilder();
            foreach (char c in arquivo)
            {
                sb.Append(Convert.ToChar((int)c + chave));
            }
            File.WriteAllText("textos.txt", sb.ToString());
            int escolha = 0;
            while (escolha != 1)
            {
                Console.WriteLine("Texto Criptografado, Digite 1 e pressione enter para realizar o pagamento");
                escolha= Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Decriptar(chave);
        }
        static void Decriptar(int chave)
        {
            string arquivo = File.ReadAllText("textos.txt");
            StringBuilder sb = new StringBuilder();
            foreach (char c in arquivo)
            {
                sb.Append(Convert.ToChar((int)c - chave));
            }
            File.WriteAllText("textos.txt", sb.ToString());
            Console.WriteLine("Texto Decriptografado, Dinheiro recebido, Adeus...");
            Console.ReadLine();
        }
    }
}
