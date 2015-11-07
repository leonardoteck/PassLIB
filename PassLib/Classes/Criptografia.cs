using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace PassLib
{
    class Criptografia
    {
        public enum Process
        {
            Cifrar,
            Decifrar,
            Hash
        }

        public static string GlobalCryptoServiceProvider(Process metodo, string texto)
        {
            if (metodo == Process.Cifrar || metodo == Process.Decifrar)
            {
                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    //
                    // NÃO ESQUECE DE TROCAR ESSAS CHAVES! ¬
                    //
                    aes.Key = Encoding.ASCII.GetBytes("abcdefghijklmnopqrstuvwxyz123456");
                    aes.IV = Encoding.ASCII.GetBytes("0123456789abcdef");

                    if (metodo == Process.Cifrar)
                        return Encipher(texto, aes.Key, aes.IV);
                    if (metodo == Process.Decifrar)
                        return Decipher(texto, aes.Key, aes.IV);
                }
            }
            else
            {

                byte[] bTexto = Encoding.Unicode.GetBytes(texto);

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();

                byte[] resultado = md5.ComputeHash(sha512.ComputeHash(bTexto));

                return Encoding.Unicode.GetString(resultado);
            }

            return null;
        }

        static string Encipher(String texto, byte[] Key, byte[] IV)
        {
            byte[] cifrado;
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(texto);
                        }
                        cifrado = msEncrypt.ToArray();
                    }
                }
            }

            return Encoding.Unicode.GetString(cifrado);
        }

        static string Decipher(String texto, byte[] Key, byte[] IV)
        {
            byte[] bTexto = Encoding.Unicode.GetBytes(texto);
            string decifrado;

            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(bTexto))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decifrado = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decifrado;
        }
    }
}
