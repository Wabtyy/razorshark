using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace razorshark2
{
    public partial class UserControl1 : UserControl
    {
        private decimal targetAmount;
        private decimal currentAmount = 0m;
        private Timer glowTimer = new Timer();
        private bool glowIncreasing = true;

        public UserControl1()
        {
            InitializeComponent();
        }

        public void moneyRain(decimal amt)
        {
            targetAmount = amt;
            amount.Text = "0.00";

            // Setze größere Schriftgröße
            amount.Font = new Font(amount.Font.FontFamily, 60, FontStyle.Bold);

            // Starte Hochzählen nach Laden des Controls
            StartCounting();
            StartGlowEffect();
        }

        private async void StartCounting()
        {
            while (currentAmount < targetAmount)
            {
                currentAmount += 0.1m; // Schnellere Nachkommastellen-Zählung
                amount.Text = currentAmount.ToString("N2"); // Zeigt 2 Nachkommastellen an

                // Falls die Zahl ein Vielfaches von 10 erreicht -> Pause + Pop-Effekt
                if ((int)currentAmount % 10 == 0 && currentAmount % 1 == 0)
                {
                    await PopAnimation();
                }

                await Task.Delay(20); // Sehr schnelle Animation
            }


        }

        private async Task PopAnimation()
        {
            for (int i = 0; i < 3; i++) // Mehrere Größenänderungen für Pop-Effekt
            {
                amount.Font = new Font(amount.Font.FontFamily, 60 + (i % 2 == 0 ? 10 : -10), FontStyle.Bold);
                await Task.Delay(100);
            }
            amount.Font = new Font(amount.Font.FontFamily, 50, FontStyle.Bold);
        }

        private void StartGlowEffect()
        {
            glowTimer.Interval = 100;
            glowTimer.Tick += (s, e) =>
            {
                if (glowIncreasing)
                {
                    amount.ForeColor = ControlPaint.Light(amount.ForeColor);
                }
                else
                {
                    amount.ForeColor = ControlPaint.Dark(amount.ForeColor);
                }

                glowIncreasing = !glowIncreasing;
            };
            glowTimer.Start();
        }
    }
}