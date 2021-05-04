namespace Race
{
    partial class RaceGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            this.timerRoad = new System.Windows.Forms.Timer(this.components);
            this.panelGame = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.towardCar2 = new System.Windows.Forms.PictureBox();
            this.towardCar1 = new System.Windows.Forms.PictureBox();
            this.towardCar3 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.mainCar = new System.Windows.Forms.PictureBox();
            this.LaneTwo5 = new System.Windows.Forms.Label();
            this.LaneTwo4 = new System.Windows.Forms.Label();
            this.LaneTwo3 = new System.Windows.Forms.Label();
            this.LaneTwo2 = new System.Windows.Forms.Label();
            this.LaneTwo1 = new System.Windows.Forms.Label();
            this.LaneOne5 = new System.Windows.Forms.Label();
            this.LaneOne4 = new System.Windows.Forms.Label();
            this.LaneOne3 = new System.Windows.Forms.Label();
            this.LaneOne2 = new System.Windows.Forms.Label();
            this.LaneOne1 = new System.Windows.Forms.Label();
            this.MiddleLane = new System.Windows.Forms.Label();
            this.panelPause = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.pictureFlag = new System.Windows.Forms.PictureBox();
            this.labelPause = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonMenuExit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CarMenu1 = new System.Windows.Forms.PictureBox();
            this.CarMenu3 = new System.Windows.Forms.PictureBox();
            this.CarMenu2 = new System.Windows.Forms.PictureBox();
            this.MenuTwoLane5 = new System.Windows.Forms.Label();
            this.MenuTwoLane4 = new System.Windows.Forms.Label();
            this.MenuTwoLane3 = new System.Windows.Forms.Label();
            this.MenuTwoLane2 = new System.Windows.Forms.Label();
            this.MenuTwoLane1 = new System.Windows.Forms.Label();
            this.MenuOneLane5 = new System.Windows.Forms.Label();
            this.MenuOneLane4 = new System.Windows.Forms.Label();
            this.MenuOneLane3 = new System.Windows.Forms.Label();
            this.MenuOneLane2 = new System.Windows.Forms.Label();
            this.MenuOneLane1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timerTowardCars = new System.Windows.Forms.Timer(this.components);
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.towardCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towardCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towardCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).BeginInit();
            this.panelPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarMenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRoad
            // 
            this.timerRoad.Enabled = true;
            this.timerRoad.Interval = 1;
            this.timerRoad.Tick += new System.EventHandler(this.timerRoad_Tick);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelGame.Controls.Add(this.panelPause);
            this.panelGame.Controls.Add(this.labelScore);
            this.panelGame.Controls.Add(this.labelCoins);
            this.panelGame.Controls.Add(this.label);
            this.panelGame.Controls.Add(this.towardCar2);
            this.panelGame.Controls.Add(this.towardCar1);
            this.panelGame.Controls.Add(this.towardCar3);
            this.panelGame.Controls.Add(this.Coin3);
            this.panelGame.Controls.Add(this.Coin2);
            this.panelGame.Controls.Add(this.Coin1);
            this.panelGame.Controls.Add(this.buttonPause);
            this.panelGame.Controls.Add(this.mainCar);
            this.panelGame.Controls.Add(this.LaneTwo5);
            this.panelGame.Controls.Add(this.LaneTwo4);
            this.panelGame.Controls.Add(this.LaneTwo3);
            this.panelGame.Controls.Add(this.LaneTwo2);
            this.panelGame.Controls.Add(this.LaneTwo1);
            this.panelGame.Controls.Add(this.LaneOne5);
            this.panelGame.Controls.Add(this.LaneOne4);
            this.panelGame.Controls.Add(this.LaneOne3);
            this.panelGame.Controls.Add(this.LaneOne2);
            this.panelGame.Controls.Add(this.LaneOne1);
            this.panelGame.Controls.Add(this.MiddleLane);
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(384, 563);
            this.panelGame.TabIndex = 0;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(-2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(386, 59);
            this.label.TabIndex = 55;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Black;
            this.labelScore.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(110, 40);
            this.labelScore.TabIndex = 56;
            this.labelScore.Text = "Score:";
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Black;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCoins.Location = new System.Drawing.Point(207, 9);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(109, 40);
            this.labelCoins.TabIndex = 57;
            this.labelCoins.Text = "Coins:";
            // 
            // towardCar2
            // 
            this.towardCar2.BackColor = System.Drawing.Color.Transparent;
            this.towardCar2.Image = ((System.Drawing.Image)(resources.GetObject("towardCar2.Image")));
            this.towardCar2.Location = new System.Drawing.Point(12, 23);
            this.towardCar2.Name = "towardCar2";
            this.towardCar2.Size = new System.Drawing.Size(50, 110);
            this.towardCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.towardCar2.TabIndex = 49;
            this.towardCar2.TabStop = false;
            // 
            // towardCar1
            // 
            this.towardCar1.BackColor = System.Drawing.Color.Transparent;
            this.towardCar1.Image = ((System.Drawing.Image)(resources.GetObject("towardCar1.Image")));
            this.towardCar1.Location = new System.Drawing.Point(129, 13);
            this.towardCar1.Name = "towardCar1";
            this.towardCar1.Size = new System.Drawing.Size(50, 110);
            this.towardCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.towardCar1.TabIndex = 48;
            this.towardCar1.TabStop = false;
            // 
            // towardCar3
            // 
            this.towardCar3.BackColor = System.Drawing.Color.Transparent;
            this.towardCar3.Image = ((System.Drawing.Image)(resources.GetObject("towardCar3.Image")));
            this.towardCar3.Location = new System.Drawing.Point(322, 36);
            this.towardCar3.Name = "towardCar3";
            this.towardCar3.Size = new System.Drawing.Size(50, 110);
            this.towardCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.towardCar3.TabIndex = 50;
            this.towardCar3.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.BackColor = System.Drawing.Color.Transparent;
            this.Coin3.ErrorImage = global::Race.Properties.Resources.Coin;
            this.Coin3.Image = global::Race.Properties.Resources.Coin;
            this.Coin3.InitialImage = global::Race.Properties.Resources.Coin;
            this.Coin3.Location = new System.Drawing.Point(322, 223);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(34, 32);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin3.TabIndex = 54;
            this.Coin3.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.BackColor = System.Drawing.Color.Transparent;
            this.Coin2.ErrorImage = global::Race.Properties.Resources.Coin;
            this.Coin2.Image = global::Race.Properties.Resources.Coin;
            this.Coin2.InitialImage = global::Race.Properties.Resources.Coin;
            this.Coin2.Location = new System.Drawing.Point(221, 156);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(34, 32);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin2.TabIndex = 53;
            this.Coin2.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.BackColor = System.Drawing.Color.Transparent;
            this.Coin1.ErrorImage = global::Race.Properties.Resources.Coin;
            this.Coin1.Image = global::Race.Properties.Resources.Coin;
            this.Coin1.InitialImage = global::Race.Properties.Resources.Coin;
            this.Coin1.Location = new System.Drawing.Point(110, 252);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(34, 32);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin1.TabIndex = 52;
            this.Coin1.TabStop = false;
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(0, 522);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(82, 38);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // mainCar
            // 
            this.mainCar.BackColor = System.Drawing.Color.Transparent;
            this.mainCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainCar.Image = ((System.Drawing.Image)(resources.GetObject("mainCar.Image")));
            this.mainCar.Location = new System.Drawing.Point(221, 440);
            this.mainCar.Name = "mainCar";
            this.mainCar.Size = new System.Drawing.Size(50, 110);
            this.mainCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainCar.TabIndex = 47;
            this.mainCar.TabStop = false;
            // 
            // LaneTwo5
            // 
            this.LaneTwo5.BackColor = System.Drawing.Color.White;
            this.LaneTwo5.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneTwo5.Location = new System.Drawing.Point(289, 528);
            this.LaneTwo5.Name = "LaneTwo5";
            this.LaneTwo5.Size = new System.Drawing.Size(15, 90);
            this.LaneTwo5.TabIndex = 43;
            this.LaneTwo5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneTwo4
            // 
            this.LaneTwo4.BackColor = System.Drawing.Color.White;
            this.LaneTwo4.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneTwo4.Location = new System.Drawing.Point(289, 388);
            this.LaneTwo4.Name = "LaneTwo4";
            this.LaneTwo4.Size = new System.Drawing.Size(15, 90);
            this.LaneTwo4.TabIndex = 42;
            this.LaneTwo4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneTwo3
            // 
            this.LaneTwo3.BackColor = System.Drawing.Color.White;
            this.LaneTwo3.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneTwo3.Location = new System.Drawing.Point(289, 248);
            this.LaneTwo3.Name = "LaneTwo3";
            this.LaneTwo3.Size = new System.Drawing.Size(15, 90);
            this.LaneTwo3.TabIndex = 41;
            this.LaneTwo3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneTwo2
            // 
            this.LaneTwo2.BackColor = System.Drawing.Color.White;
            this.LaneTwo2.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneTwo2.Location = new System.Drawing.Point(289, 108);
            this.LaneTwo2.Name = "LaneTwo2";
            this.LaneTwo2.Size = new System.Drawing.Size(15, 90);
            this.LaneTwo2.TabIndex = 40;
            this.LaneTwo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneTwo1
            // 
            this.LaneTwo1.BackColor = System.Drawing.Color.White;
            this.LaneTwo1.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneTwo1.Location = new System.Drawing.Point(289, -32);
            this.LaneTwo1.Name = "LaneTwo1";
            this.LaneTwo1.Size = new System.Drawing.Size(15, 90);
            this.LaneTwo1.TabIndex = 39;
            this.LaneTwo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneOne5
            // 
            this.LaneOne5.BackColor = System.Drawing.Color.White;
            this.LaneOne5.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneOne5.Location = new System.Drawing.Point(89, 528);
            this.LaneOne5.Name = "LaneOne5";
            this.LaneOne5.Size = new System.Drawing.Size(15, 90);
            this.LaneOne5.TabIndex = 38;
            this.LaneOne5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneOne4
            // 
            this.LaneOne4.BackColor = System.Drawing.Color.White;
            this.LaneOne4.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneOne4.Location = new System.Drawing.Point(89, 388);
            this.LaneOne4.Name = "LaneOne4";
            this.LaneOne4.Size = new System.Drawing.Size(15, 90);
            this.LaneOne4.TabIndex = 37;
            this.LaneOne4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneOne3
            // 
            this.LaneOne3.BackColor = System.Drawing.Color.White;
            this.LaneOne3.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneOne3.Location = new System.Drawing.Point(89, 248);
            this.LaneOne3.Name = "LaneOne3";
            this.LaneOne3.Size = new System.Drawing.Size(15, 90);
            this.LaneOne3.TabIndex = 36;
            this.LaneOne3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneOne2
            // 
            this.LaneOne2.BackColor = System.Drawing.Color.White;
            this.LaneOne2.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneOne2.Location = new System.Drawing.Point(89, 108);
            this.LaneOne2.Name = "LaneOne2";
            this.LaneOne2.Size = new System.Drawing.Size(15, 90);
            this.LaneOne2.TabIndex = 35;
            this.LaneOne2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaneOne1
            // 
            this.LaneOne1.BackColor = System.Drawing.Color.White;
            this.LaneOne1.ForeColor = System.Drawing.SystemColors.Control;
            this.LaneOne1.Location = new System.Drawing.Point(89, -32);
            this.LaneOne1.Name = "LaneOne1";
            this.LaneOne1.Size = new System.Drawing.Size(15, 90);
            this.LaneOne1.TabIndex = 34;
            this.LaneOne1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MiddleLane
            // 
            this.MiddleLane.BackColor = System.Drawing.Color.White;
            this.MiddleLane.ForeColor = System.Drawing.SystemColors.Control;
            this.MiddleLane.Location = new System.Drawing.Point(184, -4);
            this.MiddleLane.Name = "MiddleLane";
            this.MiddleLane.Size = new System.Drawing.Size(17, 567);
            this.MiddleLane.TabIndex = 33;
            this.MiddleLane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPause
            // 
            this.panelPause.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPause.Controls.Add(this.panelMenu);
            this.panelPause.Controls.Add(this.buttonExit);
            this.panelPause.Controls.Add(this.buttonResume);
            this.panelPause.Controls.Add(this.pictureFlag);
            this.panelPause.Controls.Add(this.labelPause);
            this.panelPause.Location = new System.Drawing.Point(0, 0);
            this.panelPause.Name = "panelPause";
            this.panelPause.Size = new System.Drawing.Size(386, 567);
            this.panelPause.TabIndex = 57;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(119, 481);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 40);
            this.buttonExit.TabIndex = 53;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResume.Location = new System.Drawing.Point(119, 406);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(152, 58);
            this.buttonResume.TabIndex = 52;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // pictureFlag
            // 
            this.pictureFlag.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureFlag.ErrorImage = global::Race.Properties.Resources.RacingFlag;
            this.pictureFlag.Image = global::Race.Properties.Resources.RacingFlag;
            this.pictureFlag.InitialImage = global::Race.Properties.Resources.RacingFlag;
            this.pictureFlag.Location = new System.Drawing.Point(-2, 130);
            this.pictureFlag.Name = "pictureFlag";
            this.pictureFlag.Size = new System.Drawing.Size(386, 315);
            this.pictureFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFlag.TabIndex = 55;
            this.pictureFlag.TabStop = false;
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Microsoft YaHei", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.Location = new System.Drawing.Point(-15, -4);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(422, 159);
            this.labelPause.TabIndex = 54;
            this.labelPause.Text = "Pause";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Controls.Add(this.buttonMenuExit);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.CarMenu1);
            this.panelMenu.Controls.Add(this.CarMenu3);
            this.panelMenu.Controls.Add(this.CarMenu2);
            this.panelMenu.Controls.Add(this.MenuTwoLane5);
            this.panelMenu.Controls.Add(this.MenuTwoLane4);
            this.panelMenu.Controls.Add(this.MenuTwoLane3);
            this.panelMenu.Controls.Add(this.MenuTwoLane2);
            this.panelMenu.Controls.Add(this.MenuTwoLane1);
            this.panelMenu.Controls.Add(this.MenuOneLane5);
            this.panelMenu.Controls.Add(this.MenuOneLane4);
            this.panelMenu.Controls.Add(this.MenuOneLane3);
            this.panelMenu.Controls.Add(this.MenuOneLane2);
            this.panelMenu.Controls.Add(this.MenuOneLane1);
            this.panelMenu.Controls.Add(this.label12);
            this.panelMenu.Location = new System.Drawing.Point(0, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(385, 567);
            this.panelMenu.TabIndex = 56;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(310, 528);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(70, 32);
            this.buttonHelp.TabIndex = 82;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonMenuExit
            // 
            this.buttonMenuExit.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenuExit.Location = new System.Drawing.Point(125, 329);
            this.buttonMenuExit.Name = "buttonMenuExit";
            this.buttonMenuExit.Size = new System.Drawing.Size(132, 47);
            this.buttonMenuExit.TabIndex = 67;
            this.buttonMenuExit.Text = "Exit";
            this.buttonMenuExit.UseVisualStyleBackColor = true;
            this.buttonMenuExit.Click += new System.EventHandler(this.buttonMenuExit_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(111, 263);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 59);
            this.buttonStart.TabIndex = 65;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 105F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 178);
            this.label3.TabIndex = 66;
            this.label3.Text = "Race";
            // 
            // CarMenu1
            // 
            this.CarMenu1.BackColor = System.Drawing.Color.Transparent;
            this.CarMenu1.Image = ((System.Drawing.Image)(resources.GetObject("CarMenu1.Image")));
            this.CarMenu1.Location = new System.Drawing.Point(12, 13);
            this.CarMenu1.Name = "CarMenu1";
            this.CarMenu1.Size = new System.Drawing.Size(50, 110);
            this.CarMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarMenu1.TabIndex = 80;
            this.CarMenu1.TabStop = false;
            // 
            // CarMenu3
            // 
            this.CarMenu3.BackColor = System.Drawing.Color.Transparent;
            this.CarMenu3.Image = ((System.Drawing.Image)(resources.GetObject("CarMenu3.Image")));
            this.CarMenu3.Location = new System.Drawing.Point(322, 26);
            this.CarMenu3.Name = "CarMenu3";
            this.CarMenu3.Size = new System.Drawing.Size(50, 110);
            this.CarMenu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarMenu3.TabIndex = 81;
            this.CarMenu3.TabStop = false;
            // 
            // CarMenu2
            // 
            this.CarMenu2.BackColor = System.Drawing.Color.Transparent;
            this.CarMenu2.Image = ((System.Drawing.Image)(resources.GetObject("CarMenu2.Image")));
            this.CarMenu2.Location = new System.Drawing.Point(129, 3);
            this.CarMenu2.Name = "CarMenu2";
            this.CarMenu2.Size = new System.Drawing.Size(50, 110);
            this.CarMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarMenu2.TabIndex = 79;
            this.CarMenu2.TabStop = false;
            // 
            // MenuTwoLane5
            // 
            this.MenuTwoLane5.BackColor = System.Drawing.Color.White;
            this.MenuTwoLane5.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuTwoLane5.Location = new System.Drawing.Point(289, 518);
            this.MenuTwoLane5.Name = "MenuTwoLane5";
            this.MenuTwoLane5.Size = new System.Drawing.Size(15, 90);
            this.MenuTwoLane5.TabIndex = 78;
            this.MenuTwoLane5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuTwoLane4
            // 
            this.MenuTwoLane4.BackColor = System.Drawing.Color.White;
            this.MenuTwoLane4.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuTwoLane4.Location = new System.Drawing.Point(289, 378);
            this.MenuTwoLane4.Name = "MenuTwoLane4";
            this.MenuTwoLane4.Size = new System.Drawing.Size(15, 90);
            this.MenuTwoLane4.TabIndex = 77;
            this.MenuTwoLane4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuTwoLane3
            // 
            this.MenuTwoLane3.BackColor = System.Drawing.Color.White;
            this.MenuTwoLane3.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuTwoLane3.Location = new System.Drawing.Point(289, 238);
            this.MenuTwoLane3.Name = "MenuTwoLane3";
            this.MenuTwoLane3.Size = new System.Drawing.Size(15, 90);
            this.MenuTwoLane3.TabIndex = 76;
            this.MenuTwoLane3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuTwoLane2
            // 
            this.MenuTwoLane2.BackColor = System.Drawing.Color.White;
            this.MenuTwoLane2.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuTwoLane2.Location = new System.Drawing.Point(289, 98);
            this.MenuTwoLane2.Name = "MenuTwoLane2";
            this.MenuTwoLane2.Size = new System.Drawing.Size(15, 90);
            this.MenuTwoLane2.TabIndex = 75;
            this.MenuTwoLane2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuTwoLane1
            // 
            this.MenuTwoLane1.BackColor = System.Drawing.Color.White;
            this.MenuTwoLane1.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuTwoLane1.Location = new System.Drawing.Point(289, -42);
            this.MenuTwoLane1.Name = "MenuTwoLane1";
            this.MenuTwoLane1.Size = new System.Drawing.Size(15, 90);
            this.MenuTwoLane1.TabIndex = 74;
            this.MenuTwoLane1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuOneLane5
            // 
            this.MenuOneLane5.BackColor = System.Drawing.Color.White;
            this.MenuOneLane5.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOneLane5.Location = new System.Drawing.Point(89, 518);
            this.MenuOneLane5.Name = "MenuOneLane5";
            this.MenuOneLane5.Size = new System.Drawing.Size(15, 90);
            this.MenuOneLane5.TabIndex = 73;
            this.MenuOneLane5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuOneLane4
            // 
            this.MenuOneLane4.BackColor = System.Drawing.Color.White;
            this.MenuOneLane4.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOneLane4.Location = new System.Drawing.Point(89, 378);
            this.MenuOneLane4.Name = "MenuOneLane4";
            this.MenuOneLane4.Size = new System.Drawing.Size(15, 90);
            this.MenuOneLane4.TabIndex = 72;
            this.MenuOneLane4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuOneLane3
            // 
            this.MenuOneLane3.BackColor = System.Drawing.Color.White;
            this.MenuOneLane3.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOneLane3.Location = new System.Drawing.Point(89, 238);
            this.MenuOneLane3.Name = "MenuOneLane3";
            this.MenuOneLane3.Size = new System.Drawing.Size(15, 90);
            this.MenuOneLane3.TabIndex = 71;
            this.MenuOneLane3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuOneLane2
            // 
            this.MenuOneLane2.BackColor = System.Drawing.Color.White;
            this.MenuOneLane2.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOneLane2.Location = new System.Drawing.Point(89, 98);
            this.MenuOneLane2.Name = "MenuOneLane2";
            this.MenuOneLane2.Size = new System.Drawing.Size(15, 90);
            this.MenuOneLane2.TabIndex = 70;
            this.MenuOneLane2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuOneLane1
            // 
            this.MenuOneLane1.BackColor = System.Drawing.Color.White;
            this.MenuOneLane1.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOneLane1.Location = new System.Drawing.Point(89, -42);
            this.MenuOneLane1.Name = "MenuOneLane1";
            this.MenuOneLane1.Size = new System.Drawing.Size(15, 90);
            this.MenuOneLane1.TabIndex = 69;
            this.MenuOneLane1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(184, -4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 567);
            this.label12.TabIndex = 68;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTowardCars
            // 
            this.timerTowardCars.Enabled = true;
            this.timerTowardCars.Interval = 1;
            this.timerTowardCars.Tick += new System.EventHandler(this.timerTowardCars_Tick);
            // 
            // timerMenu
            // 
            this.timerMenu.Enabled = true;
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // RaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.panelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "RaceGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race";
            this.Load += new System.EventHandler(this.RaceGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaceGame_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.towardCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towardCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towardCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).EndInit();
            this.panelPause.ResumeLayout(false);
            this.panelPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarMenu2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerRoad;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label LaneTwo5;
        private System.Windows.Forms.Label LaneTwo4;
        private System.Windows.Forms.Label LaneTwo3;
        private System.Windows.Forms.Label LaneTwo2;
        private System.Windows.Forms.Label LaneTwo1;
        private System.Windows.Forms.Label LaneOne5;
        private System.Windows.Forms.Label LaneOne4;
        private System.Windows.Forms.Label LaneOne3;
        private System.Windows.Forms.Label LaneOne2;
        private System.Windows.Forms.Label LaneOne1;
        private System.Windows.Forms.Label MiddleLane;
        private System.Windows.Forms.PictureBox towardCar2;
        private System.Windows.Forms.PictureBox towardCar3;
        private System.Windows.Forms.PictureBox towardCar1;
        private System.Windows.Forms.PictureBox mainCar;
        private System.Windows.Forms.Timer timerTowardCars;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.PictureBox pictureFlag;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMenuExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox CarMenu1;
        private System.Windows.Forms.PictureBox CarMenu3;
        private System.Windows.Forms.PictureBox CarMenu2;
        private System.Windows.Forms.Label MenuTwoLane5;
        private System.Windows.Forms.Label MenuTwoLane4;
        private System.Windows.Forms.Label MenuTwoLane3;
        private System.Windows.Forms.Label MenuTwoLane2;
        private System.Windows.Forms.Label MenuTwoLane1;
        private System.Windows.Forms.Label MenuOneLane5;
        private System.Windows.Forms.Label MenuOneLane4;
        private System.Windows.Forms.Label MenuOneLane3;
        private System.Windows.Forms.Label MenuOneLane2;
        private System.Windows.Forms.Label MenuOneLane1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonHelp;
    }
}

