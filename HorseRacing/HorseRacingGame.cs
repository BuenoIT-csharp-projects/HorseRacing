/*
 * 
 * File Name: HorseRacingGame.cs
 * Description: An interactive horse racing game with timestamps and general features
 * 
 * Project Revision:
 *      Guilherme Bueno, 2022.10.28: Created
 *      
 * 
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class HorseRacingGame : Form
    {
        //Initialize Horse Class and general variables
        Horse Horse1;
        Horse Horse2;
        Horse Horse3;
        DateTime startTime;
        double horse1Time;
        double horse2Time;
        double horse3Time;
        double horse1Speed;
        double horse2Speed;
        double horse3Speed;


        public HorseRacingGame()
        {
            InitializeComponent();

            //Horse 1 Set Up
            Horse1 = new Horse();
            pic_horse1.BackColor = Color.Transparent;
            Horse1.horsePictureBox = pic_horse1;
            Horse1.InitialPositionX = 66;
            Horse1.InitialPositionY = 332;
            Horse1.EndPositionX = 315;
            Horse1.EndPositionY = 400;

            //Horse 2 Set Up
            Horse2 = new Horse();
            Horse2.horsePictureBox = pic_horse2;
            Horse2.InitialPositionX = 117;
            Horse2.InitialPositionY = 332;
            Horse2.EndPositionX = 315;
            Horse2.EndPositionY = 400;

            //Horse 3 Set Up
            Horse3 = new Horse();
            Horse3.horsePictureBox = pic_horse3;
            Horse3.InitialPositionX = 169;
            Horse3.InitialPositionY = 332;
            Horse3.EndPositionX = 315;
            Horse3.EndPositionY = 400;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //Start Timer
            timer1.Enabled = true;

            //Get time now
            startTime = DateTime.Now;

            // Disable buttons + Layout adjustment
            btn_start.Enabled = false;
            btn_start.ForeColor = Color.DarkGray;
            btn_start.BackColor = Color.Gray;

            btn_restart.Enabled = false;
            btn_restart.ForeColor = Color.DarkGray;
            btn_restart.BackColor = Color.Gray;
        }


        private void btn_restart_Click(object sender, EventArgs e)
        {
            //Clean Labels
            lbl_winnerName.Text = "";
            lbl_timingWinner.Text = "";
            lbl_speedWinner.Text = "";
            lbl_speed1.Text = "";
            lbl_speed2.Text = "";
            lbl_speed3.Text = "";
            lbl_timing1.Text = "";
            lbl_timing2.Text = "";
            lbl_timing3.Text = "";

            // Enable buttons + Layout adjustment
            btn_start.Enabled = true;
            btn_start.ForeColor = Color.White;
            btn_start.BackColor = Color.CornflowerBlue;

            btn_restart.Enabled = false;
            btn_restart.ForeColor = Color.DarkGray;
            btn_restart.BackColor = Color.Gray;

            //Change Horses location
            Horse1.ReturnToInitialPosition();
            Horse2.ReturnToInitialPosition();
            Horse3.ReturnToInitialPosition();

            pic_horse1.Image = Image.FromFile(Application.StartupPath + "\\" + "Horse_1.gif");
            pic_horse2.Image = Image.FromFile(Application.StartupPath + "\\" + "Horse_2.gif");
            pic_horse3.Image = Image.FromFile(Application.StartupPath + "\\" + "Horse_3.gif");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //If Horse 1 hasn't passed the end point keep running

            if (!Horse1.isHorseEnd)
            {
                Horse1.Run();
            }

            //If Horse 2 hasn't passed the end point keep running

            if (!Horse2.isHorseEnd)
            {
                Horse2.Run();
            }

            //If Horse 3 hasn't passed the end point keep running

            if (!Horse3.isHorseEnd)
            {
                Horse3.Run();
            }

            //Rotate Picture Box Horses

            if (Horse1.canHorsePictureRotate == 1)
            {
                pic_horse1.Image = Image.FromFile(Application.StartupPath + "\\" + "Horse_1L.gif");
            }
            if (Horse2.canHorsePictureRotate == 1)
            {
                pic_horse2.Image = Image.FromFile(Application.StartupPath + "\\" + "Horse_2L.gif");
            }
            if (Horse3.canHorsePictureRotate == 1)
            {
                pic_horse3.Image = Image.FromFile(Application.StartupPath + "\\" + "Horse_3L.gif");
            }



            //If All horses passed the end point
            if (Horse3.isHorseEnd && Horse2.isHorseEnd && Horse1.isHorseEnd)
            {

                //Getting racing timing and speed for horse 1
                horse1Time = Math.Round((Horse1.EndTiming - startTime).TotalSeconds, 1);
                horse1Speed = Math.Round(Horse1.speed, 2) * 1000;

                //Getting racing timing and speed for horse 2
                horse2Time = Math.Round((Horse2.EndTiming - startTime).TotalSeconds, 1);
                horse2Speed = Math.Round(Horse2.speed, 2) * 1000;

                //Getting racing timing and speed for horses 3
                horse3Time = Math.Round((Horse3.EndTiming - startTime).TotalSeconds, 1);
                horse3Speed = Math.Round(Horse3.speed, 2) * 1000;

                //Stop timer
                timer1.Enabled = false;

                // Enable buttons + Layout adjustment
                btn_restart.Enabled = true;
                btn_restart.ForeColor = Color.White;
                btn_restart.BackColor = Color.CornflowerBlue;


                //Check Winner and update labels
                if (horse1Time < horse2Time && horse1Time < horse3Time)
                {
                    lbl_winnerName.Text = "Horse 1";
                    lbl_timingWinner.Text = $"{horse1Time}s";
                    lbl_speedWinner.Text = $"{horse1Speed}";
                }
                else if (horse2Time < horse1Time && horse2Time < horse3Time)
                {
                    lbl_winnerName.Text = "Horse 2";
                    lbl_timingWinner.Text = $"{horse2Time}s";
                    lbl_speedWinner.Text = $"{horse2Speed}";
                }
                else if (horse3Time < horse1Time && horse3Time < horse2Time)
                {
                    lbl_winnerName.Text = "Horse 3";
                    lbl_timingWinner.Text = $"{horse3Time}s";
                    lbl_speedWinner.Text = $"{horse3Speed}";
                }
                else
                {
                    lbl_winnerName.Text = "Tied Game";
                }

                //Update Horses Metrics Labels
                lbl_speed1.Text = horse1Speed.ToString();
                lbl_speed2.Text = horse2Speed.ToString();
                lbl_speed3.Text = horse3Speed.ToString();

                lbl_timing1.Text = horse1Time.ToString();
                lbl_timing2.Text = horse2Time.ToString();
                lbl_timing3.Text = horse3Time.ToString();
            }

        }
    }
}
