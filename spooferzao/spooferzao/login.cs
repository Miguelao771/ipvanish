﻿using KeyAuth;
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

namespace spooferzao
{
    public partial class login : Form
    {

        public static api KeyAuthApp = new api(
            name: "Hydra Spoofer", // App name
            ownerid: "h1v0Crtn2U", // Account ID
            version: "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                           //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
        );

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
        public login()
        {
            InitializeComponent();
            KeyAuthApp.init();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Username")
            {
                UsernameText.Text = "";

                UsernameText.ForeColor = Color.White;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.Text == "")
            {
                UsernameText.Text = "Username";

                UsernameText.ForeColor = Color.White;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";

                PasswordText.ForeColor = Color.White;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";

                PasswordText.ForeColor = Color.White;
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(UsernameText.Text, PasswordText.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Status: " + KeyAuthApp.response.message);
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

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

        private void gunaLabel2_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaLabel2_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaLabel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaLabel3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaLabel3_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaLabel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaPanel3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaLabel5_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaLabel5_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaLabel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void gunaLabel4_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void gunaLabel4_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void gunaLabel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}