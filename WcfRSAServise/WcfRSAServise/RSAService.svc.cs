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
        public List<string> GenerarLlaves()
        {
            ProvedorRSA rsa = new ProvedorRSA();
            List<string> lstLlaves = new List<string>();
            lstLlaves.Add(rsa.CrearllavePublica());
            lstLlaves.Add(rsa.CrearllavePrivada());

            return lstLlaves;
        }

        public string Encryptar(string texto,string llavePublica)
        {
            byte[] datoEncrytado = ProvedorRSA.EncryptaTexto(texto, llavePublica);
            return Convert.ToBase64String(datoEncrytado);
        }

        public string DesenCryptar(string texto, string llavePrivada)
        {
            byte[] datoDecryptar = ProvedorRSA.DecryptaTexto(texto, llavePrivada);
            return Encoding.ASCII.GetString(datoDecryptar);
        }
    }
}
