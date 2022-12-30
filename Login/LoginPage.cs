using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework.DataAccessLayer;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public string Admin;
        string User;
        //Login butonuna tıklayınca
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new(new EfEmployeeDal());

            var result = employeeManager.GetAll();

            if (result.Succes == true)
            {
                foreach (var manager in employeeManager.GetAll().Data)
                {
                    if (manager.Username == txtUsername.Text && manager.Password == txtPassword.Text)
                    {
                        HomePage homePage=new();
                        if (manager.UserId==1)
                        {
                            homePage.adminOrNot ="Admin";
                            homePage.userName= txtUsername.Text;
                            homePage.ShowDialog();

                        }
                        else if(manager.UserId==2)
                        {
                            homePage.adminOrNot = "";
                            homePage.userName = txtUsername.Text;
                            homePage.ShowDialog();
                        }
                        homePage.Show();
                        this.Hide();
                    }
                    else
                    {
                        btnLogin.ForeColor = Color.Red;
                        labError.Visible = true;
                    }
                }
            }
            else
                MessageBox.Show(Messages.UnknownError);
        }

        //Close butonun üstüne gelince
        private void PicClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.Width += 5;
            picClose.Height += 5;
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Width -= 5;
            picClose.Height -= 5;
        }

        //Close butonuna tıklayınca
        private void PicClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Textbox'a tıklanınca çalışacak kodlar
        private void TxtUsername_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.FromArgb(224, 224, 224);
            txtPassword.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.FromArgb(224, 224, 224);
            txtUsername.ForeColor = Color.FromArgb(224, 224, 224);
        }

        //Textbox da işlem yapınca çalışacak kodlar
        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.MaxLength = 8;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.FromArgb(224, 224, 224);
            txtPassword.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.MaxLength= 16;
            txtPassword.PasswordChar = '•';
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.FromArgb(224, 224, 224);
            txtUsername.ForeColor = Color.FromArgb(224, 224, 224);
        }

        //Textbox'a girince ve çıkınca çalışacak kodlar
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == Messages.Username)
                txtUsername.Text = Messages.Space;
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == Messages.Space)
                txtUsername.Text = Messages.Username;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == Messages.Password)
                txtPassword.Text = Messages.Space;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == Messages.Space)
                txtPassword.Text = Messages.Password;
        }

        //Panel Hareket Ettirme
        int Movee;
        int Mouse_x;
        int Mouse_y;
        private void Panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Movee = 0;
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Movee = 1; 
            Mouse_x = e.X;
            Mouse_y = e.Y;
        }

        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(Movee==1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }
    }
}
