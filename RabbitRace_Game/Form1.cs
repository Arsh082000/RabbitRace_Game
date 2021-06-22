using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitRace_Game
{
    public partial class Form1 : Form
    {
        //crete the instnce of the logicl clss 
        Logic logic = new Logic();

        int rbit = 0;
        
        Logic Jugraj = new Logic();

        Logic Simon = new Logic();
        
        Logic Harmen = new Logic();


        public Form1()
        {
            InitializeComponent();
            // here we need to get the amount 
            logic.genrateAmount(cbAAmount);
            Jugraj.blnce = 50;
            Simon.blnce = 50;
            Harmen.blnce = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // var value for players is changing according player selected

        private void jugraj_bettor_CheckedChanged(object sender, EventArgs e)
        {
            if (jugraj_bettor.Checked==true) {
                Jugraj.plyer = "Jugraj";
            }
        }

        private void simon_bettor_CheckedChanged(object sender, EventArgs e)
        {
            if (simon_bettor.Checked == true) {
                Simon.plyer = "Simon";
            }
        }

        private void Harmen_bettor_CheckedChanged(object sender, EventArgs e)
        {
            if (Harmen_bettor.Checked == true) {
                Harmen.plyer = "Harmen";
            }
        }

        // var value changing according to the rabbit selection

        private void rabbit1_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit1_selec.Checked==true) {
                rbit = 1;
            }
        }

        private void rabbit2_selc_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit2_selc.Checked == true)
            {
                rbit = 2;
            }
        }

        private void rabbit3_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit3_selec.Checked == true)
            {
                rbit = 3;
            }
        }

        private void rabbit4_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit4_selec.Checked == true)
            {
                rbit = 4;
            }
        }

        private void btnLockBet_Click(object sender, EventArgs e)
        {
            if (Jugraj.plyer == "Jugraj" && Jugraj.blnce >= Convert.ToInt32(cbAAmount.SelectedItem.ToString()) && Convert.ToInt32(cbAAmount.SelectedItem.ToString())>0)
            {
                Jugraj.rbit = rbit;
                Jugraj.bet = Convert.ToInt32(cbAAmount.SelectedItem.ToString());
                Jugraj_label.Text = "Jugraj select "+rbit+ " with value "+ cbAAmount.SelectedItem.ToString();
                btnRce.Enabled = true;
                reset();
            }
            else if (Simon.plyer == "Simon" && Simon.blnce >= Convert.ToInt32(cbAAmount.SelectedItem.ToString()) && Convert.ToInt32(cbAAmount.SelectedItem.ToString()) > 0)
            {
                Simon.rbit = rbit;
                Simon.bet = Convert.ToInt32(cbAAmount.SelectedItem.ToString());
                simon_label.Text = "Simon select " + rbit + " with value " + cbAAmount.SelectedItem.ToString();
                btnRce.Enabled = true;
                reset();
            }
            else if (Harmen.plyer == "Harmen" && Harmen.blnce >= Convert.ToInt32(cbAAmount.SelectedItem.ToString()) && Convert.ToInt32(cbAAmount.SelectedItem.ToString()) > 0)
            {
                Harmen.rbit = rbit;
                Harmen.bet = Convert.ToInt32(cbAAmount.SelectedItem.ToString());
                label_harmen.Text = "Harmen select " + rbit + " with value " + cbAAmount.SelectedItem.ToString();
                btnRce.Enabled = true;
                reset();
            }
            else {
                MessageBox.Show("Here you need to fulfill the requirements ");
            }
            rbit = 0;
            cbAAmount.Text = "";
        }
        public void result(int win) {
            if (Jugraj.plyer == "Jugraj") {
                if (Jugraj.rbit == win)
                {
                    Jugraj.blnce = Jugraj.blnce + Jugraj.bet;
                }
                else {
                    Jugraj.blnce = Jugraj.blnce - Jugraj.bet;
                }
                Jugraj_label.Text = "Jugraj has $"+Jugraj.blnce+ " amount for Bet ";
            }

            if (Simon.plyer == "Simon")
            {
                if (Simon.rbit == win)
                {
                    Simon.blnce = Simon.blnce + Simon.bet;
                }
                else
                {
                    Simon.blnce = Simon.blnce - Simon.bet;
                }
                simon_label.Text = "Simon has $" + Simon.blnce + " amount for Bet ";
            }
            if (Harmen.plyer == "Harmen")
            {
                if (Harmen.rbit == win)
                {
                    Harmen.blnce = Harmen.blnce + Harmen.bet;
                }
                else
                {
                    Harmen.blnce = Harmen.blnce - Harmen.bet;
                }
                label_harmen.Text = "Harmen has $" + Harmen.blnce + " amount for Bet ";
            }
            reset();
            pictureBox1.Left = 395;
            pictureBox2.Left = 395;
            pictureBox3.Left = 395;
            pictureBox4.Left = 395;
            
            Jugraj.plyer = "";
            Jugraj.bet = 0;
            Jugraj.rbit = 0;

            Simon.plyer = "";
            Simon.bet = 0;
            Simon.rbit = 0;

            Harmen.plyer = "";
            Harmen.bet = 0;
            Harmen.rbit = 0;


        }

        public void reset() {
            jugraj_bettor.Checked = false;
            simon_bettor.Checked = false;
            Harmen_bettor.Checked = false;
            rabbit1_selec.Checked = false;
            rabbit2_selc.Checked = false;
            rabbit3_selec.Checked = false;
            rabbit4_selec.Checked = false;
            rbit = 0;

        }

        // timer fuction start when clicked on button

        private void btnRce_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //timer function

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += logic.genrte();
            pictureBox2.Left += Jugraj.genrte2();
            pictureBox3.Left += Simon.genrte3();
            pictureBox4.Left += Harmen.genrte4();

            if (pictureBox1.Left>950) {
                timer1.Stop();
                MessageBox.Show("First one won the race ");
                result(1);
            }
            if (pictureBox2.Left > 950)
            {
                timer1.Stop();
                MessageBox.Show("Second one won the race ");
                result(2);
            }
            if (pictureBox3.Left > 950)
            {
                timer1.Stop();
                MessageBox.Show("Third one won the race ");
                result(3);
            }

            if (pictureBox4.Left > 950)
            {
                timer1.Stop();
                MessageBox.Show("Fourth one won the race ");
                result(4);
            }
        }

        //exit game
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
