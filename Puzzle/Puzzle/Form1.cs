using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Clicks = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            NuevaPartida();
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn12, Btn16);
            CambiarBoton(Btn15, Btn16);
        }        

        private void Btn15_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn11, Btn15);
            CambiarBoton(Btn14, Btn15);
            CambiarBoton(Btn16, Btn15);
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn10, Btn14);
            CambiarBoton(Btn13, Btn14);
            CambiarBoton(Btn15, Btn14);
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn9, Btn13);
            CambiarBoton(Btn14, Btn13);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn8, Btn12);
            CambiarBoton(Btn11, Btn12);
            CambiarBoton(Btn16, Btn12);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn7, Btn11);
            CambiarBoton(Btn10, Btn11);
            CambiarBoton(Btn12, Btn11);
            CambiarBoton(Btn15, Btn11);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn6, Btn10);
            CambiarBoton(Btn9, Btn10);
            CambiarBoton(Btn11, Btn10);
            CambiarBoton(Btn14, Btn10);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn5, Btn9);
            CambiarBoton(Btn10, Btn9);
            CambiarBoton(Btn13, Btn9);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn4, Btn8);
            CambiarBoton(Btn7, Btn8);
            CambiarBoton(Btn12, Btn8);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn3, Btn7);
            CambiarBoton(Btn6, Btn7);
            CambiarBoton(Btn8, Btn7);
            CambiarBoton(Btn11, Btn7);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn2, Btn6);
            CambiarBoton(Btn5, Btn6);
            CambiarBoton(Btn7, Btn6);
            CambiarBoton(Btn10, Btn6);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn1, Btn5);
            CambiarBoton(Btn6, Btn5);
            CambiarBoton(Btn9, Btn5);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn3, Btn4);
            CambiarBoton(Btn5, Btn4);
            CambiarBoton(Btn8, Btn4);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn2, Btn3);
            CambiarBoton(Btn4, Btn3);
            CambiarBoton(Btn7, Btn3);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn1, Btn2);
            CambiarBoton(Btn3, Btn2);
            CambiarBoton(Btn6, Btn2);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            CambiarBoton(Btn2, Btn1);
            CambiarBoton(Btn5, Btn1);            
        }

        public void NuevaPartida()
        {
            var random = new Random();
            var Numeros = Enumerable.Range(1, 15).OrderBy(x => random.Next()).ToList();
            var numerosTS = Numeros.Select(x => x.ToString()).ToList();            
            ReiniciarContador();
            ReiniciarTimer();

            Btn1.Text = numerosTS[0].ToString();
            Btn2.Text = numerosTS[1].ToString();
            Btn3.Text = numerosTS[2].ToString();
            Btn4.Text = numerosTS[3].ToString();
            Btn5.Text = numerosTS[4].ToString();
            Btn6.Text = numerosTS[5].ToString();
            Btn7.Text = numerosTS[6].ToString();
            Btn8.Text = numerosTS[7].ToString();
            Btn9.Text = numerosTS[8].ToString();
            Btn10.Text = numerosTS[9].ToString();
            Btn11.Text = numerosTS[10].ToString();
            Btn12.Text = numerosTS[11].ToString();
            Btn13.Text = numerosTS[12].ToString();
            Btn14.Text = numerosTS[13].ToString();
            Btn15.Text = numerosTS[14].ToString();
            Btn16.Text = "";
        }

        private void BtnNuevaPartida_Click(object sender, EventArgs e)
        {
            NuevaPartida();
        }

        public void ReiniciarContador()
        {
            LblContadorClicks.Text = "0";
        }

        public void ReiniciarTimer()
        {
            LblTiempo.Text = "00:00:00";
            Horas = 0;
            Minutos = 0;
            Segundos = 0;
            PararTiempo();
        }

        public void Comprobar()
        {
            if (Btn1.Text == "1" && Btn2.Text == "2" && Btn3.Text == "3" && Btn4.Text == "4" && Btn5.Text == "5" && Btn6.Text == "6" && Btn7.Text == "7" && Btn8.Text == "8" && Btn9.Text == "9" && Btn10.Text == "10" && Btn11.Text == "11" && Btn12.Text == "12" && Btn13.Text == "13" && Btn14.Text == "14" && Btn15.Text == "15" && Btn16.Text == "")
            {

                MessageBox.Show("¡Has ganado!\n" +
                    "¡Su tiempo es: "+ LblTiempo + "!\n" +
                    "¡Realizaste " + Clicks + " movimentos!");
            }
        }

        public void ContarClicks()
        {
            Clicks++;
            LblContadorClicks.Text = "Clicks: " + Clicks.ToString();
        }

        public void CambiarBoton(Button btnVacio, Button btnLleno)
        {
            if (btnVacio.Text == "")
            {
                btnVacio.Text = btnLleno.Text;
                btnLleno.Text = string.Empty;
                ContarClicks();
                Comprobar();
                if (Segundos == 0)
                {
                    IniciarTiempo();
                }
                return;
            }            
        }

        double Horas = 0;
        double Minutos = 0;
        double Segundos = 0;
        private void TimerContador_Tick(object sender, EventArgs e)
        {            
            Segundos++;
            LblTiempo.Text = string.Format("{0:00}:{1:00}:{2:00}", Horas, Minutos, Segundos);
            if (Segundos == 59)
            {
                Segundos = 00;
                Minutos++;
                LblTiempo.Text = string.Format("{0:00}:{1:00}:{2:00}", Horas, Minutos, Segundos);
                if (Minutos == 59)
                {
                    Minutos = 00;
                    Horas++;
                    LblTiempo.Text = string.Format("{0:00}:{1:00}:{2:00}", Horas, Minutos, Segundos);
                }
            }
        }

        private void BtnReanudar_Click(object sender, EventArgs e)
        {
            IniciarTiempo();
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            PararTiempo();
        }
        public void IniciarTiempo()
        {
            TimerContador.Start();
        }

        public void PararTiempo()
        {
            TimerContador.Stop();
        }
    }
}