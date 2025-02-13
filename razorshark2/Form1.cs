using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace razorshark2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Random rnd = new Random();
        Image[] bilder = { Properties.Resources.brille, Properties.Resources.alge, Properties.Resources.flosse, Properties.Resources.hai, Properties.Resources.hecht, Properties.Resources.Kamera };
        Image[] slotImages = new Image[12];
        int[] festePositionen = { -1 };
        List<int> beweglicheSlots = new List<int>();
        int frameCount = 0;
        bool animationInProgress = false;
        List<Image> reihenfolge = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 50;
            winnings.Text = "";
            int bet2 = int.Parse(bet.Text.Replace("$", ""));
            int balance2 = int.Parse(balance.Text.Replace("$", ""));
            balance.Text = (balance2 - bet2).ToString() + "$";

            reihenfolge.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (Array.IndexOf(festePositionen, i) != -1)
                {
                    int random = rnd.Next(0, bilder.Length);
                    slotImages[i] = bilder[random];
                }
                else
                {
                    int random = rnd.Next(0, bilder.Length);
                    slotImages[i] = bilder[random];
                }
                UpdateSlotImage(i);
            }
            frameCount = 0;
            animationInProgress = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Interval += 5;
            if (frameCount < 20)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (Array.IndexOf(festePositionen, i) == -1)
                    {
                        int random = rnd.Next(0, bilder.Length);
                        slotImages[i] = bilder[random];
                        UpdateSlotImage(i);
                    }
                }
                frameCount++;
            }
            else
            {
                SetFinalImages();
                timer.Stop();
                animationInProgress = false;
            }
        }
        private void BetUp_Click(object sender, EventArgs e)
        {
            bet.Text = (int.Parse((bet.Text).Replace("$", "")) * 2).ToString() + "$";
        }

        private void BetDown_Click(object sender, EventArgs e)
        {
            bet.Text = (int.Parse((bet.Text).Replace("$", "")) / 2).ToString() + "$";
        }

        private void SetFinalImages()
        {
            reihenfolge.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (Array.IndexOf(festePositionen, i) == -1)
                {
                    int random = rnd.Next(0, bilder.Length);
                    slotImages[i] = bilder[random];
                    reihenfolge.Add(slotImages[i]);
                }
                UpdateSlotImage(i);
            }
            CheckWin(reihenfolge);
        }

        private void UpdateSlotImage(int i)
        {
            PictureBox[] slots = { slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12 };
            slots[i].Image = slotImages[i];
        }

        private void CheckWin(List<Image> reihenfolge)
        {
            try
            {
                int bet2 = int.Parse(bet.Text.Replace("$", ""));
                int totalWinAmount = 0;

                for (int row = 0; row < 3; row++)
                {
                    int startIndex = row * 4;
                    if (reihenfolge[startIndex] == reihenfolge[startIndex + 1] &&
                        reihenfolge[startIndex + 1] == reihenfolge[startIndex + 2] &&
                        reihenfolge[startIndex + 2] == reihenfolge[startIndex + 3])
                    {
                        totalWinAmount += bet2 * 4;
                    }
                    else if (reihenfolge[startIndex] == reihenfolge[startIndex + 1] &&
                             reihenfolge[startIndex + 1] == reihenfolge[startIndex + 2])
                    {
                        totalWinAmount += bet2 * 3;
                    }
                    else if (reihenfolge[startIndex + 1] == reihenfolge[startIndex + 2] &&
                             reihenfolge[startIndex + 2] == reihenfolge[startIndex + 3])
                    {
                        totalWinAmount += bet2 * 3;
                    }
                }

                for (int col = 0; col < 4; col++)
                {
                    if (reihenfolge[col] == reihenfolge[col + 4] && reihenfolge[col + 4] == reihenfolge[col + 8])
                    {
                        totalWinAmount += bet2 * 3;
                    }
                }

                if (reihenfolge[0] == reihenfolge[5] && reihenfolge[5] == reihenfolge[10])
                {
                    totalWinAmount += bet2 * 3;
                }
                if (reihenfolge[3] == reihenfolge[6] && reihenfolge[6] == reihenfolge[9])
                {
                    totalWinAmount += bet2 * 3;
                }

                if (totalWinAmount > 0)
                {
                    winnings.Text = totalWinAmount + "$";
                    int balance2 = int.Parse(balance.Text.Replace("$", ""));
                    balance.Text = (balance2 + totalWinAmount) + "$";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Gewinnprüfung: " + ex.Message);
            }
        }
    }
}
