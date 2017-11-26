using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace GameProject
{
    public partial class Menu : Form
    {
        private SoundPlayer sound_enter = new SoundPlayer(DEFINE.S_ENTER);
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public Menu()
        {
            InitializeComponent();
        }

        public void resetSkin()
        {
            //this.r_CardType.SelectedItem = null;
            wmp.URL = DEFINE.M_MENU;
        }

        private void b_game5_Click(object sender, EventArgs e)
        {
            sound_enter.Play();
            if (r_CardType.SelectedItem == null){
                message.Text = "Please select a card style";
                return;
            }else if (!(r_Easy.Checked || r_Medium.Checked || r_Hard.Checked || r_Custom.Checked)) {
                message.Text = "Please select a level";
                return;
            }else{
                // set card source
                for (int n = 0; n < r_CardType.Items.Count; n++)
                {
                    if (this.r_CardType.SelectedItem.Equals(this.r_CardType.Items[n]))
                    {
                        if (n < 10)
                            Game5.C_FOLDER = "T0" + n.ToString();
                        else
                            Game5.C_FOLDER = "T" + n.ToString();
                    }
                }

                // set plane size
                int row, col;
                if (r_Easy.Checked)
                {
                    row = 2;
                    col = 2;
                }
                else if (r_Medium.Checked)
                {
                    row = 3;
                    col = 6;
                }
                else if (r_Hard.Checked)
                {
                    row = 4;
                    col = 8;
                }
                else
                {
                    row = (int)r_Row.Value;
                    col = (int)r_Col.Value;
                }
                DEFINE.COL_SIZE = col;
                DEFINE.ROW_SIZE = row;
            }
            Game5 t = new Game5(this);

            // set delay
            t.autoFlipBack = r_AutoFlip.Checked;
            t.correctDelay = r_CorrectDelay.Checked;
            wmp.close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // set the music
            wmp.URL = DEFINE.M_MENU;

            // set the timer to check if music is stop
            timer1.Interval = 1000;
            timer1.Enabled = true;

            // binding the check box
            r_Easy.CheckedChanged += new System.EventHandler(checkedChanged);
            r_Medium.CheckedChanged += new System.EventHandler(checkedChanged);
            r_Hard.CheckedChanged += new System.EventHandler(checkedChanged);
            r_Custom.CheckedChanged += new System.EventHandler(checkedChanged);
            r_Custom.CheckedChanged += new System.EventHandler(customCheckedChanged);

            // binding numer up-down
            r_Col.ValueChanged += new System.EventHandler(numChabged);
            r_Row.ValueChanged += new System.EventHandler(numChabged);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // cycle the music
            if (wmp.playState == WMPPlayState.wmppsStopped)
                wmp.URL = DEFINE.M_MENU;
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            // This should be coding careful because when you change a checkbox,
            // it will recursively call this function,
            // therefore, it need a "if" and "equal" to prevent recrusive
            if (c.Checked) {
                r_Easy.Checked = CheckBox.Equals(c, r_Easy) ? true : false;
                r_Medium.Checked = CheckBox.Equals(c, r_Medium) ? true : false;
                r_Hard.Checked = CheckBox.Equals(c, r_Hard) ? true : false;
                r_Custom.Checked = CheckBox.Equals(c, r_Custom) ? true : false;
            }
            message.Text = "";
        }

        private void customCheckedChanged(object sender, EventArgs e)
        {
            l_Custom.Visible = !l_Custom.Visible;
            customLayoutPanel.Visible = !customLayoutPanel.Visible;
            message.Text = "";
        }

        private void numChabged(object sender, EventArgs e)
        {
            NumericUpDown n = (NumericUpDown)sender;
            if (r_Row.Value * r_Col.Value == 1)
            {
                n.Value = 2;
                message.Text = "You at least need two card";
            }
            else {
                message.Text = "";
            }
        }

        private void r_CardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            message.Text = "";
        }
    }
}
