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
    public partial class Game5 : Form
    {
        // plane , tool, reference, and setting
        private Button[,] buttons = new Button[DEFINE.COL_SIZE, DEFINE.ROW_SIZE];
        private int[] plane = new int[DEFINE.COL_SIZE * DEFINE.ROW_SIZE];
        private Random rnd = new Random();
        public Menu parent;
        public bool autoFlipBack = false;
        public bool correctDelay = false;
        public static String C_FOLDER;

        // counter to store something
        private int remaining_card; // unit is pair
        public int t_counter = 0;   // time passing counter
        public int s_counter = 0;   // step using counter (pair for 1 plus)

        // music and effects
        private SoundPlayer sound_true = new SoundPlayer(DEFINE.S_TRUE);
        private SoundPlayer sound_false = new SoundPlayer(DEFINE.S_FALSE);
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        // constructor
        public Game5(Menu p)
        {
            parent = p;
            InitializeComponent();
            parent.Hide();
            this.Show();
            return;
        }

        /// <summary>
        /// Call this when finish the puzzle.
        /// It will show the scoresboard and user should selected what to do next.
        /// </summary>
        private void switchFrame() {
            ScoreBoard s = new ScoreBoard(this);
            return;
        }

        /// <summary>
        /// Initial everything, 
        /// including buttons genetrating, music setting, name binding and time setting.
        /// </summary>
        private void Game5_Load(object sender, EventArgs e)
        {
            // background music setting
            wmp.URL = DEFINE.M_BACKGROUND;

            // genetrate button
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
            {
                for (int x = 0; x < DEFINE.COL_SIZE; x++)
                {
                    buttons[x, y] = new Button();
                    buttons[x, y].Location = new Point(x * (this.Width - DEFINE.WIDTH_GAP)/DEFINE.COL_SIZE, y * (this.Height - DEFINE.HEIGHT_GAP)/DEFINE.ROW_SIZE);
                    this.Controls.Add(buttons[x, y]);
                    buttons[x, y].Size = new Size((this.Width - DEFINE.WIDTH_GAP) / DEFINE.COL_SIZE, (this.Height - DEFINE.HEIGHT_GAP) / DEFINE.ROW_SIZE);
                    buttons[x, y].Click += new EventHandler(this.Button_Click);
                    buttons[x, y].Name = index(x, y).ToString();
                    buttons[x, y].BackgroundImage = Image.FromFile(DEFINE.I_BACKEXTEND);
                    plane[index(x, y)] = index(x, y)%(DEFINE.COL_SIZE* DEFINE.ROW_SIZE/2);
                }
            }

            // initial the timer
            timer1.Interval = 1000;
            timer1.Start();

            // initial normal setting
            reset();
            return;
        }

        /// <summary>
        /// Enter your row and column number and get the index.
        /// Used to get each button's value,
        /// because it would be easier than using two-dimensional array to check value.
        /// </summary>
        /// <param name="x">column number</param>
        /// <param name="y">row number</param>
        /// <returns>index</returns>
        private int index(int x, int y)
        {
            return y * DEFINE.COL_SIZE + x;
        }

        /// <summary>
        /// Shuffle the cards.
        /// You can set "how many times you want to shuffle" in DEFINE class
        /// </summary>
        private void shuffle() {
            // genetrate number to each card
            for (int n = 0; n < DEFINE.SHUFFLE_TIMES; n++)
                Tools.Swap<int>(ref plane[rnd.Next() % (DEFINE.COL_SIZE * DEFINE.ROW_SIZE)],
                                ref plane[rnd.Next() % (DEFINE.COL_SIZE * DEFINE.ROW_SIZE)]);

            // tmp part to make num print on screem
            //for (int y = 0; y < DEFINE.ROW_SIZE; y++)
            //    for (int x = 0; x < DEFINE.COL_SIZE; x++)
            //        buttons[x, y].Text = plane[index(x, y)].ToString();

            return;
        }
        
        private void enable(bool enable) {
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
                for (int x = 0; x < DEFINE.COL_SIZE; x++)
                    buttons[x, y].Enabled = enable;
            return;
        }

        bool se = false;    // selected boolean
        bool firstTime = true;
        Button first;      // selected button first time
        Button second;      // selected button this time
        /// <summary>
        /// Each button which be genetrated by the program will be binded to this function.
        /// It will handle each situation and change pictureson each cards.
        /// </summary>
        private void Button_Click(Object sender, EventArgs e)
        {
            Button this_sender = (Button)sender;

            if (!se)    // first time situation
            {
                // first time situation
                Text = "";
                if (!firstTime && !autoFlipBack)
                {
                    first.Image = Image.FromFile(DEFINE.C_BACK);
                    second.Image = Image.FromFile(DEFINE.C_BACK);
                }
                first = this_sender;
                s_counter++;
                this_sender.Image = Image.FromFile(cardPhotoAddress(plane[Convert.ToInt32(this_sender.Name)]));
                se = true;
                firstTime = false;
            }else {      // Second time situation
                second = this_sender;
                if (this_sender.Equals(first)){
                    // select same situation (do nothing)
                }else if (plane[Convert.ToInt32(first.Name)] == plane[Convert.ToInt32(this_sender.Name)]){
                    // correct situation
                    sound_true.Play();
                    if (correctDelay) {
                        this_sender.Image = Image.FromFile(cardPhotoAddress(plane[Convert.ToInt32(this_sender.Name)]));
                        Task.WaitAll(Task.Delay(DEFINE.DELAY_TIME));
                    }
                    first.Hide();
                    this_sender.Hide();
                    remaining_card--;
                    se = false;
                    // end of game
                    if (remaining_card == 0)
                        switchFrame();
                }else{
                    // false situation
                    sound_false.Play();
                    this_sender.Image = Image.FromFile(cardPhotoAddress(plane[Convert.ToInt32(this_sender.Name)]));
                    if (autoFlipBack){
                        Task.WaitAll(Task.Delay(DEFINE.DELAY_TIME));
                        first.Image = Image.FromFile(DEFINE.C_BACK);
                        this_sender.Image = Image.FromFile(DEFINE.C_BACK);
                    }
                    // should clear mouse event queue here, but I didn't nkow how
                    se = false;
                }
            }
            return;
        }

        private String cardPhotoAddress(int num) {

            if (num < 10 && num >= 0)
                return DEFINE.C_PRE + "0" + num.ToString() + DEFINE.C_POST;
            else if (num >= 10 && num < 16)
                return DEFINE.C_PRE + num.ToString() + DEFINE.C_POST;
            else
                return DEFINE.C_BACK;   // error
        }

        /// <summary>
        /// You can reset game by using this function, 
        /// like shuffle the cards again, initial the con\unter and timer.
        /// </summary>
        public void reset() {
            // refresh the DEFINE
            DEFINE.refresh();

            // show all of the buttons
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
                for (int x = 0; x < DEFINE.COL_SIZE; x++) {
                    buttons[x, y].Show();
                    buttons[x, y].Image = Image.FromFile(DEFINE.C_BACK);
                }

            // shuffle the cards position
            shuffle();

            // initial the counter
            remaining_card = DEFINE.COL_SIZE * DEFINE.ROW_SIZE / 2;
            s_counter = 0;

            // reenable timer.
            t_counter = 0;
            timer1.Enabled = true;
            return;
        }

        /// <summary>
        /// Timer function.
        /// p.s. timer will getting fired twice.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            t_counter++;
            Text = t_counter.ToString();
            if (wmp.playState == WMPPlayState.wmppsStopped)
                wmp.URL = DEFINE.M_BACKGROUND;
        }

        /// <summary>
        /// no matter why you close the form,
        /// we should show the parent form,
        /// or it would be a bad news.
        /// </summary>
        private void Game5_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmp.close();
            parent.Show();
            parent.resetSkin();
            Game5.C_FOLDER = null;
        }
    }

    class DEFINE
    {
        public static int ROW_SIZE = 4;
        public static int COL_SIZE = 8;
        public const int WIDTH_GAP = 16;
        public const int HEIGHT_GAP = 38;
        public const int SHUFFLE_TIMES = 200;
        public const int DELAY_TIME = 1200;
        public static int MIN_STEP = ROW_SIZE * COL_SIZE / 2;
        public static int MAX_STEP = 200 + MIN_STEP;
        public const int STEP_SCALES = 1;
        public const int MAX_TIME = 180;
        public const int TIME_SCALE = 2;
        public const String S_TRUE = "../../Resources/sound/true.wav";
        public const String S_FALSE = "../../Resources/sound/false.wav";
        public const String S_ENTER = "../../Resources/sound/enter.wav";
        public const String M_BACKGROUND = "background.mp3";
        public const String M_MENU = "menu.mp3";
        public const String I_BACKEXTEND = "../../Resources/game5_image/other/cardExtend.png";
        public static String C_BACK;
        public static String C_PRE;
        public static String C_POST;
        public static void refresh() {
            C_BACK = "../../Resources/game5_image/" + Game5.C_FOLDER + "/CB.png";
            C_PRE = "../../Resources/game5_image/" + Game5.C_FOLDER + "/C";
            C_POST = ".png";
        }
    }



    static class Tools
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
