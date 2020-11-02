using System;
using System.Drawing;
using System.Windows.Forms;

namespace RustColorPicker
{
    public partial class frm1 : Form
    {
        private ColorDialog ColorPicker = new ColorDialog();
        public frm1()
        {
            InitializeComponent();
            Color color = ColorTranslator.FromHtml("#AADDCC");
            SetColors(color);
        }
        
        private string HexFromColor(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + color.A.ToString("X2");
        }
        private string RustFromColor(Color color)
        {
            double R = (double)color.R / 255f;
            double G = (double)color.G / 255f;
            double B = (double)color.B / 255f;
            double A = (double)color.A / 255f;
            return $"{R:F2} {G:F2} {B:F2} {A:F2}".Replace(',', '.');
        }
        private Color TrackBars()
        {
            return Color.FromArgb(tbA.Value, tbR.Value, tbG.Value, tbB.Value);
        }
        private void SetColors(Color color)
        {
            picboxColor.BackColor = color;
            ColorPicker.Color = color;
            txtHex.Text = HexFromColor(color);
            txtRust.Text = RustFromColor(color);
            txtR.Text = color.R.ToString();
            txtG.Text = color.G.ToString();
            txtB.Text = color.B.ToString();
            txtA.Text = color.A.ToString();
            tbR.Value = color.R;
            tbG.Value = color.G;
            tbB.Value = color.B;
            tbA.Value = color.A;
        }
        private void btnHex_Click(object sender, EventArgs e)
        {
            Color color;
            try
            {
                var tmp = ColorTranslator.FromHtml(txtHex.Text);
                if (txtHex.Text.Length > 7 && txtHex.Text[0] == '#')
                    color = Color.FromArgb(tmp.B,tmp.A,tmp.R,tmp.G);
                else
                    color = tmp;
                
            }
            catch
            {
                MessageBox.Show("You have typed incorrect hex value, try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetColors(color);
        }
        private void btnRust_Click(object sender, EventArgs e)
        {
            string str = txtRust.Text.Replace('.', ',');
            string[] rgba = str.Split(' ');
            double r;
            double g;
            double b;
            double a;
            if(rgba.Length != 4)
            {
                MessageBox.Show("You have typed incorrect rust value, try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!double.TryParse(rgba[0],out r))
            {
                MessageBox.Show("You have typed incorrect rust value, try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(rgba[1], out g))
            {
                MessageBox.Show("You have typed incorrect rust value, try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(rgba[2], out b))
            {
                MessageBox.Show("You have typed incorrect rust value, try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(rgba[3], out a))
            {
                MessageBox.Show("You have typed incorrect rust value, try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color = Color.FromArgb((int) Math.Ceiling(a * 255), (int) Math.Ceiling(r * 255),
                (int) Math.Ceiling(g * 255), (int) Math.Ceiling(b * 255));
            SetColors(color);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorPicker.AllowFullOpen = true;
            ColorPicker.AnyColor = true;
            ColorPicker.ShowHelp = true;
            ColorPicker.FullOpen = true;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                SetColors(ColorPicker.Color);
            }
        }

        private void tb_Scroll(object sender, EventArgs e) => SetColors(TrackBars());

        private void btnForceTop_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            btnForceTop.Text = $"Force on top: " + (TopMost ? "On" : "Off");
        }
    }
}
