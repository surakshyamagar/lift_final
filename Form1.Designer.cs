namespace lift___sir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainElevetor = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_up = new Button();
            btn_down = new Button();
            btn_close_G = new Button();
            btn_open = new Button();
            liftTimer = new System.Windows.Forms.Timer(components);
            doorRight_G = new PictureBox();
            doorLeft_G = new PictureBox();
            doorLeft1 = new PictureBox();
            doorRight1 = new PictureBox();
            pictureBox5 = new PictureBox();
            doorTimer = new System.Windows.Forms.Timer(components);
            dataGridViewLogs = new DataGridView();
            btnDelete = new Button();
            liftTimerDown = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)mainElevetor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorRight_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorLeft_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorLeft1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorRight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            SuspendLayout();
            // 
            // mainElevetor
            // 
            mainElevetor.BackgroundImage = (Image)resources.GetObject("mainElevetor.BackgroundImage");
            mainElevetor.BackgroundImageLayout = ImageLayout.Stretch;
            mainElevetor.Location = new Point(101, 265);
            mainElevetor.Name = "mainElevetor";
            mainElevetor.Size = new Size(164, 184);
            mainElevetor.TabIndex = 0;
            mainElevetor.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(360, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 287);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btn_up
            // 
            btn_up.BackgroundImage = (Image)resources.GetObject("btn_up.BackgroundImage");
            btn_up.BackgroundImageLayout = ImageLayout.Stretch;
            btn_up.Location = new Point(383, 82);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(90, 71);
            btn_up.TabIndex = 2;
            btn_up.UseVisualStyleBackColor = true;
            btn_up.Click += button1_Click;
            // 
            // btn_down
            // 
            btn_down.BackgroundImage = (Image)resources.GetObject("btn_down.BackgroundImage");
            btn_down.BackgroundImageLayout = ImageLayout.Stretch;
            btn_down.Location = new Point(383, 161);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(90, 73);
            btn_down.TabIndex = 3;
            btn_down.UseVisualStyleBackColor = true;
            btn_down.Click += btn_g_click;
            // 
            // btn_close_G
            // 
            btn_close_G.BackgroundImage = (Image)resources.GetObject("btn_close_G.BackgroundImage");
            btn_close_G.BackgroundImageLayout = ImageLayout.Stretch;
            btn_close_G.Location = new Point(371, 285);
            btn_close_G.Name = "btn_close_G";
            btn_close_G.Size = new Size(59, 52);
            btn_close_G.TabIndex = 4;
            btn_close_G.UseVisualStyleBackColor = true;
            btn_close_G.Click += btn_Close_Click;
            // 
            // btn_open
            // 
            btn_open.BackgroundImage = (Image)resources.GetObject("btn_open.BackgroundImage");
            btn_open.BackgroundImageLayout = ImageLayout.Stretch;
            btn_open.Location = new Point(440, 285);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(58, 52);
            btn_open.TabIndex = 5;
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_Open_CLick;
            // 
            // liftTimer
            // 
            liftTimer.Tick += liftTimer_Tick;
            // 
            // doorRight_G
            // 
            doorRight_G.BackgroundImage = (Image)resources.GetObject("doorRight_G.BackgroundImage");
            doorRight_G.BackgroundImageLayout = ImageLayout.Stretch;
            doorRight_G.Location = new Point(178, 265);
            doorRight_G.Name = "doorRight_G";
            doorRight_G.Size = new Size(87, 184);
            doorRight_G.TabIndex = 6;
            doorRight_G.TabStop = false;
            // 
            // doorLeft_G
            // 
            doorLeft_G.BackgroundImage = (Image)resources.GetObject("doorLeft_G.BackgroundImage");
            doorLeft_G.BackgroundImageLayout = ImageLayout.Stretch;
            doorLeft_G.Location = new Point(101, 265);
            doorLeft_G.Name = "doorLeft_G";
            doorLeft_G.Size = new Size(83, 184);
            doorLeft_G.TabIndex = 7;
            doorLeft_G.TabStop = false;
            // 
            // doorLeft1
            // 
            doorLeft1.BackgroundImage = (Image)resources.GetObject("doorLeft1.BackgroundImage");
            doorLeft1.BackgroundImageLayout = ImageLayout.Stretch;
            doorLeft1.Location = new Point(101, 2);
            doorLeft1.Name = "doorLeft1";
            doorLeft1.Size = new Size(83, 184);
            doorLeft1.TabIndex = 10;
            doorLeft1.TabStop = false;
            // 
            // doorRight1
            // 
            doorRight1.BackgroundImage = (Image)resources.GetObject("doorRight1.BackgroundImage");
            doorRight1.BackgroundImageLayout = ImageLayout.Stretch;
            doorRight1.Location = new Point(178, 2);
            doorRight1.Name = "doorRight1";
            doorRight1.Size = new Size(87, 184);
            doorRight1.TabIndex = 9;
            doorRight1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(101, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(164, 184);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // doorTimer
            // 
            doorTimer.Interval = 50;
            doorTimer.Tick += door_timer_Tick;
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(537, 66);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.RowHeadersWidth = 51;
            dataGridViewLogs.Size = new Size(251, 307);
            dataGridViewLogs.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            // 
            // liftTimerDown
            // 
            liftTimerDown.Tick += liftTimerDown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewLogs);
            Controls.Add(doorLeft1);
            Controls.Add(doorRight1);
            Controls.Add(pictureBox5);
            Controls.Add(doorLeft_G);
            Controls.Add(doorRight_G);
            Controls.Add(btn_open);
            Controls.Add(btn_close_G);
            Controls.Add(btn_down);
            Controls.Add(btn_up);
            Controls.Add(pictureBox2);
            Controls.Add(mainElevetor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)mainElevetor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorRight_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorLeft_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorLeft1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorRight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainElevetor;
        private PictureBox pictureBox2;
        private Button btn_up;
        private Button btn_down;
        private Button btn_close_G;
        private Button btn_open;
        private System.Windows.Forms.Timer liftTimer;
        private PictureBox doorRight_G;
        private PictureBox doorLeft_G;
        private PictureBox doorLeft1;
        private PictureBox doorRight1;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer doorTimer;
        private DataGridView dataGridViewLogs;
        private Button btnDelete;
        private System.Windows.Forms.Timer liftTimerDown;
    }
}
