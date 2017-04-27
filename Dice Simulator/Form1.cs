using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Allow users to dynamically set path?

namespace Dice_Simulator
{
    public partial class DiceSim : Form
    {
        String path = "C:\\DiceSim\\DiceSimLog.txt";

        public DiceSim()
        {
            InitializeComponent();
        }

        private void DiceSim_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 6; // Set the default dice to d20
            numBox.Text = "1"; // Set default number of dice to 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = -1;
            int num = 0;
            Random rand = new Random(); // Not cryptographically sounds, but this is fine

            Dictionary<int, int> dieType = new Dictionary<int, int>()
            {
                {0, 2}, {1, 4}, {2, 6}, {3, 8},
                { 4, 10}, {5, 12},{6, 20}, {7, 100}
            };
            
            try
            {
                num = rand.Next(1, dieType[comboBox.SelectedIndex]);
                currBox.AppendText(Convert.ToString(num) + "\n");
                logBox.AppendText(Convert.ToString(num) + "\n");
                numLog(Convert.ToString(num) + "\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }              
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }

        private void currBox_TextChanged(object sender, EventArgs e)
        {
            currBox.SelectionStart = currBox.Text.Length;
            currBox.ScrollToCaret();
        }

        private int getRandom(int dieType)
        {
            return 0;
        }

        void numLog(String data)
        {
            try
            {
                if(!checkExistence(path))
                {
                    MessageBox.Show("Data may not be permanently logged for this session.");
                    return;
                }
                
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(Convert.ToString(DateTime.Now) + ": " + data);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool checkExistence(String path)
        {
            try
            {
                Directory.CreateDirectory("C:\\DiceSim");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
