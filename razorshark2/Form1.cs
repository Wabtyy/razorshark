using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

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
        bool buttonpressed = true;
        Timer highlightTimer = new Timer();
        bool autospinActive = false;  // Variable, um den Autospin-Modus zu verfolgen
        bool keepanimationactive = true;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!autospinActive)  // Wenn Autospin nicht aktiv ist, manuell spinnen
            {
                spin();
            }
        }
        private void BetUp_Click(object sender, EventArgs e)
        {
            bet.Text = (int.Parse((bet.Text).Replace("€", "")) * 2).ToString() + "€";
        }

        private void BetDown_Click(object sender, EventArgs e)
        {
            bet.Text = (int.Parse((bet.Text).Replace("€", "")) / 2).ToString() + "€";
        }
        void spin()
        {
            // Stoppe den Timer für vorherige Animationen
            highlightTimer.Stop();

            // Setze alle Slot-Hintergründe und Rahmen zurück
            foreach (var slot in new PictureBox[] { slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12 })
            {
                slot.BackColor = Color.Transparent;
                slot.BorderStyle = BorderStyle.None;
            }

            // Bereite für den nächsten Spin vor
            keepanimationactive = false;
            timer.Interval = 50;
            winnings.Text = "";

            reihenfolge.Clear(); // Lösche die Gewinnkombinationen des vorherigen Spins

            // Aktualisiere das Guthaben
            int bet2 = int.Parse(bet.Text.Replace("€", ""));
            int balance2 = int.Parse(balance.Text.Replace("€", ""));
            balance.Text = (balance2 - bet2).ToString() + "€";

            // Setze alle Slot-Bilder zurück
            for (int i = 0; i < 12; i++)
            {
                int random = rnd.Next(0, bilder.Length);
                slotImages[i] = bilder[random];
                UpdateSlotImage(i);
            }

            // Setze Framecount zurück und starte den Timer für den neuen Spin
            frameCount = 0;
            animationInProgress = true;
            timer.Start();
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = timer.Interval+5;
            if (frameCount < 30)
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

                if (autospinActive)  // Wenn Autospin aktiv ist, wird der nächste Spin sofort ausgelöst
                {
                    Thread.Sleep(1000);
                    spin();
                }
            }
        }

        private void SetFinalImages()
        {
            
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
                int bet2 = int.Parse(bet.Text.Replace("€", ""));
                int totalWinAmount = 0;
                keepanimationactive = true;

                // Stoppe den Highlight Timer, bevor eine neue Kombination hervorgehoben wird
                highlightTimer.Stop();

                // Entferne alle vorherigen Highlights
                foreach (var slot in new PictureBox[] { slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12 })
                {
                    slot.BackColor = Color.Transparent;
                    slot.BorderStyle = BorderStyle.None;
                }

                // Überprüfe alle Reihen und Spalten auf Gewinne
                for (int row = 0; row < 3; row++)
                {
                    int startIndex = row * 4;
                    if (reihenfolge[startIndex] == reihenfolge[startIndex + 1] &&
                        reihenfolge[startIndex + 1] == reihenfolge[startIndex + 2] &&
                        reihenfolge[startIndex + 2] == reihenfolge[startIndex + 3])
                    {
                        totalWinAmount += bet2 * 4;
                        HighlightWinningCombination(new int[] { startIndex, startIndex + 1, startIndex + 2, startIndex + 3 });
                        break;
                    }
                    else if (reihenfolge[startIndex] == reihenfolge[startIndex + 1] &&
                             reihenfolge[startIndex + 1] == reihenfolge[startIndex + 2])
                    {
                        totalWinAmount += bet2 * 3;
                        HighlightWinningCombination(new int[] { startIndex, startIndex + 1, startIndex + 2 });
                        break;
                    }
                    else if (reihenfolge[startIndex + 1] == reihenfolge[startIndex + 2] &&
                             reihenfolge[startIndex + 2] == reihenfolge[startIndex + 3])
                    {
                        totalWinAmount += bet2 * 3;
                        HighlightWinningCombination(new int[] { startIndex + 1, startIndex + 2, startIndex + 3 });
                        break;
                    }
                }

                for (int col = 0; col < 4; col++)
                {
                    if (reihenfolge[col] == reihenfolge[col + 4] && reihenfolge[col + 4] == reihenfolge[col + 8])
                    {
                        totalWinAmount += bet2 * 3;
                        HighlightWinningCombination(new int[] { col, col + 4, col + 8 });
                    }
                }

                if (reihenfolge[0] == reihenfolge[5] && reihenfolge[5] == reihenfolge[10])
                {
                    totalWinAmount += bet2 * 3;
                    HighlightWinningCombination(new int[] { 0, 5, 10 });
                }
                if (reihenfolge[3] == reihenfolge[6] && reihenfolge[6] == reihenfolge[9])
                {
                    totalWinAmount += bet2 * 3;
                    HighlightWinningCombination(new int[] { 3, 6, 9 });
                }

                // Zeige den Gewinnbetrag an, wenn es einen gibt
                if (totalWinAmount > 0)
                {
                    winnings.Text = totalWinAmount + "€";
                    int balance2 = int.Parse(balance.Text.Replace("€", ""));
                    balance.Text = (balance2 + totalWinAmount) + "€";
                }
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
            }
        }




        // Methode, um die gewonnenen Kombinationen hervorzuheben
        // Methode, um die gewonnenen Kombinationen hervorzuheben
        private void HighlightWinningCombination(int[] indices)
        {
            if (!keepanimationactive) return; // Falls Animation deaktiviert ist, nicht starten

            highlightTimer.Stop(); // Stoppe vorherige Animationen
            highlightTimer = new Timer(); // Neuen Timer erstellen
            highlightTimer.Interval = 400; // Geschwindigkeit der Animation

            PictureBox[] slots = { slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12 };

            int phase = 0;   // Steuert die Phasen der Animation
            int step = 0;    // Zählt Schritte in Phase 2
            bool forward = true;
            int blinkCount = 0;

            highlightTimer.Tick += (sender, e) =>
            {
                if (!keepanimationactive) // Falls ein neuer Spin beginnt, stoppe Animation
                {
                    highlightTimer.Stop();
                    foreach (int index in indices)
                    {
                        slots[index].BackColor = Color.Transparent;
                        slots[index].BorderStyle = BorderStyle.None;
                    }
                    return;
                }

                // Setzt alle Gewinn-Slots zurück (entfernt vorherige Highlights)
                foreach (int index in indices)
                {
                    slots[index].BackColor = Color.Transparent;
                    slots[index].BorderStyle = BorderStyle.None;
                }

                if (phase == 0) // **Phase 1: Alle blinken 3-mal**
                {
                    if (blinkCount < 6) // 6 Ticks = 3-mal Blinken
                    {
                        Color color = (blinkCount % 2 == 0) ? Color.Yellow : Color.Transparent;
                        foreach (int index in indices)
                        {
                            slots[index].BackColor = color;
                            slots[index].BorderStyle = (color == Color.Yellow) ? BorderStyle.Fixed3D : BorderStyle.None;
                        }
                        blinkCount++;
                    }
                    else
                    {
                        phase = 1; // Nächste Phase starten
                        step = 0;
                    }
                }
                else if (phase == 1) // **Phase 2: Slots einzeln hervorheben (vorwärts)**
                {
                    if (step < indices.Length)
                    {
                        slots[indices[step]].BackColor = Color.Yellow;
                        slots[indices[step]].BorderStyle = BorderStyle.Fixed3D;
                        step++;
                    }
                    else
                    {
                        phase = 2;
                        step = indices.Length - 1;
                    }
                }
                else if (phase == 2) // **Phase 3: Slots einzeln hervorheben (rückwärts)**
                {
                    if (step >= 0)
                    {
                        slots[indices[step]].BackColor = Color.Yellow;
                        slots[indices[step]].BorderStyle = BorderStyle.Fixed3D;
                        step--;
                    }
                    else
                    {
                        phase = 0; // Zurück zur ersten Phase (Endlosschleife)
                        blinkCount = 0;
                    }
                }
            };

            highlightTimer.Start(); // Starte die unendliche Animation
        }







        private void button2_Click(object sender, EventArgs e) // autospin knopf
        {
            if (buttonpressed == true)
            {
                button2.BackColor = Color.DimGray;
                autospinActive = true;
                spin(); // Startet den ersten Spin
            }
            else
            {
                button2.BackColor = Color.Transparent;
                autospinActive = false;
            }
            buttonpressed = !buttonpressed;
        }
    }
}
