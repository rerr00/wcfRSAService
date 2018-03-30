using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace WcfRSAServise
{
    public class ProvedorRSA
    {
        public RSACryptoServiceProvider ServicioRSA { get; set; }

        public ProvedorRSA()
        {
            this.ServicioRSA = new RSACryptoServiceProvider();
        }

        public string CrearllavePublica()
        {
            string xmlLLavePublica = this.ServicioRSA.ToXmlString(false);
            return xmlLLavePublica;
        }

        public string CrearllavePrivada()
        {
            string xmlLLavePrivada = this.ServicioRSA.ToXmlString(true);
            return xmlLLavePrivada;
        }

        public static byte[] EncryptaTexto(string texto, string xmlPublico)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPublico);
            
            byte[] datoEncryptado = RSA.Encrypt(Encoding.ASCII.GetBytes(texto), false);
            return datoEncryptado;
        }

        public static byte[] DecryptaTexto(string encryptedText, string xmlPrivado)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPrivado);
            byte[] datoDecryptado = RSA.Decrypt(Convert.FromBase64String(encryptedText), false);
            return datoDecryptado;
        }
    }
}