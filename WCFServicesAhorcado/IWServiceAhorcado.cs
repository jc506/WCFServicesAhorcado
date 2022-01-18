using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicesAhorcado
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWServiceAhorcado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWServiceAhorcado
    {
        [OperationContract]
        Palabra GetPalabra();

        [OperationContract]
        Palabra validarLetra(string letra, string palabra, string PalabraGuion, string intentos);

    }

    [DataContract]
    public class Palabra
    {

        [DataMember]
        public string nuevaPalabra { get; set; }

        [DataMember]
        public string nuevaPalabraGuion { get; set; }

        [DataMember]
        public string intentos { get; set; }

        [DataMember]
        public string mensaje { get; set; }
    }
}
