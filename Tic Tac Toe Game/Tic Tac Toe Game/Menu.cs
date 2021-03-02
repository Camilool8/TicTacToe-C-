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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinglePlayer Single = new SinglePlayer();
            Single.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect Multi = new Connect();
            Multi.Show();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
