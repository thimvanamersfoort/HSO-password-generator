namespace passwordGeneratorHertzinger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.cb_KleineLetters = new System.Windows.Forms.CheckBox();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.cb_Hoofdletters = new System.Windows.Forms.CheckBox();
            this.cb_Cijfers = new System.Windows.Forms.CheckBox();
            this.cb_SpecialeTekens = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.btn_Genereer = new System.Windows.Forms.Button();
            this.btn_Exporteer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trb_WachtwoordLengte = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SelectedLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_HoeveelheidWachtwoorden = new System.Windows.Forms.NumericUpDown();
            this.tb_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Empty = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_OpenFile = new System.Windows.Forms.CheckBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_WachtwoordLengte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HoeveelheidWachtwoorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_Top.Controls.Add(this.label5);
            this.panel_Top.Controls.Add(this.lbl_Title);
            this.panel_Top.Controls.Add(this.pb_Logo);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1476, 135);
            this.panel_Top.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(120)))), ((int)(((byte)(12)))));
            this.lbl_Title.Location = new System.Drawing.Point(775, 22);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title.Size = new System.Drawing.Size(672, 69);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Password Generator";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(29, 0);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pb_Logo.Size = new System.Drawing.Size(247, 146);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // cb_KleineLetters
            // 
            this.cb_KleineLetters.AutoSize = true;
            this.cb_KleineLetters.BackColor = System.Drawing.Color.Transparent;
            this.cb_KleineLetters.Font = new System.Drawing.Font("Arial", 10.5F);
            this.cb_KleineLetters.Location = new System.Drawing.Point(34, 213);
            this.cb_KleineLetters.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.cb_KleineLetters.Name = "cb_KleineLetters";
            this.cb_KleineLetters.Size = new System.Drawing.Size(276, 32);
            this.cb_KleineLetters.TabIndex = 1;
            this.cb_KleineLetters.Text = "Gebruik kleine letters";
            this.cb_KleineLetters.UseVisualStyleBackColor = false;
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.AutoSize = true;
            this.lbl_Title1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title1.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbl_Title1.Location = new System.Drawing.Point(29, 163);
            this.lbl_Title1.Margin = new System.Windows.Forms.Padding(20, 25, 0, 0);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(277, 30);
            this.lbl_Title1.TabIndex = 2;
            this.lbl_Title1.Text = "Opties voor generatie:";
            // 
            // cb_Hoofdletters
            // 
            this.cb_Hoofdletters.AutoSize = true;
            this.cb_Hoofdletters.BackColor = System.Drawing.Color.Transparent;
            this.cb_Hoofdletters.Font = new System.Drawing.Font("Arial", 10.5F);
            this.cb_Hoofdletters.Location = new System.Drawing.Point(34, 267);
            this.cb_Hoofdletters.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.cb_Hoofdletters.Name = "cb_Hoofdletters";
            this.cb_Hoofdletters.Size = new System.Drawing.Size(265, 32);
            this.cb_Hoofdletters.TabIndex = 3;
            this.cb_Hoofdletters.Text = "Gebruik hoofdletters";
            this.cb_Hoofdletters.UseVisualStyleBackColor = false;
            // 
            // cb_Cijfers
            // 
            this.cb_Cijfers.AutoSize = true;
            this.cb_Cijfers.BackColor = System.Drawing.Color.Transparent;
            this.cb_Cijfers.Font = new System.Drawing.Font("Arial", 10.5F);
            this.cb_Cijfers.Location = new System.Drawing.Point(34, 321);
            this.cb_Cijfers.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.cb_Cijfers.Name = "cb_Cijfers";
            this.cb_Cijfers.Size = new System.Drawing.Size(200, 32);
            this.cb_Cijfers.TabIndex = 4;
            this.cb_Cijfers.Text = "Gebruik cijfers";
            this.cb_Cijfers.UseVisualStyleBackColor = false;
            // 
            // cb_SpecialeTekens
            // 
            this.cb_SpecialeTekens.AutoSize = true;
            this.cb_SpecialeTekens.BackColor = System.Drawing.Color.Transparent;
            this.cb_SpecialeTekens.Font = new System.Drawing.Font("Arial", 10.5F);
            this.cb_SpecialeTekens.Location = new System.Drawing.Point(34, 375);
            this.cb_SpecialeTekens.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.cb_SpecialeTekens.Name = "cb_SpecialeTekens";
            this.cb_SpecialeTekens.Size = new System.Drawing.Size(309, 32);
            this.cb_SpecialeTekens.TabIndex = 5;
            this.cb_SpecialeTekens.Text = "Gebruik speciale tekens";
            this.cb_SpecialeTekens.UseVisualStyleBackColor = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.ProgressBar.Location = new System.Drawing.Point(34, 813);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(20, 0, 3, 20);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(850, 30);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 7;
            // 
            // btn_Genereer
            // 
            this.btn_Genereer.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_Genereer.Location = new System.Drawing.Point(1024, 782);
            this.btn_Genereer.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.btn_Genereer.Name = "btn_Genereer";
            this.btn_Genereer.Size = new System.Drawing.Size(200, 75);
            this.btn_Genereer.TabIndex = 8;
            this.btn_Genereer.Text = "Genereer";
            this.btn_Genereer.UseVisualStyleBackColor = true;
            this.btn_Genereer.Click += new System.EventHandler(this.btn_Genereer_Click);
            // 
            // btn_Exporteer
            // 
            this.btn_Exporteer.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_Exporteer.Location = new System.Drawing.Point(1247, 782);
            this.btn_Exporteer.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.btn_Exporteer.Name = "btn_Exporteer";
            this.btn_Exporteer.Size = new System.Drawing.Size(200, 75);
            this.btn_Exporteer.TabIndex = 9;
            this.btn_Exporteer.Text = "Exporteren";
            this.btn_Exporteer.UseVisualStyleBackColor = true;
            this.btn_Exporteer.Click += new System.EventHandler(this.btn_Exporteer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 773);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 25, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Progress:";
            // 
            // trb_WachtwoordLengte
            // 
            this.trb_WachtwoordLengte.BackColor = System.Drawing.Color.Silver;
            this.trb_WachtwoordLengte.Location = new System.Drawing.Point(29, 499);
            this.trb_WachtwoordLengte.Maximum = 20;
            this.trb_WachtwoordLengte.Minimum = 1;
            this.trb_WachtwoordLengte.Name = "trb_WachtwoordLengte";
            this.trb_WachtwoordLengte.Size = new System.Drawing.Size(461, 80);
            this.trb_WachtwoordLengte.TabIndex = 11;
            this.trb_WachtwoordLengte.Value = 8;
            this.trb_WachtwoordLengte.Scroll += new System.EventHandler(this.trb_WachtwoordLengte_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 25, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wachtwoord lengte:";
            // 
            // lbl_SelectedLength
            // 
            this.lbl_SelectedLength.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SelectedLength.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lbl_SelectedLength.Location = new System.Drawing.Point(29, 537);
            this.lbl_SelectedLength.Margin = new System.Windows.Forms.Padding(20, 25, 0, 10);
            this.lbl_SelectedLength.Name = "lbl_SelectedLength";
            this.lbl_SelectedLength.Size = new System.Drawing.Size(461, 59);
            this.lbl_SelectedLength.TabIndex = 13;
            this.lbl_SelectedLength.Text = "Geselecteerde lengte: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 631);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 25, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hoeveelheid wachtwoorden:";
            // 
            // nud_HoeveelheidWachtwoorden
            // 
            this.nud_HoeveelheidWachtwoorden.Font = new System.Drawing.Font("Arial", 10.5F);
            this.nud_HoeveelheidWachtwoorden.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_HoeveelheidWachtwoorden.Location = new System.Drawing.Point(34, 674);
            this.nud_HoeveelheidWachtwoorden.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_HoeveelheidWachtwoorden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_HoeveelheidWachtwoorden.Name = "nud_HoeveelheidWachtwoorden";
            this.nud_HoeveelheidWachtwoorden.Size = new System.Drawing.Size(120, 36);
            this.nud_HoeveelheidWachtwoorden.TabIndex = 16;
            this.nud_HoeveelheidWachtwoorden.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tb_Output
            // 
            this.tb_Output.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Output.Font = new System.Drawing.Font("Arial", 8F);
            this.tb_Output.Location = new System.Drawing.Point(1024, 163);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ReadOnly = true;
            this.tb_Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tb_Output.Size = new System.Drawing.Size(423, 448);
            this.tb_Output.TabIndex = 17;
            this.tb_Output.Text = "";
            // 
            // btn_Empty
            // 
            this.btn_Empty.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_Empty.Location = new System.Drawing.Point(1327, 617);
            this.btn_Empty.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.btn_Empty.Name = "btn_Empty";
            this.btn_Empty.Size = new System.Drawing.Size(120, 40);
            this.btn_Empty.TabIndex = 18;
            this.btn_Empty.Text = "Clear";
            this.btn_Empty.UseVisualStyleBackColor = true;
            this.btn_Empty.Click += new System.EventHandler(this.btn_Empty_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::passwordGeneratorHertzinger.Properties.Resources.wifi_Tekengebied_1;
            this.pictureBox1.Location = new System.Drawing.Point(671, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 886);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 135);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::passwordGeneratorHertzinger.Properties.Resources.internet_Tekengebied_1;
            this.pictureBox2.Location = new System.Drawing.Point(447, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::passwordGeneratorHertzinger.Properties.Resources.hotelTV_Tekengebied_1;
            this.pictureBox3.Location = new System.Drawing.Point(1124, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::passwordGeneratorHertzinger.Properties.Resources.intercom_Tekengebied_1;
            this.pictureBox4.Location = new System.Drawing.Point(902, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(135, 135);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = global::passwordGeneratorHertzinger.Properties.Resources.TV_Tekengebied_1;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 135);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox6.Image = global::passwordGeneratorHertzinger.Properties.Resources.fiber_Tekengebied_1;
            this.pictureBox6.Location = new System.Drawing.Point(1341, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(135, 135);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::passwordGeneratorHertzinger.Properties.Resources.signage_Tekengebied_1;
            this.pictureBox7.Location = new System.Drawing.Point(223, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(135, 132);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(120)))), ((int)(((byte)(12)))));
            this.label5.Location = new System.Drawing.Point(760, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(672, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "By Thim van A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_OpenFile
            // 
            this.cb_OpenFile.AutoSize = true;
            this.cb_OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.cb_OpenFile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_OpenFile.Font = new System.Drawing.Font("Arial", 9F);
            this.cb_OpenFile.Location = new System.Drawing.Point(1327, 741);
            this.cb_OpenFile.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.cb_OpenFile.Name = "cb_OpenFile";
            this.cb_OpenFile.Size = new System.Drawing.Size(119, 28);
            this.cb_OpenFile.TabIndex = 22;
            this.cb_OpenFile.Text = "Open file";
            this.cb_OpenFile.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1476, 1021);
            this.Controls.Add(this.cb_OpenFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Empty);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.nud_HoeveelheidWachtwoorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_SelectedLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trb_WachtwoordLengte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exporteer);
            this.Controls.Add(this.btn_Genereer);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.cb_SpecialeTekens);
            this.Controls.Add(this.cb_Cijfers);
            this.Controls.Add(this.cb_Hoofdletters);
            this.Controls.Add(this.lbl_Title1);
            this.Controls.Add(this.cb_KleineLetters);
            this.Controls.Add(this.panel_Top);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1085);
            this.MinimumSize = new System.Drawing.Size(1500, 1085);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hertzinger Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_WachtwoordLengte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HoeveelheidWachtwoorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.CheckBox cb_KleineLetters;
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.CheckBox cb_Hoofdletters;
        private System.Windows.Forms.CheckBox cb_Cijfers;
        private System.Windows.Forms.CheckBox cb_SpecialeTekens;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button btn_Genereer;
        private System.Windows.Forms.Button btn_Exporteer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trb_WachtwoordLengte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SelectedLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_HoeveelheidWachtwoorden;
        private System.Windows.Forms.RichTextBox tb_Output;
        private System.Windows.Forms.Button btn_Empty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_OpenFile;
    }
}

