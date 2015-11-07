using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PassLib
{
    class Arquivo
    {
        public static string codexAtivoPath;

        public static void EscreveSenha(string senha)
        {
            StreamWriter escritor = new StreamWriter(codexAtivoPath);
            escritor.Write(senha);
            escritor.Close();
        }

        public static string LeitorSenha(string path)
        {
            string senha;
            StreamReader leitor = new StreamReader(path);
            senha = leitor.ReadLine();
            leitor.Close();
            senha = senha.Substring(0, 8);
            return senha;
        }

        public static void EscreveItens(List<Itens> itens)
        {
            string senhadocodex = LeitorSenha(codexAtivoPath);
            string serial = SerializaItens(itens);
            string crypt = Criptografia.GlobalCryptoServiceProvider(
                Criptografia.Process.Cifrar, serial);

            StreamWriter escritor = new StreamWriter(codexAtivoPath);
            escritor.Write(senhadocodex + crypt);
            escritor.Flush();
            escritor.Close();
        }

        public static Itens LeitorItens()
        {
            throw new NotImplementedException();
        }

        public static string SerializaItens(List<Itens> itens)
        {
            return JsonConvert.SerializeObject(itens);
        }

        public static List<Itens> DesserializaItens(string serial)
        {
            return JsonConvert.DeserializeObject<List<Itens>>(serial);
        }
    }
}
