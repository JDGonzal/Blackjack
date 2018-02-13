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

        int pedir,parar=0,cantJ1,cantJ2;


        public frmBlackJackMultiplayer()
        {
            InitializeComponent();

            if (pedir > 6)
            {
                btnParar.Enabled = false;
            }

        }

        private void frmBlackJack_Load(object sender, EventArgs e)
        {
            
        }

       
        private void logicaJuego()
        {
            if ((cantJ1 < 21) ||(cantJ2<21))
            {

            }


        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            int[] cartasInicio = new int[4];
            pedir = 1;

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
                    lblCarta2J2.Visible = true;
                }
            }
            btnRepartir.Enabled=false;
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
                    cartasRepartir = 11;
                    lblCarta3J1.Text = "A";
                }
                lblCarta3J1.Visible = true;
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
            }
            else if (pedir == 2)
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
            }
            else if (pedir == 4)
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
            }
            else if (pedir == 6)
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
            }
        }
        

        private void btnParar_Click(object sender, EventArgs e)
        {
            pedir = 0;
            
        }
    }
}
