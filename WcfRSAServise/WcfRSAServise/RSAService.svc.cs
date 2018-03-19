using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRSAServise
{
    
    public class RSAService : IRSAService
    {
        public string GeneraLlavePublica()
        {
            ProvedorRSA rsa = new ProvedorRSA();
            string publica = rsa.CrearllavePublica();
            //return Convert.ToBase64String(publica);
            return publica;
        }

        public string GeneraLavePrivada()
        {
            ProvedorRSA rsa = new ProvedorRSA();
            string privada = rsa.CrearllavePrivada();
            //return Convert.ToBase64String(privada);
            return privada;
        }

        public string Encryptar(string texto,string llavePublica)
        {
            byte[] datoEncrytado = ProvedorRSA.EncryptaTexto(texto, llavePublica);
            return Convert.ToBase64String(datoEncrytado);
        }

        public string DesenCryptar(string texto, string llavePrivada)
        {
            //byte[] datoDecryptar = ProvedorRSA.DecryptaTexto(texto, llavePrivada);
            //return Encoding.ASCII.GetString(datoDecryptar);
            return "";
        }

       
    }
}
