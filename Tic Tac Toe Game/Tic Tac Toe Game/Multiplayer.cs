using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Tic_Tac_Toe_Game
{
    public partial class Multiplayer : Form
    {
        public Multiplayer(bool isHost, string ip = null)
        {
            InitializeComponent();
            Packet.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if(isHost)
            {
                Jugador1 = 'X';
                Jugador2 = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 8888);
                server.Start();
                socket = server.AcceptSocket();
            }
            else
            {
                Jugador1 = 'O';
                Jugador2 = 'X';
                try
                {
                    client = new TcpClient(ip, 8888);
                    socket = client.Client;
                    Packet.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CheckState())
                return;
            WaitforMovement();
            label1.Text = "Opponent is playing!";
            Movement();
            label1.Text = "Your Turn to play!!";
            if (!CheckState())
                PlayNow();
        }

        private char Jugador1;
        private char Jugador2;
        private Socket socket;
        private BackgroundWorker Packet = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        private bool CheckState()
        {
            //Horizontals
            if(button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                if(button1.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (button4.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (button7.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            //Verticals
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                if (button1.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button2.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {
                if (button3.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button1.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!"); ;
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (button3.Text[0] == Jugador1)
                {
                    label1.Text = "Congratulations! You won!";
                    MessageBox.Show("Congratulations! You won!");
                    this.Close();
                }
                else
                {
                    label1.Text = "Better luck, next time...";
                    MessageBox.Show("Better luck, next time...");
                    this.Close();
                }
                return true;
            }

            //Draw
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Tie!";
                MessageBox.Show("Tie!");
                this.Close();
                return true;
            }
            return false;
        }
        private void WaitforMovement()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void PlayNow()
        {
            if (button1.Text == "")
                button1.Enabled = true;
            if (button2.Text == "")
                button2.Enabled = true;
            if (button3.Text == "")
                button3.Enabled = true;
            if (button4.Text == "")
                button4.Enabled = true;
            if (button5.Text == "")
                button5.Enabled = true;
            if (button6.Text == "")
                button6.Enabled = true;
            if (button7.Text == "")
                button7.Enabled = true;
            if (button8.Text == "")
                button8.Enabled = true;
            if (button9.Text == "")
                button9.Enabled = true;
        }

        private void Movement()
        {
            byte[] Data = new byte[1];
            socket.Receive(Data);
            if (Data[0] == 1)
                button1.Text = Jugador2.ToString();
            if (Data[0] == 2)
                button2.Text = Jugador2.ToString();
            if (Data[0] == 3)
                button3.Text = Jugador2.ToString();
            if (Data[0] == 4)
                button4.Text = Jugador2.ToString();
            if (Data[0] == 5)
                button5.Text = Jugador2.ToString();
            if (Data[0] == 6)
                button6.Text = Jugador2.ToString();
            if (Data[0] == 7)
                button7.Text = Jugador2.ToString();
            if (Data[0] == 8)
                button8.Text = Jugador2.ToString();
            if (Data[0] == 9)
                button9.Text = Jugador2.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            socket.Send(num);
            button1.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            socket.Send(num);
            button2.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            socket.Send(num);
            button3.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            socket.Send(num);
            button4.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            socket.Send(num);
            button5.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            socket.Send(num);
            button6.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            socket.Send(num);
            button7.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            socket.Send(num);
            button8.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            socket.Send(num);
            button9.Text = Jugador1.ToString();
            Packet.RunWorkerAsync();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Packet.WorkerSupportsCancellation = true;
            Packet.CancelAsync();
            if (server != null)
                server.Stop();
        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {

        }
    }
}
