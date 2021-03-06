﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRSAServise
{
    [ServiceContract]
    public interface IRSAService
    {
        [OperationContract]
        List<string> GenerarLlaves();

        [OperationContract]
        string Encryptar(string texto, string llavePublica);

        [OperationContract]
        string DesenCryptar(string texto, string llavePrivada);

    }
}
