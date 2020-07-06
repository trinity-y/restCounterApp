using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
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
        decimal[] queueOneBarInSeconds = new decimal[1000]; 
        bool pieceStarted = false;
        Timer musicTimer = new Timer();
        int queueIndex = 0;
        string loadedPiecePath;
        public Form1()
        {
            InitializeComponent();
            pnlMainMenu.Show();
            this.KeyPreview = true;
            this.musicTimer.Tick += new EventHandler(this.musicTimerEnd);
        }

        decimal[] LoadDecimalData(string listName,  XDocument savedPiece)
        {
            queueIndex = 0;
            var currQ = savedPiece.Elements("root").Elements(listName).Elements("queue");
            
             decimal[] emptyList = new decimal[1000];
             foreach (string element in currQ)
             {
                 emptyList[queueIndex] = Decimal.Parse(element);
                 queueIndex++;
             }
            return emptyList;
        }
        string[] LoadStringData(string listName, XDocument savedPiece)
        {
            queueIndex = 0;
            var currQ = savedPiece.Elements("root").Elements(listName).Elements("queue");

            string[] emptyList = new string[1000];
            foreach (string element in currQ)
            {
                emptyList[queueIndex] = element;
                queueIndex++;
            }
            return emptyList;
        }

        private void btnNewScore_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Hide();
            pnlInputNewScore.Show();

        }

        private void btnSavedScore_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Hide();
            pnlOpenScore.Show();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\userPieces",
                Title = "Browse pieces...",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // load user's piece
                loadedPiecePath = openFileDialog1.FileName;
                Console.WriteLine("found file at path " + loadedPiecePath);
                var savedPiece = XDocument.Load(loadedPiecePath);
                // LOADS INTO ARRAYS
                queueInSeconds = LoadDecimalData("queueInSeconds", savedPiece);
                queueType = LoadStringData("queueType", savedPiece);
                queueVisible = LoadStringData("queueVisible", savedPiece);
                // load length of queue
                Console.WriteLine(savedPiece.Element("root").Element("lengthOfQueue"));
                lengthOfQueue = (int)savedPiece.Element("root").Element("lengthOfQueue");
                Console.WriteLine(lengthOfQueue);
                pnlOpenScore.Hide();
                pnlRunScore.Show();
            }

        }

        private void mtxtBpm_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //goes back and adds a warning bar if necessary
            if (cmbQueueType.Text == "music" && lengthOfQueue > 0 && queueType[lengthOfQueue-1] == "rest")
            {
                queueInSeconds[lengthOfQueue-1] -= queueOneBarInSeconds[lengthOfQueue-1];//subtracts a bar from the rest
                queueInSeconds[lengthOfQueue] = queueOneBarInSeconds[lengthOfQueue - 1];//adds a warning bar
                queueType[lengthOfQueue] = "warning";//with type warning
                lengthOfQueue += 1;
            }
            //calculates how long the queue will be in seconds and records that to an array
            queueOneBarInSeconds[lengthOfQueue] = 1 / decimal.Parse(mtxtBpm.Text) * 60 * nudNumerator.Value;
            queueInSeconds[lengthOfQueue] = queueOneBarInSeconds[lengthOfQueue] * decimal.Parse(txtEnterQueue.Text);
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
            Console.WriteLine("on queue " + queueIndex.ToString() + " out of " + lengthOfQueue.ToString());
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
                pnlRunScore.Hide();
                pnlMainMenu.Show();

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
            } else if (queueType[queueIndex] == "warning")
            {
                Console.WriteLine("this next type is a warning");
                pnlRunScore.BackColor = Color.FromArgb(223, 159, 40);
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
                    //sets back index
                    queueIndex = 0;
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

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            /*CREATING AN XML DOCUMENT WITH THE THREE PARALLEL ARRAYS & LENGTH OF QUEUE*/
            //creates an empty sort of 'frame' for the data
            String xmlBase =
                @"<?xml version=""1.0""?> 
                <root>
                    <queueInSeconds>
                    </queueInSeconds>
                    <queueVisible>
                    </queueVisible>
                    <queueType>
                    </queueType>
                </root>";
            //parses the string frame into an xml file
            XDocument savedPiece = XDocument.Parse(xmlBase);

            //each foreach loop fills in the node with data from an array
            foreach (Decimal element in queueInSeconds)
            {
                savedPiece.Element("root").Element("queueInSeconds").Add(new XElement("queue", element));
            }
            foreach (string element in queueVisible)
            {
                savedPiece.Element("root").Element("queueVisible").Add(new XElement("queue", element));
            }
            foreach (string element in queueType)
            {
                savedPiece.Element("root").Element("queueType").Add(new XElement("queue", element));
            }
            savedPiece.Element("root").Add(new XElement("lengthOfQueue", lengthOfQueue));
            //makes a pieces folder if not created already
            string folderPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\userPieces";
            try {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception){
                //if it doesnt work DON't worry about it
            }

            //saves it to computer with name
            string path = folderPath + "\\" + mtxtFileName.Text + ".xml";
            savedPiece.Save(path);
            Console.WriteLine("xml file saved at: " + path);
            lblPieceSavedConfirm.Visible = true;
            labelShowTimer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMainMenu.Show();
            pnlOpenScore.Hide();
            pnlRunScore.Hide();
            pnlInputNewScore.Hide();
        }

        private void labelShowTimer_Tick(object sender, EventArgs e)
        {
            lblPieceSavedConfirm.Visible = false;
            labelShowTimer.Enabled = false;
        }
    }
}
