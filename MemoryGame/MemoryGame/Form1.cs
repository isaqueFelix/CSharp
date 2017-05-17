using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private int pontuacao = 0, imagem = 0;
        private List<String> imagens = new List<String>();
        private PictureBox anterior, atual;
        private int clicks = 0, acertos = 0;
        private List<String> tempImagens = new List<string>();

        public Form1()
        {
            InitializeComponent();
            iniciarJogo();
        }

        public delegate void EventHandler(Object sender, EventArgs e);

        private void iniciarJogo()
        {
            criarListaImagens();
            embaralhar();
            foreach (Control item in this.Controls)
            {
                if(item is PictureBox)
                {
                    item.Cursor = Cursors.Hand;
                    item.MouseHover += delegate(Object sd, EventArgs ea)
                    {
                        item.Size = new System.Drawing.Size(90, 69);
                    };
                    item.MouseLeave += delegate (Object sd, EventArgs ea)
                    {
                        item.Size = new System.Drawing.Size(85, 63);
                    };
                }
            }
        }
   
        private void criarListaImagens()
        {
            imagens.Add("../../img/aviao.png");
            imagens.Add("../../img/bandeira.jpg");
            imagens.Add("../../img/bola.png");
            imagens.Add("../../img/bone.jpg");
            imagens.Add("../../img/boneca.jpg");
            imagens.Add("../../img/cachorro.jpg");
            imagens.Add("../../img/calculadora.png");
            imagens.Add("../../img/carro.png");
            imagens.Add("../../img/casa.jpg");
            imagens.Add("../../img/impressora.png");
            imagens.Add("../../img/moeda.png");
            imagens.Add("../../img/peteca.jpg");
            imagens.Add("../../img/aviao.png");
            imagens.Add("../../img/bandeira.jpg");
            imagens.Add("../../img/bola.png");
            imagens.Add("../../img/bone.jpg");
            imagens.Add("../../img/boneca.jpg");
            imagens.Add("../../img/cachorro.jpg");
            imagens.Add("../../img/calculadora.png");
            imagens.Add("../../img/carro.png");
            imagens.Add("../../img/casa.jpg");
            imagens.Add("../../img/impressora.png");
            imagens.Add("../../img/moeda.png");
            imagens.Add("../../img/peteca.jpg");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = tempImagens[0];
            validaResultado(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = tempImagens[1];
            validaResultado(pictureBox2);
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = tempImagens[2];
            validaResultado(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = tempImagens[3];
            validaResultado(pictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = tempImagens[4];
            validaResultado(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = tempImagens[5];
            validaResultado(pictureBox6);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.ImageLocation = tempImagens[6];
            validaResultado(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = tempImagens[7];
            validaResultado(pictureBox8);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.ImageLocation = tempImagens[8];
            validaResultado(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.ImageLocation = tempImagens[9];
            validaResultado(pictureBox10);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.ImageLocation = tempImagens[10];
            validaResultado(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.ImageLocation = tempImagens[11];
            validaResultado(pictureBox12);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.ImageLocation = tempImagens[12];
            validaResultado(pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.ImageLocation = tempImagens[13];
            validaResultado(pictureBox14);
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.ImageLocation = tempImagens[14];
            validaResultado(pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.ImageLocation = tempImagens[15];
            validaResultado(pictureBox16);
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.ImageLocation = tempImagens[16];
            validaResultado(pictureBox17);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.ImageLocation = tempImagens[17];
            validaResultado(pictureBox18);
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.ImageLocation = tempImagens[18];
            validaResultado(pictureBox19);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.ImageLocation = tempImagens[19];
            validaResultado(pictureBox20);
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.ImageLocation = tempImagens[20];
            validaResultado(pictureBox21);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.ImageLocation = tempImagens[21];
            validaResultado(pictureBox22);
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.ImageLocation = tempImagens[22];
            validaResultado(pictureBox23);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.ImageLocation = tempImagens[23];
            validaResultado(pictureBox24);
        }

        private void validaResultado(PictureBox pb)
        {
            if (clicks == 0)
            {
                clicks++;
                anterior = pb;
                timer1.Stop();
            } else if (clicks == 1)
            {
                if (eIgual(pb))
                {
                    acertos++;
                    pontuacao += 10;
                    lblPontuacao.Text = String.Format("" + pontuacao);
                    atual.Enabled = false;
                    anterior.Enabled = false;
                    if(acertos == 12)
                    {
                        MessageBox.Show("Fim de jogo\n" + "Pontuação: " + lblPontuacao.Text );
                        this.Close();
                    }
                }else
                {
                    pontuacao -= 2;
                    lblPontuacao.Text = String.Format("" + pontuacao);
                    timer1.Start();
                }
                
                clicks = 0;
            }
        }

        private Boolean eIgual(PictureBox pb)
        {
            atual = pb;
            return anterior.ImageLocation.Equals(pb.ImageLocation);
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            duplaErrada();
        }

        private void duplaErrada()
        {
            atual.ImageLocation = "../../img/arroba.png";
            anterior.ImageLocation = "../../img/arroba.png";
        }

        private void embaralhar()
        {
            Random rd = new Random();
            int random = rd.Next(0, 24);
            while (imagem < 24)
            {
                if(random > 23)
                {
                    random = 0;
                } else
                {
                    tempImagens.Add(imagens[random]);
                    random++;
                    imagem++;
                }
            }
        }
    }
}
