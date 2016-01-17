using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleClicker2
{
    public partial class Form1 : Form
    {
        public double gold = 0;
        public double goldPerClick = 1;
        public double upgradeClickCost = 15;

        //auto clicker variables
        public double autoClickerAmt = 30;
        public bool autoClickerOn = false;
        public double autoClickersPurch = 0;

        // multiplier1
        public double mulit1Cost = 50;

        // Buy auto-generator stuff
        public double _49erCost = 100;
        public double _49erQTY = 0;
        public double _49erGeneratedAmt = 10;

        public Form1()
        {
            InitializeComponent();
            btnUpgradeClick.Enabled = false;
            btnAutoClicker.Enabled = false;
            btnMulti1.Enabled = false;
        }

        public void UpdateForm()
        {
            // update the label that shows the player how much gold they have
            lblGoldAmt.Text = "Gold: " + gold;
            // lblGoldAmt.Text = String.Format("Gold: {0:0,0}", gold);
            lblGoldPerClick.Text = "Gold per click: " + goldPerClick;
            lblCostToUpgrade.Text = "Cost to Upgrade: " + upgradeClickCost;
            lblMulti1.Text = "Cost to buy: " + mulit1Cost;
            lblAutoCost.Text = "Cost of Auto Clicker: " + autoClickerAmt;
            lbl49erAmt.Text = "You have: " + _49erQTY;
            lbl49erCost.Text = "Cost of 49'er: " + _49erCost;
        }

        private void btnGetGold_Click(object sender, EventArgs e)
        {
            // increase the amount of gold player has when they click on the Get Gold button
            gold += goldPerClick;

            // run the UpdateForm to show that the user has more gold
            UpdateForm();
        }

        private void btnUpgradeClick_Click(object sender, EventArgs e)
        {
            // Upgrade the clicker amount per click
            if(gold >= upgradeClickCost){
                goldPerClick += 1;
                gold = gold - upgradeClickCost;
                upgradeClickCost = Math.Floor(10 * Math.Pow(1.5, goldPerClick));
                UpdateForm();
            } else {
                MessageBox.Show("You do not have enough gold", "Sorry, but...");
            }
        }

        private void timerAutoRefresh_Tick(object sender, EventArgs e)
        {
            UpdateForm();
            if (autoClickerOn == true)
            {
                int i = 1;
                while (i <= autoClickersPurch)
                {
                    btnGetGold.PerformClick();
                    i++;
                }
            }
        }

        private void btnAutoClicker_Click(object sender, EventArgs e)
        {
            if (gold >= autoClickerAmt)
            {
                autoClickerOn = true;
                gold -= autoClickerAmt;
                autoClickerAmt = Math.Floor(30 * Math.Pow(1.5, goldPerClick));
                autoClickersPurch++;
                UpdateForm();
            }
        }

        private void btnMulti1_Click(object sender, EventArgs e)
        {
            if (gold >= mulit1Cost)
            {
                gold -= mulit1Cost;
                goldPerClick = Math.Ceiling(goldPerClick * 1.10);
                mulit1Cost = Math.Floor(30 * Math.Pow(1.9, goldPerClick));
                UpdateForm();
            }
        }

        private void timerUpgradeCheck_Tick(object sender, EventArgs e)
        {
            if (gold >= upgradeClickCost)
            {
                btnUpgradeClick.Enabled = true;
            }
            else { btnUpgradeClick.Enabled = false; }

            if (gold >= autoClickerAmt)
            {
                btnAutoClicker.Enabled = true;
            }
            else { btnAutoClicker.Enabled = false; }

            if (gold >= mulit1Cost)
            {
                btnMulti1.Enabled = true;
            }
            else { btnMulti1.Enabled = false; }

            if (gold >= _49erCost)
            {
                btnBuy49er.Enabled = true;
                pic49er.Visible = true;
            }
            else { btnBuy49er.Enabled = false; pic49er.Visible = false; }
        }

        private void btnBuy49er_Click(object sender, EventArgs e)
        {
        //public double _49erCost = 100;
        //public double _49erQTY = 0;
        //public double _49erGeneratedAmt = 10;
            if(gold >= _49erCost)
            {
                gold -= _49erCost;
                _49erQTY++;
                _49erCost = Math.Floor(_49erCost * 1.25);
                UpdateForm();
                timerExtraGold.Enabled = true;
            }
        }

        private void timerExtraGold_Tick(object sender, EventArgs e)
        {
            if (_49erQTY > 0)
            {
                gold += (_49erGeneratedAmt * _49erQTY);
                UpdateForm();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
