using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class F_MAIN : Form
    {

        //Import de la DLL User32

        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        public F_MAIN()
        {


            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recup du nombre de click désiré
            // Get numbers of click
            int nbClick = Convert.ToInt16(Lbl_nbClick.Text);

            // Recup de la position de la souris par rapport aux textbox
            // Get X/Y mouse position from textbox
            int y = Convert.ToInt16(Txt_y.Text);
            int x = Convert.ToInt16(Txt_x.Text);

            // Placement de la souris
            // Mouse placement
            SetCursorPos(x, y);            

            // Click
            for (int i = 0; i < nbClick; i++)
            {

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            }

        }

        private void Btn_getPosition_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Pick a position after clicking OK. You have 2 secondes for placing your mouse.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                // Pause de 2 secondes pour laisser le temps de placer sa souris.
                // Wait 2 seconds for placing mouse
                System.Threading.Thread.Sleep(2000);

                // Récup des coordonnées
                // Get coordinates
                Point coordinates = Cursor.Position;

                // Set des coorsonnées dans les textbox
                // Set coordinates in textbox
                Txt_x.Text = coordinates.X.ToString();
                Txt_y.Text = coordinates.Y.ToString();

            }

            button1.Enabled = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Set du label pour la trackbar
            // Set trackbar label
            Lbl_nbClick.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txt_x.Text) || string.IsNullOrEmpty(Txt_y.Text))
            {
                button1.Enabled = false;
            }

            Lbl_nbClick.Text = trackBar1.Value.ToString();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
