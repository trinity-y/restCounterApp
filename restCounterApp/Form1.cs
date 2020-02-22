using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restCounterApp
{
    public partial class Form1 : Form
    {
        int lengthOfQueue = 0;
        decimal[] queueInSeconds = new decimal[1000];
        string[] queueVisible = new string[1000];
        string[] queueType = new string[1000];
        bool pieceStarted = false;
        Timer musicTimer = new Timer();
        int queueIndex = 0;
        public Form1()
        {
            InitializeComponent();
            pnlMainMenu.Show();
            this.KeyPreview = true;
            this.musicTimer.Tick += new EventHandler(this.musicTimerEnd);
        }

        private void btnNewScore_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Hide();
            pnlInputNewScore.Show();

        }

        private void btnSavedScore_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Hide();
        }

        private void mtxtBpm_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //calculates how long the queue will be in seconds and records that to an array
            queueInSeconds[lengthOfQueue] = (1 / decimal.Parse(mtxtBpm.Text) * 60 * nudNumerator.Value)*decimal.Parse(txtEnterQueue.Text);
            //indicates if queue is music or rest
            queueType[lengthOfQueue] = cmbQueueType.Text;
            //what the user sees (describes x bars of type)
            queueVisible[lengthOfQueue] = txtEnterQueue.Text + " bars of " + cmbQueueType.Text;
            //adds it to the list
            lstboxQueues.BeginUpdate();
            lstboxQueues.Items.Add(queueVisible[lengthOfQueue]);
            lstboxQueues.EndUpdate();
            //increases the length of all cues by one
            lengthOfQueue += 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlInputNewScore.Hide();
            pnlRunScore.Show();
            
        }
        private void musicTimerEnd(Object sender, EventArgs e)//i removed static
        {
            //Console.WriteLine("on queue " + queueIndex.ToString() + " out of " + lengthOfQueue.ToString());
            queueIndex += 1;
            if (queueIndex < lengthOfQueue)
            {
                Console.WriteLine("there's still more music");
                //calculates the number of milliseconds the cue will be
                int millisecondsInt = (int)Math.Round(queueInSeconds[queueIndex] * 1000, 0, MidpointRounding.AwayFromZero);
                //set the timer to this int
                musicTimer.Interval = millisecondsInt;
                

            } else
            {
                Console.WriteLine("no more music, STOP!!");
                musicTimer.Enabled = false;
                pnlRunScore.BackColor = Color.FromArgb(223, 159, 40);

            }
            if (queueType[queueIndex] == "music")
            {
                Console.WriteLine("this next type is music");
                //sets colour to green
                pnlRunScore.BackColor = Color.FromArgb(69, 169, 65);
                musicTimer.Enabled = true;
            }
            else if (queueType[queueIndex] == "rest")
            {
                Console.WriteLine("this next type is rest");
                //sets colour to red
                pnlRunScore.BackColor = Color.FromArgb(163, 23, 20);
                musicTimer.Enabled = true;
            }
            else
            {
                musicTimer.Enabled = false;
            }
            
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if pressing space while we are on the running screen
            if (e.KeyChar.ToString() == " " && pnlRunScore.Visible == true)
            {
                //if playing, pause
                if (musicTimer.Enabled == true)
                {
                    musicTimer.Enabled = false;
                    pnlRunScore.BackColor = Color.FromArgb(223, 159, 40);

                }
                //if paused (indicated by the fact that we're not playing AND the piece has previously started), play
                else if (musicTimer.Enabled == false && pieceStarted == true)
                {
                    //play and turn the panel back to it's proper colour
                    musicTimer.Enabled = true;
                    if (queueType[queueIndex] == "rest")
                    {
                        pnlRunScore.BackColor = Color.FromArgb(163, 23, 20);
                    } else if (queueType[queueIndex] == "music")
                    {
                        pnlRunScore.BackColor = Color.FromArgb(69, 169, 65);
                    }
                }
                //if timer hasn't started yet
                else if (pieceStarted == false)
                {
                    //sets timer to the length of the cue
                    decimal millisecondsDec = queueInSeconds[0] * 1000;
                    int millisecondsInt = (int)Math.Round(millisecondsDec, 0, MidpointRounding.AwayFromZero);
                    musicTimer.Interval = millisecondsInt;
                    Console.WriteLine(musicTimer.Interval);
                    //starts timer
                    musicTimer.Enabled = true;
                    //now the piece has started
                    pieceStarted = true;
                    //set panel to proper colour
                    if (queueType[queueIndex] == "rest")
                    {
                        pnlRunScore.BackColor = Color.FromArgb(163, 23, 20);
                    }
                    else if (queueType[queueIndex] == "music")
                    {
                        pnlRunScore.BackColor = Color.FromArgb(69, 169, 65);
                    }
                }
            }
        }
    }
}
