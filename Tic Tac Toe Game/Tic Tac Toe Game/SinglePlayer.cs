using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class SinglePlayer : Form
    {
        Menu menu = new Menu();

        public SinglePlayer()
        {
            InitializeComponent();
        }

        public bool AllButtons() 
        {
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                return true;
            else return false;
        }

        public void Machine() 
        {
            Random random = new Random();
            int AIPos = random.Next(1, 9);
            bool AiTurn = false;

            while (!AiTurn && !AllButtons())
            {
                if (AIPos == 1)
                {

                    if (button1.Enabled)
                    {
                        button1.Enabled = false;
                        button1.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }

                else if (AIPos == 2)
                {
                    if (button2.Enabled)
                    {
                        button2.Enabled = false;
                        button2.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }

                else if (AIPos == 3)
                {
                    if (button3.Enabled)
                    {
                        button3.Enabled = false;
                        button3.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
                else if (AIPos == 4)
                {
                    if (button4.Enabled)
                    {
                        button4.Enabled = false;
                        button4.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
                else if (AIPos == 5)
                {
                    if (button5.Enabled)
                    {
                        button5.Enabled = false;
                        button5.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
                else if (AIPos == 6)
                {
                    if (button6.Enabled)
                    {
                        button6.Enabled = false;
                        button6.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
                else if (AIPos == 7)
                {
                    if (button7.Enabled)
                    {
                        button7.Enabled = false;
                        button7.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
                else if (AIPos == 8)
                {
                    if (button8.Enabled)
                    {
                        button8.Enabled = false;
                        button8.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
                else if (AIPos == 9)
                {
                    if (button9.Enabled)
                    {
                        button9.Enabled = false;
                        button9.Text = "O";
                        AiTurn = true;
                    }
                    else AIPos = random.Next(1, 9);
                }
            }
        }

        public bool StateCheck() 
        {
            
            bool Horizontal1 = button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "";
            bool Horizontal2 = button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "";
            bool Horizontal3 = button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "";
            
            bool Vertical1 = button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "";
            bool Vertical2 = button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "";
            bool Vertical3 = button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "";
            
            bool Diagonal1 = button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "";
            bool Diagonal2 = button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "";
            
            bool Tie = button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "";




            if (Horizontal1)
            {
                if (button1.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();


                }
                else if (button1.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Horizontal2)
            {
                if (button4.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                else if (button4.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Horizontal3)
            {
                if (button7.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                else if (button7.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Vertical1)
            {
                if (button1.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                else if (button1.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Vertical2)
            {
                if (button2.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    ;

                }
                else if (button2.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Vertical3)
            {
                if (button3.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                else if (button3.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Diagonal1)
            {
                if (button9.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                else if (button9.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Diagonal2)
            {
                if (button7.Text == "X")
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                else if (button7.Text == "O")
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    

                }
                return true;
            }

            else if (Tie)
            {
                label1.Text = "Tie!";
                MessageBox.Show(label1.Text);
                this.Close();
                

                return true;
            }
            return false;
        }

        

        private void SinglePlayer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "X";
            button1.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = "X";
            button2.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = "X";
            button3.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = "X";
            button4.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Text = "X";
            button5.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Text = "X";
            button6.Enabled = false;
            StateCheck();
            Machine();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Text = "X";
            button7.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.Text = "X";
            button8.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Text = "X";
            button9.Enabled = false;
            StateCheck();
            Machine();
            StateCheck();
        }
    }
}