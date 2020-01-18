using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EinsteinGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.panel1.Controls)
            {
                c.Enabled = false;
            }
        }

        public void corCasa()
        {
            //Cor da Primeira Casa

            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAmarela.png";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAzul.png";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\CasaBranca.png";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVerde.png";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVermelha.png";
            }


            //Cor da Segunda Casa

            if (comboBox2.SelectedIndex == 0)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAmarela.png";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAzul.png";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\CasaBranca.png";
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVerde.png";
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVermelha.png";
            }

            //Cor da Terceira Casa

            if (comboBox3.SelectedIndex == 0)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAmarela.png";
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAzul.png";
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\CasaBranca.png";
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVerde.png";
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVermelha.png";
            }

            //Cor da Quarta Casa

            if (comboBox4.SelectedIndex == 0)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAmarela.png";
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAzul.png";
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\CasaBranca.png";
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVerde.png";
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVermelha.png";
            }

            //Cor da Quinta Casa

            if (comboBox5.SelectedIndex == 0)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAmarela.png";
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaAzul.png";
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\CasaBranca.png";
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVerde.png";
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\img\\casaVermelha.png";
            }
        }

        public void isValida(ComboBox comboBox)
        {

            //O mano de F. Morato vive na primeira casa.
            foreach (ComboBox c in this.panel2.Controls)
            {          
                

                if (c.SelectedIndex == 3 && c.Name == "comboBox6")
                {
                    checkBox1.Checked = true;

                }
                else if (c.SelectedIndex != 3 && c.Name == "comboBox6")
                {
                    checkBox1.Checked = false;
                }
            }

            //O mano de C. Redondo vive na casa Vermelha.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 2) && (c.Name == "comboBox6"))
                {
                    foreach(ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox1"))
                        {
                            checkBox2.Checked = true;
                        }                        
                    }
                    break;
                }
                else if ((c.SelectedIndex == 2) && (c.Name == "comboBox7"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox2"))
                        {
                            checkBox2.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 2) && (c.Name == "comboBox8"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox3"))
                        {
                            checkBox2.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 2) && (c.Name == "comboBox9"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox4"))
                        {
                            checkBox2.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 2) && (c.Name == "comboBox10"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox5"))
                        {
                            checkBox2.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox2.Checked = false;
                }

            }


            //O cara do Brás tem um cachorro.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 0) && (c.Name == "comboBox21"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox6"))
                        {
                            checkBox3.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox22"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox7"))
                        {
                            checkBox3.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox23"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox8"))
                        {
                            checkBox3.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox24"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox9"))
                        {
                            checkBox3.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox25"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox10"))
                        {
                            checkBox3.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox3.Checked = false;
                }
            }

            //O mano da C. Tiradentes bebe Xereta.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 1) && (c.Name == "comboBox6"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox11"))
                        {
                            checkBox4.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox7"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox12"))
                        {
                            checkBox4.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox8"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox13"))
                        {
                            checkBox4.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox9"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox14"))
                        {
                            checkBox4.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox10"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox15"))
                        {
                            checkBox4.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox4.Checked = false;
                }
            }

            //O homem que vive na casa Verde bebe Ibituruna.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 1) && (c.Name == "comboBox11"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox1"))
                        {
                            checkBox6.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox12"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox2"))
                        {
                            checkBox6.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox13"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox3"))
                        {
                            checkBox6.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox14"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox4"))
                        {
                            checkBox6.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox15"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox5"))
                        {
                            checkBox6.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox6.Checked = false;
                }

            }

            //O homem que assiste simpsons cria Pássaros.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 3) && (c.Name == "comboBox16"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox21"))
                        {
                            checkBox7.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox17"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox22"))
                        {
                            checkBox7.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox18"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox23"))
                        {
                            checkBox7.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox19"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox24"))
                        {
                            checkBox7.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox20"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 3) && (d.Name == "comboBox25"))
                        {
                            checkBox7.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox7.Checked = false;
                }

            }

            //O homem que vive na casa Amarela  assiste MD. House.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 0) && (c.Name == "comboBox1"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox16"))
                        {
                            checkBox8.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox2"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox17"))
                        {
                            checkBox8.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox3"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox18"))
                        {
                            checkBox8.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox4"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox19"))
                        {
                            checkBox8.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox5"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox20"))
                        {
                            checkBox8.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox8.Checked = false;
                }

            }

            //A casa Verde fica do lado esquerdo da casa Branca.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 3) && (c.Name == "comboBox1"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox2"))
                        {
                            checkBox5.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox2"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox3"))
                        {
                            checkBox5.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox3"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox4"))
                        {
                            checkBox5.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox4"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox5"))
                        {
                            checkBox5.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox5.Checked = false;
                }

            }

            //O homem que vive na casa do meio bebe Dolly-Cola.
            foreach (ComboBox c in this.panel2.Controls)
            {


                if (c.SelectedIndex == 4 && c.Name == "comboBox13")
                {
                    checkBox9.Checked = true;

                }
                else if (c.SelectedIndex != 4 && c.Name == "comboBox13")
                {
                    checkBox9.Checked = false;
                }
            }

            //Quem assiste Breaking Bad vive ao lado do que tem Gatos.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 0) && (c.Name == "comboBox16"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox22"))
                        {
                            checkBox10.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox17"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox21") || (d.SelectedIndex == 2) && (d.Name == "comboBox23"))
                        {
                            checkBox10.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox18"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox22") || (d.SelectedIndex == 2) && (d.Name == "comboBox24"))
                        {
                            checkBox10.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox19"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox23") || (d.SelectedIndex == 2) && (d.Name == "comboBox25"))
                        {
                            checkBox10.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox20"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox24"))
                        {
                            checkBox10.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox10.Checked = false;
                }

            }

            //Quem cria Cavalos vive ao lado do que assiste House.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 1) && (c.Name == "comboBox21"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox17"))
                        {
                            checkBox14.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox22"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox16") || (d.SelectedIndex == 2) && (d.Name == "comboBox18"))
                        {
                            checkBox14.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox23"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox17") || (d.SelectedIndex == 2) && (d.Name == "comboBox19"))
                        {
                            checkBox14.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox24"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox18") || (d.SelectedIndex == 2) && (d.Name == "comboBox20"))
                        {
                            checkBox14.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox25"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox19"))
                        {
                            checkBox14.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox14.Checked = false;
                }

            }

            //O homem que assiste Walking Dead bebe X-Tapa.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 1) && (c.Name == "comboBox16"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox11"))
                        {
                            checkBox11.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox17"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox12"))
                        {
                            checkBox11.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox18"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox13"))
                        {
                            checkBox11.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox19"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox14"))
                        {
                            checkBox11.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 1) && (c.Name == "comboBox20"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 2) && (d.Name == "comboBox15"))
                        {
                            checkBox11.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox11.Checked = false;
                }
            }

            //O Homem de Guaianazes assiste Chaves.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 0) && (c.Name == "comboBox6"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox16"))
                        {
                            checkBox12.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox7"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox17"))
                        {
                            checkBox12.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox8"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox18"))
                        {
                            checkBox12.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox9"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox19"))
                        {
                            checkBox12.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox10"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 4) && (d.Name == "comboBox20"))
                        {
                            checkBox12.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox12.Checked = false;
                }

            }

            //O mano de F. Morato vive ao lado da casa Azul.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 3) && (c.Name == "comboBox6"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 1) && (d.Name == "comboBox2"))
                        {
                            checkBox13.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox7"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 1) && (d.Name == "comboBox1") || (d.SelectedIndex == 1) && (d.Name == "comboBox3"))
                        {
                            checkBox13.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox8"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 1) && (d.Name == "comboBox2") || (d.SelectedIndex == 1) && (d.Name == "comboBox4"))
                        {
                            checkBox13.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox9"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 1) && (d.Name == "comboBox3") || (d.SelectedIndex == 1) && (d.Name == "comboBox5"))
                        {
                            checkBox13.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 3) && (c.Name == "comboBox10"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 1) && (d.Name == "comboBox4"))
                        {
                            checkBox13.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox13.Checked = false;
                }

            }

            //O homem que assite Breaking Bad é vizinho do que bebe Trevinho.
            foreach (ComboBox c in this.panel2.Controls)
            {
                if ((c.SelectedIndex == 0) && (c.Name == "comboBox16"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 0) && (d.Name == "comboBox12"))
                        {
                            checkBox15.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox17"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 0) && (d.Name == "comboBox11") || (d.SelectedIndex == 0) && (d.Name == "comboBox13"))
                        {
                            checkBox15.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox18"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 0) && (d.Name == "comboBox12") || (d.SelectedIndex == 0) && (d.Name == "comboBox14"))
                        {
                            checkBox15.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox19"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 0) && (d.Name == "comboBox13") || (d.SelectedIndex == 0) && (d.Name == "comboBox15"))
                        {
                            checkBox15.Checked = true;
                        }
                    }
                    break;
                }
                else if ((c.SelectedIndex == 0) && (c.Name == "comboBox20"))
                {
                    foreach (ComboBox d in this.panel2.Controls)
                    {
                        if ((d.SelectedIndex == 0) && (d.Name == "comboBox14"))
                        {
                            checkBox15.Checked = true;
                        }
                    }
                    break;
                }
                else
                {
                    checkBox15.Checked = false;
                }

            }

        }

        



        public void fimGame()
        {
            Boolean fim = true;

            if (!checkBox1.Checked == true)
            {
                fim = false;
            }
            if (!checkBox2.Checked == true)
            {
                fim = false;
            }
            if (!checkBox3.Checked == true)
            {
                fim = false;
            }
            if (!checkBox4.Checked == true)
            {
                fim = false;
            }
            if (!checkBox5.Checked == true)
            {
                fim = false;
            }
            if (!checkBox6.Checked == true)
            {
                fim = false;
            }
            if (!checkBox7.Checked == true)
            {
                fim = false;
            }
            if (!checkBox8.Checked == true)
            {
                fim = false;
            }
            if (!checkBox9.Checked == true)
            {
                fim = false;
            }
            if (!checkBox10.Checked == true)
            {
                fim = false;
            }
            if (!checkBox11.Checked == true)
            {
                fim = false;
            }
            if (!checkBox12.Checked == true)
            {
                fim = false;
            }
            if (!checkBox13.Checked == true)
            {
                fim = false;
            }
            if (!checkBox14.Checked == true)
            {
                fim = false;
            }
            if (!checkBox15.Checked == true)
            {
                fim = false;
            }
            


            if (fim == true)
            {
                MessageBox.Show("Parabéns! Você conseguiu terminar o teste!!!");
            }
           
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox1);
            fimGame();
            corCasa();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox2);
            fimGame();
            corCasa();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox3);
            fimGame();
            corCasa();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox4);
            fimGame();
            corCasa();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox5);
            fimGame();
            corCasa();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox6);
            fimGame();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox7);
            fimGame();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox8);
            fimGame();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox9);
            fimGame();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox10);
            fimGame();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox11);
            fimGame();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox12);
            fimGame();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox13);
            fimGame();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox14);
            fimGame();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox15);
            fimGame();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox16);
            fimGame();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox17);
            fimGame();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox18);
            fimGame();
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox19);
            fimGame();
        }
                
        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox20);
            fimGame();
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox21);
            fimGame();
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox22);
            fimGame();
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox23);
            fimGame();
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox24);
            fimGame();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            isValida(comboBox: comboBox25);
            fimGame();
        }


        
    }
}
