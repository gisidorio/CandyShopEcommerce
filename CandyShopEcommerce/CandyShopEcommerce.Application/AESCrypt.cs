using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application
{
    public class AESCrypt
    {
        AesCryptoServiceProvider cryptProvider;

        public AESCrypt()
        {
            cryptProvider = new AesCryptoServiceProvider();

            cryptProvider.BlockSize = 128; // seta o tamanho do bloco em bits da criptografia
            cryptProvider.KeySize = 256; // seta o tamanho em bits da chave secreta
            cryptProvider.GenerateIV(); // utiliza um vetor de inicialização randomico 
            cryptProvider.GenerateKey(); // gera uma chave randomica usada no algoritmo
            cryptProvider.Mode = CipherMode.CBC; // modo para operação de algoritmo simétrico
            cryptProvider.Padding = PaddingMode.PKCS7; // modo padding para operação do algoritmo simetrico                
        }

        public string Encrypt(string clear_text)
        {
            ICryptoTransform transform = cryptProvider.CreateEncryptor(cryptProvider.Key, cryptProvider.IV);
            
            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(clear_text), 0, clear_text.Length);

            string str = Convert.ToBase64String(encrypted_bytes);

            return str;
        }

        public string decrypt(string cipher_text)
        {
            ICryptoTransform transform = cryptProvider.CreateDecryptor(cryptProvider.Key, cryptProvider.IV);

            byte[] enc_bytes = Convert.FromBase64String(cipher_text);

            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

            string str = ASCIIEncoding.ASCII.GetString(decrypted_bytes);

            return str;
        }
    }
}
