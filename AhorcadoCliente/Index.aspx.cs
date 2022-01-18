using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AhorcadoCliente
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //deshabilitar();
        }



        protected void btn_Click(object sender, EventArgs e)
        {
            
            Button button = sender as Button;
            String[] urlImagen = { "~/Sources/images/hang0.jpg", "~/Sources/images/hang1.jpg", "~/Sources/images/hang2.jpg", "~/Sources/images/hang3.jpg", "~/Sources/images/hang4.jpg", "~/Sources/images/hang5.jpg", "~/Sources/images/hang6.jpg", "~/Sources/images/hang7.jpg" };

            using (ServiceReference.WServiceAhorcadoClient ob = new ServiceReference.WServiceAhorcadoClient())
            {

                var palabra = ob.validarLetra(button.Text.ToString(), lblPalabraNueva.Text, lblPalabraNuevaGuion.Text, lblVidas.Text);
                lblPalabraNuevaGuion.Text = palabra.nuevaPalabraGuion;
                lblVidas.Text = palabra.intentos;
                lblMensaje.Text = palabra.mensaje;

                Image1.ImageUrl = urlImagen[int.Parse(palabra.intentos)].ToString();
            }
            button.Enabled = false;
            
        }

        protected void btnPalabraNueva_Click(object sender, EventArgs e)
        {
            //habilitar();
            using (ServiceReference.WServiceAhorcadoClient db = new ServiceReference.WServiceAhorcadoClient())
            {
                var palabra = db.GetPalabra();
                lblPalabraNueva.Text = palabra.nuevaPalabra;
                lblPalabraNuevaGuion.Text = palabra.nuevaPalabraGuion;
                lblMensaje.Text = palabra.mensaje;
                lblVidas.Text = palabra.intentos;
            }

            foreach (Control c in Page.Controls)
            {
                foreach (Control childc in c.Controls)
                {
                    if (childc is Button)
                    {
                        ((Button)childc).Enabled = true;
                    }
                }
            }
        }


        public void deshabilitar() {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnP.Enabled = false;
            btnQ.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnV.Enabled = false;
            btnW.Enabled = false;
            btnX.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
        }

        public void habilitar()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
        }

    }
}