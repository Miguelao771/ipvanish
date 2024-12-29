using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace spooferzao
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);


        public Main()
        {

            InitializeComponent();
            SidePanel.Height = FivemButton.Height;
            SidePanel.Top = FivemButton.Top;
            fivem2201.BringToFront();
         

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox2_CheckedChangedA(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Fechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fechar_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = FivemButton.Height;
            SidePanel.Top = FivemButton.Top;
            fivem2201.BringToFront();

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = csgoButton.Height;
            SidePanel.Top = csgoButton.Top;
            csgo2201.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ValorantButton.Height;
            SidePanel.Top = ValorantButton.Top;
            valorant1.BringToFront();
        }

        private void gunaButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
