using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BusinessLogicLayer;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        byte[] img;
        int tempo = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = true;

            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Hide();
            guna2GradientPanel2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Show();
            guna2GradientPanel2.Hide();
            label8.Hide();
            guna2PictureBox3.Hide();

            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked)
            {
                guna2TextBox3.UseSystemPasswordChar = false;

            }
            else
            {
                guna2TextBox3.UseSystemPasswordChar = true;
            }

        }

        // Array de bytes para imagem 

        public Image byteArrayToImage(byte[] byteArrayIn)

        {

            using (MemoryStream mStream = new MemoryStream(byteArrayIn))

            {

                return Image.FromStream(mStream);

            }

        }

        // imagem para array de bytes

        public byte[] imgToByteArray(Image img)

        {

            using (MemoryStream mStream = new MemoryStream())

            {

                img.Save(mStream, img.RawFormat);

                return mStream.ToArray();

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (guna2CheckBox1.Checked)
            {
                Properties.Settings.Default.UserName = guna2TextBox1.Text;
                Properties.Settings.Default.Save();
            }

            DataTable dt = BLL.Conta.queryLogin(guna2TextBox1.Text, Hash(guna2TextBox2.Text));


            if (dt.Rows.Count > 0)
            {
                globais.id = (int)dt.Rows[0]["id"];
                string projectPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName;
                string configFolderPath = Path.Combine(projectPath, "Config");
                globais.configLocal = configFolderPath;
                string destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString());

                // Create the folder if it doesn't exist
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                Form1 f1 = new Form1();
                f1.Show();


            }
            else
            {
                label6.Show();
                guna2PictureBox5.Show();
            }
        }

        static string Hash(string input)

        {

            using (SHA1Managed sha1 = new SHA1Managed())

            {

                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

                var sb = new StringBuilder(hash.Length * 2);



                foreach (byte b in hash)

                {
                    // can be "x2" if you want lowercase

                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            if (guna2TextBox4.Text == string.Empty)
            {
                MessageBox.Show("O seu nome de utlizador não pode estar vazio");
            }



            if (guna2TextBox3.Text == string.Empty)
            {
                MessageBox.Show("A sua senha não pode estar vazia");

            }

            if (guna2TextBox4.TextLength <= 2)
            {
                MessageBox.Show("Seu nome de utilizador deve conter mais de 2 letras");
                return;
            }

            if (guna2TextBox3.TextLength <= 8)
            {
                label8.Show();
                guna2PictureBox3.Show();
                return;
            }
            else
            {
                label8.Hide();
                guna2PictureBox3.Hide();
            }



            string Nome = guna2TextBox4.Text;
            img = imgToByteArray(pictureBox1.Image);

            bool accountExists = BLL.Conta.CheckAccountExists(Nome);

            if (accountExists)
            {
                MessageBox.Show("Já existe uma conta com este nome de utilizador");
            }
            else
            {
                int idInserido = BLL.Conta.InsertConta(guna2TextBox4.Text, Hash(guna2TextBox3.Text), Convert.ToDateTime(guna2DateTimePicker1.Value), img);
                string destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + idInserido.ToString());

                // Create the folder if it doesn't exist
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                label7.Show();
                guna2PictureBox6.Show();

            }



            //checkar se o utilizador ja tem conta ou nao 
            timer1.Start();

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text.Length >= 1)
            {
                label5.Hide();
                guna2PictureBox4.Hide();
            }
            else
            {
                label5.Show();
                guna2PictureBox4.Show();
            }
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length >= 1)
            {
                label6.Hide();
                guna2PictureBox5.Hide();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text.Length >= 1)
            {
                label6.Hide();
                guna2PictureBox5.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                guna2TextBox1.Text = Properties.Settings.Default.UserName;

            }

            guna2TextBox2.UseSystemPasswordChar = true;
            guna2TextBox3.UseSystemPasswordChar = true;

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo++;
            if (tempo == 4)
            {
                label7.Visible = false;
                guna2PictureBox6.Visible = false;
                tempo = 0;
                timer1.Stop();
            }
        }

        private void guna2Button1_Enter(object sender, EventArgs e)
        {
        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (guna2CheckBox1.Checked)
                {
                    Properties.Settings.Default.UserName = guna2TextBox1.Text;
                    Properties.Settings.Default.Save();
                }

                DataTable dt = BLL.Conta.queryLogin(guna2TextBox1.Text, Hash(guna2TextBox2.Text));


                if (dt.Rows.Count > 0)
                {
                    globais.id = (int)dt.Rows[0]["id"];
                    Form1 f1 = new Form1();
                    f1.Show();


                }
                else
                {
                    label6.Show();
                    guna2PictureBox5.Show();
                }
            }
        }
    }
}
