using Bunifu.UI.WinForms.BunifuButton;
using BusinessLogicLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//using static System.Net.Mime.MediaTypeNames;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool play = false;
        int album = 0;
        bool senha = false;
        bool senha2 = false;
        bool senha3 = false;
        int tempo = 0;
        byte[] img;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private BunifuButton dynamicbutton;
        
        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            int next = dataGridView1.CurrentRow != null ? dataGridView1.CurrentRow.Index + 1 : 0;
            int next2 = dataGridView3.CurrentRow != null ? dataGridView3.CurrentRow.Index + 1 : 0;
            if (album == 1)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Imagine Dragons\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 2)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\The Weeknd\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 3)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Bruno Mars\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 4)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Hip Hop\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 5)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Pop\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 6)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Rock\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 7)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Sad Songs\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 8)
            {
                if (next < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[next].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Mais Tocadas\" + dataGridView1.Rows[next].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }


            if (album == 9)
            {
                if (next2 < dataGridView3.Rows.Count)
                {
                    string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString() + "\\");
                    dataGridView3.CurrentCell = dataGridView3.Rows[next2].Cells[dataGridView3.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL =documentsPath + dataGridView3.Rows[next2].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }







        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int idxMusicaAlbum = rnd.Next(dataGridView1.RowCount);
            int idxMusicaPlaylist = rnd.Next(dataGridView3.RowCount);
            //string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (album == 1)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Imagine Dragons\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 2)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\The Weeknd\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 3)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Bruno Mars\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 4)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Hip Hop\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 5)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Pop\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 6)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Rock\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();                  
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 7)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Sad Songs\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();                
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 8)
            {
                if (idxMusicaAlbum < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxMusicaAlbum].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Mais Tocadas\" + dataGridView1.Rows[idxMusicaAlbum].Cells[0].Value.ToString();                   
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 9)
            {
                if (idxMusicaPlaylist < dataGridView3.Rows.Count)
                {
                    string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString() + "\\");
                    dataGridView3.CurrentCell = dataGridView3.Rows[idxMusicaPlaylist].Cells[dataGridView3.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = documentsPath + dataGridView3.Rows[idxMusicaPlaylist].Cells[0].Value.ToString();          
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.next();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }



        }
       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {


        }

        private void LoadDynamicButton()
        {
            int UserId = globais.id;


            DataTable buttonInfo = BLL.Conta.GetButtonInfo(UserId);

            if (buttonInfo != null && buttonInfo.Rows.Count > 0)
            {
                DataRow row = buttonInfo.Rows[0];

                // trazer informação do botao da base de dados
                int buttonLocationX = Convert.ToInt32(row["ButtonLocationX"]);
                int buttonLocationY = Convert.ToInt32(row["ButtonLocationY"]);
                string buttonText = row["ButtonText"].ToString();

                //criar o botao dynamic de novo

                BunifuButton dynamicButton = new BunifuButton();
                dynamicButton.Text = buttonText;
                dynamicButton.Location = new Point(buttonLocationX, buttonLocationY);
                dynamicButton.Location = new Point(250, 139);
                dynamicButton.IdleFillColor = Color.FromArgb(22, 22, 22);
                dynamicButton.IdleBorderRadius = 20;
                dynamicButton.onHoverState.BorderRadius = 20;
                dynamicButton.onHoverState.FillColor = Color.FromArgb(28, 28, 28);
                dynamicButton.onHoverState.ForeColor = Color.White;
                dynamicButton.onHoverState.BorderThickness = 1;
                dynamicButton.onHoverState.BorderColor = Color.FromArgb(26, 26, 26);
                dynamicButton.OnIdleState.BorderColor = Color.FromArgb(22, 22, 22);
                dynamicButton.OnIdleState.BorderRadius = 20;
                dynamicButton.OnIdleState.BorderThickness = 1;
                dynamicButton.OnIdleState.FillColor = Color.FromArgb(22, 22, 22);
                dynamicButton.OnIdleState.ForeColor = Color.White;
                dynamicButton.OnPressedState.ForeColor = Color.White;
                dynamicButton.OnPressedState.FillColor = Color.FromArgb(22, 22, 22);
                dynamicButton.OnPressedState.BorderRadius = 20;
                dynamicButton.OnPressedState.BorderThickness = 1;
                dynamicButton.OnPressedState.BorderColor = Color.FromArgb(64, 64, 64);
                dynamicButton.TextAlign = ContentAlignment.BottomCenter;
                dynamicButton.TextPadding = new Padding(0, 0, 0, 20);
                dynamicButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dynamicButton.Size = new Size(197, 245);
                dynamicButton.Click += DynamicButton_Click;

                // adicionar o botão para a pagina correta
                TabPage tabPage1 = bunifuPages1.TabPages[2];
                tabPage1.Controls.Add(dynamicButton);
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            timer3.Start();

            bool buttonExists = BLL.Conta.CheckButtonExists(globais.id);
            if (buttonExists)
            {
                
                label23.Show();
                guna2CirclePictureBox4.Show();
                guna2PictureBox12.Visible = true;
            }
            else
            {
                int userId = globais.id;

                chamarLblPic8();


                //chamar design do button criado.             
                BunifuButton dynamicButton = new BunifuButton();
                dynamicButton.Text = "PlayList 1";
                dynamicButton.Location = new Point(250, 139);
                dynamicButton.IdleFillColor = Color.FromArgb(22, 22, 22);
                dynamicButton.IdleBorderRadius = 20;
                dynamicButton.onHoverState.BorderRadius = 20;
                dynamicButton.onHoverState.FillColor = Color.FromArgb(28, 28, 28);
                dynamicButton.onHoverState.ForeColor = Color.White;
                dynamicButton.onHoverState.BorderThickness = 1;
                dynamicButton.onHoverState.BorderColor = Color.FromArgb(26, 26, 26);
                dynamicButton.OnIdleState.BorderColor = Color.FromArgb(22, 22, 22);
                dynamicButton.OnIdleState.BorderRadius = 20;
                dynamicButton.OnIdleState.BorderThickness = 1;
                dynamicButton.OnIdleState.FillColor = Color.FromArgb(22, 22, 22);
                dynamicButton.OnIdleState.ForeColor = Color.White;
                dynamicButton.OnPressedState.ForeColor = Color.White;
                dynamicButton.OnPressedState.FillColor = Color.FromArgb(22, 22, 22);
                dynamicButton.OnPressedState.BorderRadius = 20;
                dynamicButton.OnPressedState.BorderThickness = 1;
                dynamicButton.OnPressedState.BorderColor = Color.FromArgb(64, 64, 64);
                dynamicButton.TextAlign = ContentAlignment.BottomCenter;
                dynamicButton.TextPadding = new Padding(0, 0, 0, 20);
                dynamicButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dynamicButton.Size = new Size(197, 245);
                dynamicButton.Click += DynamicButton_Click;
                guna2PictureBox12.Visible= true;

                TabPage tabPage1 = bunifuPages1.TabPages[2];

                // adicionar o botao á terceira pagina
                tabPage1.Controls.Add(dynamicButton);

                int buttonLocationX = 250;
                int buttonLocationY = 139;

                int rowsAffected = BLL.Conta.SaveButtonInfo(userId, buttonLocationX, buttonLocationY, dynamicButton.Text);
                
              
                if (rowsAffected > 0)
                {
                    label22.Show();
                    label24.Show();
                  
                }
                else
                {
                      MessageBox.Show("Erro ao inserir a informação");
                }
            }
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {


            bool LabelExists = BLL.Conta.CheckLabelExists(globais.id);
            bunifuPages1.SetPage(5);
            string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString() + "\\");
            string[] files = Directory.GetFiles(documentsPath);
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 9;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;


            if (LabelExists)
            {
                bunifuPages1.SetPage(5);
            }
            else
            {
                int userId = globais.id;

                chamarLblPic8();

                Label dynamiclabel = new Label();
                dynamiclabel.Text = "A minha Playlist nº1";
                //dynamiclabel.Location = new Point(192, 141);
                //dynamiclabel.Size = new Size(373, 46);
                //dynamiclabel.ForeColor = Color.White;
                //dynamiclabel.BackColor = Color.Transparent;
                //dynamiclabel.Font = new Font("Microsoft YaHei", 26.25f, FontStyle.Bold);
                dynamiclabel.Click += Dynamiclabel_Click;
                //TabPage tabPage1 = bunifuPages1.TabPages[5];
                //tabPage1.Controls.Add(dynamiclabel);


                int labelLocationX = 192;
                int labelLocationY = 141;

                img = imgToByteArray(guna2PictureBox11.Image);
                img = imgToByteArray(guna2PictureBox12.Image);
                int rowsAffected = BLL.Conta.SaveLabelInfo(userId, labelLocationX, labelLocationY, dynamiclabel.Text);
                int rowsaffected = BLL.Conta.SavePlaylistInfo(userId, dynamiclabel.Text, img);
                
                label26.Text = BLL.Conta.LoadLabelText(userId);
                if (rowsAffected > 0 && rowsaffected > 0)
                {
                    //MessageBox.Show("Erro ao inserir a informação");
                }


            }
        }

        private void LoadDynamicLabel()
        {
            int UserId = globais.id;


            DataTable labelInfo = BLL.Conta.GetLabelInfo(UserId);

            if (labelInfo != null && labelInfo.Rows.Count > 0)
            {
                DataRow row = labelInfo.Rows[0];

                // trazer informação do botao da base de dados
                int LabelLocationX = Convert.ToInt32(row["LabelLocationX"]);
                int LabelLocationY = Convert.ToInt32(row["LabelLocationY"]);
                string LabelText = row["LabelText"].ToString();

                //criar o botao dynamic de novo

                Label dynamiclabel = new Label();
                dynamiclabel.Text = "A minha Playlist nº1";
                dynamiclabel.Location = new Point(192, 141);
                dynamiclabel.Size = new Size(373, 46);
                dynamiclabel.ForeColor = Color.White;
                dynamiclabel.BackColor = Color.Transparent;
                dynamiclabel.Font = new Font("Microsoft YaHei", 26.25f, FontStyle.Bold);
                dynamiclabel.Click += Dynamiclabel_Click;
                // adicionar o botão a pagina correta
                TabPage tabPage1 = bunifuPages1.TabPages[5];
                tabPage1.Controls.Add(dynamiclabel);
            }
        }
        private void Dynamiclabel_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel1.Show();
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
            chamarLblPic8();
            panel3.BackColor = Color.FromArgb(15, 15, 15);
            guna2Button5.FillColor = Color.FromArgb(18, 18, 18);

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

            bunifuPages1.SetPage(0);
            chamarLblPic8();
            panel3.BackColor = Color.FromArgb(18, 18, 18);
            guna2Button5.FillColor = Color.FromArgb(18, 18, 18);

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

            bunifuPages1.SetPage(3);
            panel4.Visible = true;
            string[] files = Directory.GetFiles(globais.configLocal + @"\Imagine Dragons\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 1;


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            playMusic(album, e.RowIndex);
        }

        private void playMusic(int Album, int Music)
        {

            globais.local = Music;
            if (Album == 1)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Imagine Dragons\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 2)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\The Weeknd\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 3)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Bruno Mars\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 4)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Hip Hop\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 5)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Pop\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 6)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Rock\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 7)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Sad Songs\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 8)
            {
                axWindowsMediaPlayer1.URL = globais.configLocal + @"\Mais Tocadas\" + dataGridView1.Rows[Music].Cells[0].Value.ToString();
            }
            if (Album == 9)
            {
                string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString() + "\\");
                axWindowsMediaPlayer1.URL = documentsPath + dataGridView3.Rows[Music].Cells[0].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            int userId = globais.id;
            LoadDynamicButton();
            label26.Text = BLL.Conta.LoadLabelText(userId);
            
            DataTable musicaDataTable = BLL.Conta.LoadMusicas(globais.id);
            dataGridView3.DataSource = musicaDataTable;
            dataGridView3.Columns["FilePath"].Visible = false;
            Desgindatagridview3();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            bool buttonExists = BLL.Conta.CheckButtonExists(globais.id);
                if (buttonExists)
                {
                    guna2PictureBox12.Visible = true;
                }

            chamarDesign();
            label8.Hide();
            guna2PictureBox8.Hide();
            guna2Button2.Hide();
            guna2Button3.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            guna2CirclePictureBox4.Hide();
            DataTable dataTable = BLL.Conta.Load(globais.id);
            foreach (DataRow row in dataTable.Rows)
            {

                string Nome = row[0].ToString();
                label7.Text = Nome;

                if (dataTable.Rows.Count > 0)
                {
                    byte[] imageData = (byte[])dataTable.Rows[0]["Foto"];

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            guna2CirclePictureBox1.Image = Image.FromStream(memoryStream);
                        }
                    }
                }

                string dtNascimento = row[3].ToString();
                label9.Text = dtNascimento;

                string GeneroMusical = row[2].ToString();
                bunifuDropdown1.SelectedItem = GeneroMusical;

            }
            DataTable dataTable1 = BLL.Conta.LoadFotoPlaylist(globais.id);
            if (dataTable1.Rows.Count > 0)
            {
                byte[] imageData1 = (byte[])dataTable1.Rows[0]["Foto"];

                if (imageData1 != null && imageData1.Length > 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream(imageData1))
                    {
                        guna2PictureBox11.Image = Image.FromStream(memoryStream);
                        guna2PictureBox12.Image = guna2PictureBox11.Image;
                    }
                }
            }
        }
        private void Desgindatagridview3()
        {
            dataGridView3.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            dataGridView3.DefaultCellStyle.ForeColor = Color.White;
            dataGridView3.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F);
            dataGridView3.RowTemplate.Height = 50; 
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // Set Altura de cada Row individualmente
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 65;
            }
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 15, 15);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 26, 26);


        }

        private void Desgindatagridview()
        {
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F);

            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            // Set Altura de cada Row individualmente
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 65;
            }

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);


            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 26, 26);


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Desgindatagridview();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Imagine Dragons\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            panel3.BackColor = Color.FromArgb(15, 15, 15);
            guna2Button5.FillColor = Color.FromArgb(15, 15, 15);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuHSlider1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                bunifuHSlider1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;


            }
            try
            {
                lbltime2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                lbltime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            }
            catch
            {

            }



        }
        //Array de bytes para imagem 

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

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuHSlider1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
        }

        private void track_volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = track_volume.Value;

        }

        private void bunifuHSlider1_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / bunifuHSlider1.Width;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 0;
            track_volume.Value = 0;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (play)
            {
                bunifuImageButton2.Image = WindowsFormsApp1.Properties.Resources.PauseIcon;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                play = false;
                timer1.Start();
            }
            else
            {
                bunifuImageButton2.Image = WindowsFormsApp1.Properties.Resources._8665236_circle_play_icon1;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                play = true;
            }

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            int previous = dataGridView1.CurrentRow != null ? dataGridView1.CurrentRow.Index - 1 : 0;// Operador ternario
            int previous2 = dataGridView3.CurrentRow != null ? dataGridView3.CurrentRow.Index - 1 : 0;



            if (album == 1)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Imagine Dragons\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 2)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\The Weeknd\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 3)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Bruno Mars\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 4)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Hip Hop\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 5)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Pop\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 6)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Rock\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 7)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Sad Songs\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 8)
            {
                if (previous < dataGridView1.Rows.Count & previous >= 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[previous].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = globais.configLocal + @"\Mais Tocadas\" + dataGridView1.Rows[previous].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            if (album == 9)
            {
                if (previous2 < dataGridView3.Rows.Count & previous2 >= 0)
                {
                    string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString() + "\\");
                    dataGridView3.CurrentCell = dataGridView3.Rows[previous2].Cells[dataGridView3.CurrentCell.ColumnIndex];
                    axWindowsMediaPlayer1.URL = documentsPath + dataGridView3.Rows[previous2].Cells[0].Value.ToString();
                    globais.local++;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.previous();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\The Weeknd\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            panel4.Visible = true;
            string[] files = Directory.GetFiles(globais.configLocal + @"\The Weeknd\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 2;


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            panel4.Visible = true;
            string[] files = Directory.GetFiles(globais.configLocal + @"\Bruno Mars\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 3;


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Bruno Mars\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 3;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            label15.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            guna2TextBox1.Visible = true;
            guna2TextBox2.Visible = true;
            guna2TextBox3.Visible = true;
            guna2Button2.Visible = true;
            guna2Button3.Visible = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.ImageLocation = openFileDialog1.FileName;
                img = imgToByteArray(guna2CirclePictureBox1.Image);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tens a certeza que queres cancelar a ação",
                       "Aviso", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    label15.Visible = false;
                    label14.Visible = false;
                    label13.Visible = false;
                    guna2TextBox1.Text = string.Empty;
                    guna2TextBox2.Text = string.Empty;
                    guna2TextBox3.Text = string.Empty;
                    guna2TextBox1.Visible = false;
                    guna2TextBox2.Visible = false;
                    guna2TextBox3.Visible = false;
                    guna2Button2.Visible = false;
                    guna2Button3.Visible = false;
                    break;
                case DialogResult.No:
                    break;
            }
            {

            }

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {

            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Hip Hop\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Pop\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Rock\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Sad Songs\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Mais Tocadas\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 8;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void chamarDesign()
        {
            bunifuDropdown1.BackgroundColor = Color.FromArgb(15, 15, 15);
            //dropdown Item aparencia
            bunifuDropdown1.ItemBackColor = Color.FromArgb(15, 15, 15);
            bunifuDropdown1.ItemForeColor = Color.FromArgb(159, 0, 72);
            bunifuDropdown1.ItemBorderColor = Color.FromArgb(159, 0, 72);
            bunifuDropdown1.BorderRadius = 3;
            //bunifuDropdown1.BackColor = Color.FromArgb(15, 15, 15);
            bunifuDropdown1.ForeColor = Color.FromArgb(159, 0, 72);
            bunifuDropdown1.Font = new Font("Geologica", 10, FontStyle.Regular);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
            img = imgToByteArray(guna2PictureBox1.Image);
            int x = BLL.Conta.UpdateGeneroMusical(bunifuDropdown1.SelectedItem.ToString(), globais.id); 
            int y = BLL.Conta.UpdateFoto(img, globais.id);

            BLL.Conta.Load(globais.id);
            label8.Show();
            guna2PictureBox8.Show();
            timer2.Start();




        }

        private void chamarLblPic8()
        {
            label8.Hide();
            guna2PictureBox8.Hide();
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Rock\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 6;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void SenhaVerificacao()
        {
            if (senha && senha2 && senha3)
            {
                guna2Button3.Enabled = true;
            }
            else
            {
                guna2Button3.Enabled = false;
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string oldPassword = guna2TextBox1.Text;
            string newPassword = guna2TextBox2.Text;
            string confirmPassword = guna2TextBox3.Text;

            if (guna2TextBox3.TextLength <= 8)
            {
                MessageBox.Show("A sua Palavra-Passe deve conter mais de 8 digitos");
                return;
            }

            DataTable dt = BLL.Conta.CheckSenha(globais.id, Hash(guna2TextBox1.Text));
            if (dt.Rows.Count > 0)
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Nova palavra-passe e a sua confirmação não coincidem");
                    return;
                }
                else
                {
                    int x = BLL.Conta.UpdateConta(globais.id, Hash(oldPassword), Hash(newPassword));

                    MessageBox.Show("Palavra-Passe atualizada com sucesso.");

                }



            }





        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.TextLength > 0)
            {
                senha = true;

            }
            else
            {
                senha = false;
            }
            SenhaVerificacao();


        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.TextLength > 0)
            {
                senha2 = true;

            }
            else
            {
                senha2 = false;
            }

            SenhaVerificacao();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox3.TextLength > 0)
            {
                senha3 = true;

            }
            else
            {
                senha3 = false;
            }
            SenhaVerificacao();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tempo++;
            if (tempo == 2)
            {
                label8.Visible = false;
                guna2PictureBox8.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                guna2CirclePictureBox4.Visible = false;
                tempo = 0;
                timer2.Stop();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Mais Tocadas\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 8;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Sad Songs\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 7;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton10_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Sad Songs\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 7;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Pop\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 5;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton11_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Pop\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 5;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Hip Hop\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 4;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton12_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Hip Hop\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 4;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton13_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
            string[] files = Directory.GetFiles(globais.configLocal + @"\Rock\");
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 6;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void lbltime2_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tempo++;
            if (tempo == 5)
            {
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                guna2CirclePictureBox4.Visible = false;
                tempo = 0;
                timer3.Stop();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            playMusic(album, e.RowIndex);
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Desgindatagridview3();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            int userId = globais.id;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Ficheiros de Audio|*.mp3;*.wav";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string sourceFilePath in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + userId.ToString() + "\\");
                    string destinationFilePath = Path.Combine(destinationFolder, fileName);

                    if (File.Exists(destinationFilePath))
                    {
                        DialogResult result = MessageBox.Show("Um arquivo com o mesmo nome já existe. Deseja substituí-lo?", "Confirmação de substituição",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Substituir o arquivo existente pelo novo arquivo
                            try
                            {
                                File.Delete(destinationFilePath);
                                File.Copy(sourceFilePath, destinationFilePath);
                                MessageBox.Show("Arquivo substituído com sucesso.", "Substituição concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show("Ocorreu um erro ao substituir o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        
                        File.Copy(sourceFilePath, destinationFilePath, true);
                       
                        int rowsAffected = BLL.Conta.InsertMusica(fileName, destinationFilePath, userId);
                        if (rowsAffected > 0)
                        {
                            // inserção funcionol
                        }
                        else
                        {
                            // inserção falhou
                        }
                    }
                }
                DataTable musicaDataTable = BLL.Conta.LoadMusicas(userId);
                dataGridView3.DataSource = musicaDataTable;
                dataGridView3.Columns["FilePath"].Visible = false;
                Desgindatagridview3();
                MessageBox.Show("Ficheiros inseridos com sucesso");
            }
            

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            playMusic(album, e.RowIndex);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox11.ImageLocation = openFileDialog1.FileName;
                guna2PictureBox12.ImageLocation = openFileDialog1.FileName;
                img = imgToByteArray(guna2PictureBox11.Image);
                guna2Button7.Show();

            }

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            img = imgToByteArray(guna2PictureBox11.Image);
            //img = imgToByteArray(guna2PictureBox12.Image);
            BLL.Conta.UpdateFoto(globais.id, img);
            BLL.Conta.LoadFotoPlaylist(globais.id);
            guna2Button7.Hide();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to copy";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            int userId = globais.id;
            string filePath = dataGridView3.CurrentRow.Cells["FilePath"].Value.ToString();
            bool fileDeleted = BLL.Conta.RemoveFileFromDatabase(filePath, userId);

            if (fileDeleted)
            {
                
                DialogResult result = MessageBox.Show("O ficheiro '" + dataGridView3.CurrentRow.Cells["#Titulo"].Value.ToString() + "' foi removido da sua lista com sucesso. Deseja eliminà-lo da pasta?", "Confirmar apagar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Tenta apagar o ficheiro caso consiga apagar atualiza a tabela
                    if (DeleteFile(filePath))
                    {
                        DataTable musicaDataTable = BLL.Conta.LoadMusicas(userId);
                        dataGridView3.DataSource = musicaDataTable;
                    }
                }
                else
                {
                    DataTable musicaDataTable = BLL.Conta.LoadMusicas(userId);
                    this.Close();
                    dataGridView3.DataSource = musicaDataTable;
                }
            }
            else
            {
                MessageBox.Show("O ficheiro '" + dataGridView3.CurrentRow.Cells["#Titulo"].Value.ToString() + "' não foi encontrado.");
            }
        }
        private bool DeleteFile(string filePath)
        {
            bool eliminadoComSucesso = false;
            try
            {
                bool fileExists = File.Exists(filePath);

                if (fileExists)
                {
                    // Eliminar o ficheiro
                    File.Delete(filePath);
                    if (File.Exists(filePath))
                    {
                        MessageBox.Show("Não foi possível apagar o ficheiro");
                    }
                    else
                    {
                        eliminadoComSucesso = true;
                        MessageBox.Show("O ficheiro foi apagado com sucesso");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar o ficheiro", "Ficheiro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro ao tentar eliminar o ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return eliminadoComSucesso;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel1.Show();
            label28.Visible= false;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            int userId = globais.id;
            BLL.Conta.UpdateLabelText(userId, guna2TextBox4.Text);
            BLL.Conta.UpdateLabelTextPlaylist(userId, guna2TextBox4.Text);
            label26.Text = BLL.Conta.LoadLabelText(userId);
            guna2CustomGradientPanel1.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel1.Hide();
            label28.Visible= true;
        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            bool LabelExists = BLL.Conta.CheckLabelExists(globais.id);
            bunifuPages1.SetPage(5);


            string documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpticMusic Main\\Config\\playlist\\" + globais.id.ToString() + "\\");
            string[] files = Directory.GetFiles(documentsPath);
            DataTable table = new DataTable();
            table.Columns.Add("#   Título");
            album = 9;


            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);

            }
            dataGridView1.DataSource = table;

            if (LabelExists)
            {
                bunifuPages1.SetPage(5);
            }
            else
            {
                int userId = globais.id;

                chamarLblPic8();

                Label dynamiclabel = new Label();
                dynamiclabel.Text = "A minha Playlist nº1";
                //dynamiclabel.Location = new Point(192, 141);
                //dynamiclabel.Size = new Size(373, 46);
                //dynamiclabel.ForeColor = Color.White;
                //dynamiclabel.BackColor = Color.Transparent;
                //dynamiclabel.Font = new Font("Microsoft YaHei", 26.25f, FontStyle.Bold);
                dynamiclabel.Click += Dynamiclabel_Click;
                //TabPage tabPage1 = bunifuPages1.TabPages[5];
                //tabPage1.Controls.Add(dynamiclabel);


                int labelLocationX = 192;
                int labelLocationY = 141;

                img = imgToByteArray(guna2PictureBox11.Image);
                img = imgToByteArray(guna2PictureBox12.Image);
                int rowsAffected = BLL.Conta.SaveLabelInfo(userId, labelLocationX, labelLocationY, dynamiclabel.Text);
                int rowsaffected = BLL.Conta.SavePlaylistInfo(userId, dynamiclabel.Text, img);

                label26.Text = BLL.Conta.LoadLabelText(userId);
                if (rowsAffected > 0 && rowsaffected > 0)
                {
                    //MessageBox.Show("Erro ao inserir a informação");
                }
            }
        
            }
    }
}
