using ImageProcess2;
using System.Diagnostics;
using System.Security.Cryptography.Pkcs;

namespace coins
{
    public partial class Form1 : Form
    {
        Bitmap loaded, res;
        public float totalValue = 0;
        public int totalCoins = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(openFileDialog1.FileName);
                coinPictureBox.Image = loaded;
            }
        }
        private void countBtn_Click(object sender, EventArgs e)
        {
            if (loaded == null) { return; }
            DIP.Binary(ref loaded);
            coinPictureBox.Image = loaded;
            Algorithms.CountCoins(loaded, ref totalValue, ref totalCoins);
            resultLabel.Text = $"TOTAL COINS = {totalCoins}";
            totalValueLabel.Text = $"TOTAL VALUE = {(float)Math.Ceiling(totalValue* 100) / 100}";
        }
    }
}
