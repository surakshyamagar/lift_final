using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace lift___sir
{
    public partial class Form1 : Form
    {
        //bool isMovingUp = false;
        //bool isMovingDown = false; //va
        int liftSpeed = 5;

        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 5;

        int doorMaxOpenWidth;

        private Lift lift;
        DataTable dt = new DataTable();
        Database db = new Database();


        public Form1()
        {
            InitializeComponent();

            lift = new Lift(mainElevetor, btn_up, btn_down, this.ClientSize.Height, liftSpeed, liftTimer, liftTimerDown);


            doorMaxOpenWidth = mainElevetor.Width / 2 - 10; // boundry select

            dataGridViewLogs.ColumnCount = 2;

            dataGridViewLogs.Columns[0].Name = "Time";
            dataGridViewLogs.Columns[1].Name = "Events";

            dt.Columns.Add("LogTime");
            dt.Columns.Add("eventdescription");
        }

        private void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            dt.Rows.Add(currentTime, message);
            dataGridViewLogs.Rows.Add(currentTime, message);

            db.InsertLogsIntoDB(dt);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            db.loadLogsFromDB(dt, dataGridViewLogs);
        }



        private void button1_Click(object sender, EventArgs e) //sdf meth
        {
            //isMovingUp = true;
            //isMovingDown = false;
            lift.SetState(new MovingUpState());
            liftTimer.Start();
            btn_down.Enabled = false;
            logEvents("Lift going up");
        }



        public void btn_g_click(object sender, EventArgs e)
        {
            //isMovingUp = false;
            //isMovingDown = true;
            //liftTimer.Start();
            //btn_up.Enabled = false;
            lift.SetState(new MovingDownState());

            lift.LiftTimerDown.Start();
            logEvents("Lift coming down");
        }

        public void liftTimer_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
        }

        public void liftTimerDown_Tick(object sender, EventArgs e)
        {
            lift.MovingDown();
        }

        private void btn_Open_CLick(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            doorTimer.Start();
            btn_close_G.Enabled = false;
            logEvents("Lift opens up");
        }



        public void btn_Close_Click(object sender, EventArgs e)
        {
            isClosing = true;
            isOpening = false;
            doorTimer.Start();
            logEvents("Lift closing");
        }

        private void door_timer_Tick(object sender, EventArgs e)
        {
            if (mainElevetor.Top != 0)
            {


                if (isOpening)
                {
                    if (doorLeft_G.Left > doorMaxOpenWidth / 2)// pix
                    {
                        doorLeft_G.Left -= doorSpeed;
                        doorRight_G.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_close_G.Enabled = true;
                    }

                }

                if (isClosing)
                {
                    if (doorLeft_G.Right < mainElevetor.Width + doorMaxOpenWidth / 2 - 20)
                    {
                        doorLeft_G.Left += doorSpeed;
                        doorRight_G.Left -= doorSpeed;

                    }
                    else
                    {
                        doorTimer.Stop();

                    }


                }

            }
            else
            {
                if (isOpening)
                {
                    if (doorLeft1.Left > doorMaxOpenWidth / 2)// pix
                    {
                        doorLeft1.Left -= doorSpeed;
                        doorRight1.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_close_G.Enabled = true;
                    }

                }

                if (isClosing)
                {
                    //if (doorLeft1.Right < mainElevetor.Width + doorMaxOpenWidth / 2)
                    if (doorLeft1.Right < mainElevetor.Width + doorMaxOpenWidth / 2 - 20)
                    {
                        doorLeft1.Left += doorSpeed;
                        doorRight1.Left -= doorSpeed;

                    }
                    else
                    {
                        doorTimer.Stop();

                    }
                }
            }
        }



      

          
        }
    }


