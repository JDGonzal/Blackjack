using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class frmBlackJackMultiplayer : Form
    {
        
        Random rnd = new Random();
        int plataJ1, plataJ2, apuestaTotal, apostoJ1, apostoJ2,apuestaJ1, apuestaJ2;
        int pedir, repartir, parar, cantJ1, cantJ2, asJ1C1, asJ1C2, asJ2C1, asJ2C2, resultado, partGanJ1, partGranJ2;

        private void btnApostarJ1_Click(object sender, EventArgs e)
        {
            apostoJ1 = 0;
            plataJ1 = Convert.ToInt32(lblPlataJ1.Text);

            apuestaJ1 = Convert.ToInt32(txtboxApJ1.Text);

            plataJ1 -= apuestaJ1;
            lblPlataJ1.Text = Convert.ToString(plataJ1);
            apostoJ1++;
            lblDeseaApostar.Visible = true;
            btnSiApostar.Visible = true;
            btnNoApostar.Visible = true;
            btnApostarJ1.Enabled = false;
        }

        private void btnNoApostar_Click(object sender, EventArgs e)
        {
            lblDeseaApostar.Visible = false;
            btnSiApostar.Visible = false;
            btnNoApostar.Visible = false;

            if (apostoJ1 == 1)
            {
                apuestaJ1 = Convert.ToInt32(txtboxApJ1.Text);

                apuestaJ2 = apuestaJ1;
                plataJ2 = Convert.ToInt32(lblPlataJ2.Text);
                plataJ2 -= apuestaJ1;
                lblPlataJ2.Text = Convert.ToString(plataJ2);
                apuestaTotal = apuestaJ1 + apuestaJ2;
                lblApTotal.Text = Convert.ToString(apuestaTotal);
                txtboxApJ1.Text = "";
            }
            else if (apostoJ2 == 1)
            {
                apuestaJ2 = Convert.ToInt32(txtboxApJ2.Text);
                apuestaJ1 = apuestaJ2;
                plataJ1 = Convert.ToInt32(lblPlataJ1.Text);
                plataJ1 -= apuestaJ2;
                lblPlataJ1.Text = Convert.ToString(plataJ1);
                apuestaTotal = apuestaJ2 + apuestaJ1;
                lblApTotal.Text = Convert.ToString(apuestaTotal);
                txtboxApJ2.Text = "";
            }

        }

        private void btnSiApostar_Click(object sender, EventArgs e)
        {
            lblDeseaApostar.Visible = false;
            btnSiApostar.Visible = false;
            btnNoApostar.Visible = false;

            if (apostoJ1 == 1)
            {
                apuestaJ1 = Convert.ToInt32(txtboxApJ1.Text);
                apuestaJ2 = apuestaJ1;
                plataJ2 = Convert.ToInt32(lblPlataJ2.Text);
                plataJ2 -= apuestaJ1;
                lblPlataJ2.Text = Convert.ToString(plataJ2);
                apuestaTotal = apuestaJ1 + apuestaJ2;
                lblApTotal.Text = Convert.ToString(apuestaTotal);
                txtboxApJ1.Text = "";
            }else if (apostoJ2 == 1)
            {
                apuestaJ2 = Convert.ToInt32(txtboxApJ2.Text);
                apuestaJ1 = apuestaJ2;
                plataJ1 = Convert.ToInt32(lblPlataJ1.Text);
                plataJ1 -= apuestaJ2;
                lblPlataJ1.Text = Convert.ToString(plataJ1);
                apuestaTotal = apuestaJ2 + apuestaJ1;
                lblApTotal.Text = Convert.ToString(apuestaTotal);
                txtboxApJ2.Text = "";
            }

        }

        private void btnApostarJ2_Click(object sender, EventArgs e)
        {
            apostoJ2 = 0;
            plataJ2 = Convert.ToInt32(lblPlataJ2.Text);

            apuestaJ2 = Convert.ToInt32(txtboxApJ2.Text);

            plataJ2 -= apuestaJ2;
            lblPlataJ2.Text = Convert.ToString(plataJ2);
            apostoJ2++;
            lblDeseaApostar.Visible = true;
            btnSiApostar.Visible = true;
            btnNoApostar.Visible = true;
            btnApostarJ1.Enabled = false;
        }

    


        /*
       Requisitos adicionales:
        - El juego debe acumular el puntaje(partidas ganadas) y valor acumulado de cada jugador
        durante varias partidas. El jugador que gane queda con un valor acumulado = apuesta
        propia + apuesta del otro jugador.
        - Cuando un jugador gana dos veces seguidas, su puntaje acumulado y valor acumulado se
        triplica.
        - Implementar la variante de un solo jugador contra el computador (o contra la casa)
        conservando las mismas reglas descritas anteriormente
         * */


        public frmBlackJackMultiplayer()
        {
            InitializeComponent();

            lblPuntJ1.Text = "0";
            lblPuntJ2.Text = "0";
            lblPlataJ1.Text = "100000";
            lblPlataJ2.Text = "100000";
            

        }

        private void frmBlackJack_Load(object sender, EventArgs e)
        {
            
        }

       
        private void logicaJuego()
        {
            cantJ1 = Convert.ToInt32(lblCantJ1.Text);
            cantJ2 = Convert.ToInt32(lblCantJ2.Text);
            
            if ((cantJ1 > 21))
            {
                lblResultadoJ1.Text = "PERDISTE";
                lblResultadoJ2.Text = "GANASTE";
                lblResultadoJ1.Visible = true;
                lblResultadoJ2.Visible = true;
                resultado++;
                partGranJ2++;
                lblPuntJ2.Text = Convert.ToString(partGranJ2);
            }
            else if(cantJ2 > 21)
            {
                lblResultadoJ1.Text = "GANASTE";
                lblResultadoJ2.Text = "PERDISTE";
                lblResultadoJ1.Visible = true;
                lblResultadoJ2.Visible = true;
                resultado++;
                partGanJ1++;
                lblPuntJ1.Text = Convert.ToString(partGanJ1);
            }
            else if ((cantJ1 > cantJ2) && (parar==2))
            {
                lblResultadoJ1.Text = "GANASTE";
                lblResultadoJ2.Text = "PERDISTE";
                lblResultadoJ1.Visible = true;
                lblResultadoJ2.Visible = true;
                resultado++;
                partGanJ1++;
                lblPuntJ1.Text = Convert.ToString(partGanJ1);
            }
            else if ((cantJ2 > cantJ1) && (parar == 2))
            {
                lblResultadoJ1.Text = "PERDISTE";
                lblResultadoJ2.Text = "GANASTE";
                lblResultadoJ1.Visible = true;
                lblResultadoJ2.Visible = true;
                resultado++;
                partGranJ2++;
                lblPuntJ2.Text = Convert.ToString(partGranJ2);

            }
            else if ((cantJ2 == cantJ1) && (parar == 2))
            {
                lblResultadoJ1.Text = "EMPATE";
                lblResultadoJ2.Text = "EMPATE";
                lblResultadoJ1.Visible = true;
                lblResultadoJ2.Visible = true;
                resultado++;
            }

            if (resultado == 1)
            {
                btnRepartir.Enabled = true;
            }

        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            int[] cartasInicio = new int[4];
            pedir = 1;
            repartir = 1;
            resultado = 0;
            parar = 0;
            cantJ1 = 0;
            cantJ2 = 0;
            asJ1C1 = 0;
            asJ1C2 = 0;
            asJ2C1 = 0;
            asJ2C2 = 0;
            lblCantJ1.Text="0";
            lblCantJ1.Text = "0";
            lblCarta3J1.Visible = false;
            lblCarta4J1.Visible = false;
            lblCarta5J1.Visible = false;
            lblCarta3J2.Visible = false;
            lblCarta4J2.Visible = false;
            lblCarta5J2.Visible = false;
            lblResultadoJ1.Visible = false;
            lblResultadoJ2.Visible = false;


            for (int i = 0; i < 4; i++)
            {
                cartasInicio[i] = rnd.Next(2, 15);


                if (i == 0)
                {

                    if ((cartasInicio[i] < 11) && (cartasInicio[i] >= 2))
                    {
                        lblCarta1J1.Text = Convert.ToString(cartasInicio[i]);
                        
                    }

                    else if (cartasInicio[i] == 11)
                    {
                        cartasInicio[i] = 10;
                        lblCarta1J1.Text = "J";
                    }

                    else if (cartasInicio[i] == 12)
                    {
                        cartasInicio[i] = 10;
                        lblCarta1J1.Text = "Q";
                    }

                    else if (cartasInicio[i] == 13)
                    {
                        cartasInicio[i] = 10;
                        lblCarta1J1.Text = "K";
                    }

                    else 
                    {
                        cartasInicio[i] = 11;
                        lblCarta1J1.Text = "A";
                    }
                    cantJ1= cartasInicio[i];
                    lblCantJ1.Text = Convert.ToString(cantJ1);
                    lblCarta1J1.Visible = true;
                }

               
                else if (i == 1)
                {
                    
                    if ((cartasInicio[i] < 11) && (cartasInicio[i] >= 2))
                    {
                        lblCarta2J1.Text = Convert.ToString(cartasInicio[i]);

                    }

                    else if (cartasInicio[i] == 11)
                    {
                        cartasInicio[i] = 10;
                        lblCarta2J1.Text = "J";
                    }

                    else if (cartasInicio[i] == 12)
                    {
                        cartasInicio[i] = 10;
                        lblCarta2J1.Text = "Q";
                    }

                    else if (cartasInicio[i] == 13)
                    {
                        cartasInicio[i] = 10;
                        lblCarta2J1.Text = "K";
                    }

                    else 
                    {
                        cartasInicio[i] = 11;
                        lblCarta2J1.Text = "A";
                    }
                    cantJ1 += cartasInicio[i];
                    lblCantJ1.Text = Convert.ToString(cantJ1);
                    lblCarta2J1.Visible = true;
                }


                if (i == 2)
                {

                    if ((cartasInicio[i] < 11) && (cartasInicio[i] >= 2))
                    {
                        lblCarta1J2.Text = Convert.ToString(cartasInicio[i]);

                    }

                    else if (cartasInicio[i] == 11)
                    {
                        cartasInicio[i] = 10;
                        lblCarta1J2.Text = "J";
                    }

                    else if (cartasInicio[i] == 12)
                    {
                        cartasInicio[i] = 10;
                        lblCarta1J2.Text = "Q";
                    }

                    else if (cartasInicio[i] == 13)
                    {
                        cartasInicio[i] = 10;
                        lblCarta1J2.Text = "K";
                    }

                    else 
                    {
                        cartasInicio[i] = 11;
                        lblCarta1J2.Text = "A";
                    }
                    cantJ2 += cartasInicio[i];
                    lblCantJ2.Text = Convert.ToString(cantJ2);
                    lblCarta1J2.Visible = true;
                }

                else if (i == 3)
                {

                    if ((cartasInicio[i] < 11) && (cartasInicio[i] >= 2))
                    {
                        lblCarta2J2.Text = Convert.ToString(cartasInicio[i]);

                    }

                    else if (cartasInicio[i] == 11)
                    {
                        cartasInicio[i] = 10;
                        lblCarta2J2.Text = "J";
                    }

                    else if (cartasInicio[i] == 12)
                    {
                        cartasInicio[i] = 10;
                        lblCarta2J2.Text = "Q";
                    }

                    else if (cartasInicio[i] == 13)
                    {
                        cartasInicio[i] = 10;
                        lblCarta2J2.Text = "K";
                    }

                    else 
                    {
                        cartasInicio[i] = 11;
                        lblCarta2J2.Text = "A";
                    }
                    cantJ2 += cartasInicio[i];
                    lblCantJ2.Text = Convert.ToString(cantJ2);
                    lblCarta2J2.Visible = true;
                }
            }
            btnRepartir.Enabled=false;
            logicaJuego();
        }



        private void btnPedirCarta_Click(object sender, EventArgs e)
        {
            
            pedir = pedir + 2;

            int cartasRepartir = rnd.Next(2,15);

            if (pedir == 3)
            {

                if ((cartasRepartir < 11) && (cartasRepartir >= 2))
                {
                    lblCarta3J1.Text = Convert.ToString(cartasRepartir);

                }

                else if (cartasRepartir == 11)
                {
                    cartasRepartir = 10;
                    lblCarta3J1.Text = "J";
                }

                else if (cartasRepartir == 12)
                {
                    cartasRepartir = 10;
                    lblCarta3J1.Text = "Q";
                }

                else if (cartasRepartir == 13)
                {
                    cartasRepartir = 10;
                    lblCarta3J1.Text = "K";
                }

                else
                {
                    if (cantJ1 <= 21)
                    {
                        cartasRepartir = 11;
                        lblCarta3J1.Text = "A";
                    }
                    else
                    {
                        cartasRepartir = 1;
                        lblCarta3J1.Text = "A";
                    }
                }
                lblCarta3J1.Visible = true;
                cantJ1 += cartasRepartir;

                if ((lblCarta1J1.Text == "A") && (cantJ1 > 21))
                {
                    cantJ1 = cantJ1 - 10;
                    asJ1C1++;
                    
                }
                else if ((lblCarta2J1.Text == "A") && (cantJ1 > 21)) {
                    cantJ1 = cantJ1 - 10;
                    asJ1C2++;
                }

                lblCantJ1.Text = Convert.ToString(cantJ1);



            }
            else if (pedir == 5)
            {

                if ((cartasRepartir < 11) && (cartasRepartir >= 2))
                {
                    lblCarta4J1.Text = Convert.ToString(cartasRepartir);

                }

                else if (cartasRepartir == 11)
                {
                    cartasRepartir = 10;
                    lblCarta4J1.Text = "J";
                }

                else if (cartasRepartir == 12)
                {
                    cartasRepartir = 10;
                    lblCarta4J1.Text = "Q";
                }

                else if (cartasRepartir == 13)
                {
                    cartasRepartir = 10;
                    lblCarta4J1.Text = "K";
                }

                else
                {
                    
                    cartasRepartir = 11;
                    lblCarta4J1.Text = "A";
                }
                lblCarta4J1.Visible = true;
                cantJ1 += cartasRepartir;
                if ((lblCarta1J1.Text == "A") && (cantJ1 > 21) && (asJ1C1 < 1))
                {
                    cantJ1 = cantJ1 - 10;
                    asJ1C1++;

                }
                else if ((lblCarta2J1.Text == "A") && (cantJ1 > 21) && (asJ1C2 < 1))
                {
                    cantJ1 = cantJ1 - 10;
                    asJ1C2++;
                }
                lblCantJ1.Text = Convert.ToString(cantJ1);
            }
            else if (pedir == 7)
            {

                if ((cartasRepartir < 11) && (cartasRepartir >= 2))
                {
                    lblCarta5J1.Text = Convert.ToString(cartasRepartir);

                }

                else if (cartasRepartir == 11)
                {
                    cartasRepartir = 10;
                    lblCarta5J1.Text = "J";
                }

                else if (cartasRepartir == 12)
                {
                    cartasRepartir = 10;
                    lblCarta5J1.Text = "Q";
                }

                else if (cartasRepartir == 13)
                {
                    cartasRepartir = 10;
                    lblCarta5J1.Text = "K";
                }

                else
                {
                    cartasRepartir = 11;
                    lblCarta5J1.Text = "A";
                }
                lblCarta5J1.Visible = true;
                cantJ1 += cartasRepartir;
                if ((lblCarta1J1.Text == "A") && (cantJ1 > 21) && (asJ1C1 < 1))
                {
                    cantJ1 = cantJ1 - 10;
                    asJ1C1++;

                }
                else if ((lblCarta2J1.Text == "A") && (cantJ1 > 21) && (asJ1C2 < 1))
                {
                    cantJ1 = cantJ1 - 10;
                    asJ1C2++;
                }
                lblCantJ1.Text = Convert.ToString(cantJ1);
            }
            else if (pedir == 4)
            {

                if ((cartasRepartir < 11) && (cartasRepartir >= 2))
                {
                    lblCarta3J2.Text = Convert.ToString(cartasRepartir);

                }

                else if (cartasRepartir == 11)
                {
                    cartasRepartir = 10;
                    lblCarta3J2.Text = "J";
                }

                else if (cartasRepartir == 12)
                {
                    cartasRepartir = 10;
                    lblCarta3J2.Text = "Q";
                }

                else if (cartasRepartir == 13)
                {
                    cartasRepartir = 10;
                    lblCarta3J2.Text = "K";
                }

                else
                {
                    cartasRepartir = 11;
                    lblCarta3J2.Text = "A";
                }
                lblCarta3J2.Visible = true;
                cantJ2 += cartasRepartir;
                if ((lblCarta1J2.Text == "A") && (cantJ2 > 21))
                {
                    cantJ1 = cantJ2 - 10;
                    asJ2C1++;

                }
                else if ((lblCarta2J2.Text == "A") && (cantJ2 > 21))
                {
                    cantJ2 = cantJ2 - 10;
                    asJ2C2++;
                }
                lblCantJ2.Text = Convert.ToString(cantJ2);
            }
            else if (pedir == 6)
            {

                if ((cartasRepartir < 11) && (cartasRepartir >= 2))
                {
                    lblCarta4J2.Text = Convert.ToString(cartasRepartir);

                }

                else if (cartasRepartir == 11)
                {
                    cartasRepartir = 10;
                    lblCarta4J2.Text = "J";
                }

                else if (cartasRepartir == 12)
                {
                    cartasRepartir = 10;
                    lblCarta4J2.Text = "Q";
                }

                else if (cartasRepartir == 13)
                {
                    cartasRepartir = 10;
                    lblCarta4J2.Text = "K";
                }

                else
                {
                    cartasRepartir = 11;
                    lblCarta4J2.Text = "A";
                }
                lblCarta4J2.Visible = true;
                cantJ2 += cartasRepartir;
                if ((lblCarta1J2.Text == "A") && (cantJ2 > 21) && (asJ2C1 < 1))
                {
                    cantJ2 = cantJ2 - 10;
                    asJ2C1++;

                }
                else if ((lblCarta2J2.Text == "A") && (cantJ2 > 21) && (asJ2C2 < 1))
                {
                    cantJ2 = cantJ2 - 10;
                    asJ2C2++;
                }
                lblCantJ2.Text = Convert.ToString(cantJ2);
            }
            else if (pedir == 8)
            {

                if ((cartasRepartir < 11) && (cartasRepartir >= 2))
                {
                    lblCarta5J2.Text = Convert.ToString(cartasRepartir);

                }

                else if (cartasRepartir == 11)
                {
                    cartasRepartir = 10;
                    lblCarta5J2.Text = "J";
                }

                else if (cartasRepartir == 12)
                {
                    cartasRepartir = 10;
                    lblCarta5J2.Text = "Q";
                }

                else if (cartasRepartir == 13)
                {
                    cartasRepartir = 10;
                    lblCarta5J2.Text = "K";
                }

                else
                {
                    cartasRepartir = 11;
                    lblCarta5J2.Text = "A";
                }
                lblCarta5J2.Visible = true;
                cantJ2 += cartasRepartir;
                if ((lblCarta1J2.Text == "A") && (cantJ2 > 21) && (asJ2C1 < 1))
                {
                    cantJ2 = cantJ2 - 10;
                    asJ2C1++;

                }
                else if ((lblCarta2J2.Text == "A") && (cantJ2 > 21) && (asJ2C2 < 1))
                {
                    cantJ2 = cantJ2 - 10;
                    asJ2C2++;
                }
                lblCantJ2.Text = Convert.ToString(cantJ2);
            }
            logicaJuego();
        }
        

        private void btnParar_Click(object sender, EventArgs e)
        {
            pedir = 2;
            parar++;
            logicaJuego();

        }
    }
}
