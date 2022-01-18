using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicesAhorcado
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WServiceAhorcado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WServiceAhorcado.svc o WServiceAhorcado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WServiceAhorcado : IWServiceAhorcado
    {
      

        public Palabra GetPalabra()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string[] lstpalabras = { "JAMAICA", "FRESA", "GALLO", "PERAS", "LIMONADA" };

            string adivinaPalabra = lstpalabras[random.Next(0, lstpalabras.Length)];
            string palabraencontrada = adivinaPalabra.ToUpper();

            StringBuilder jugador = new StringBuilder(adivinaPalabra.Length);
            for (int i = 0; i < adivinaPalabra.Length; i++)
            {
                jugador.Append('-');
            }
            return new Palabra
            {
                nuevaPalabra = palabraencontrada,
                nuevaPalabraGuion = jugador.ToString(),
                intentos = 7.ToString()

            };
        }

        public Palabra validarLetra(string letra, string palabra, string PalabraGuion, string intentos)
        {

            string adividaPalabra = palabra;
            string palabraencontrada = adividaPalabra.ToUpper();
            string palabraGuion = PalabraGuion;
            int vidas = int.Parse(intentos);
            string mensaje = "";
            bool victoria = false;

            string entrada = letra.ToUpper();
            char adivina = entrada[0];

            StringBuilder jugador = new StringBuilder(adividaPalabra.Length);
            jugador.Append(palabraGuion);

            if (!victoria && vidas > 0)
            {
                if (palabraencontrada.Contains(adivina))
                {

                    for (int i = 0; i < adividaPalabra.Length; i++)
                    {
                        if (palabraencontrada[i] == adivina)
                        {
                            jugador[i] = adividaPalabra[i];
                        }
                    }
                    if (jugador.ToString().Equals(palabraencontrada.ToString()))
                    {
                        victoria = true;
                        mensaje = "Felicidades Has Ganado, Presiona la tecla nueva palabra para seguir jugando";
                    }
                }
                else
                {
                    vidas--;
                    if (vidas == 0)
                    {
                        mensaje = "No!!, No Hay " + adivina + " en la Palabra, Has Perdido el Juego, Presiona Nueva Palabra para Continuar";
                    }
                    else
                    {
                        mensaje = "No!!, No Hay " + adivina + " en la Palabra";
                    }
                }
            }

            return new Palabra()
            {
                nuevaPalabra = palabraencontrada,
                nuevaPalabraGuion = jugador.ToString(),
                intentos = vidas.ToString(),
                mensaje = mensaje.ToString()
            };
        }
    }
}
