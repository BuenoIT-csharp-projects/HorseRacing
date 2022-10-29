/*
 * 
 * File Name: Horse.cs
 * Description: An interactive horse racing game with timestamps and general features
 * 
 * Project Revision:
 *      Guilherme Bueno, 2022.10.28: Created
 *      
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HorseRacing
{
    internal class Horse
    {
        //Variables initialization for Horse Class
        public int InitialPositionX;
        public int InitialPositionY;
        public int EndPositionX;
        public int EndPositionY;
        public PictureBox horsePictureBox;
        public double speed;
        public Random RandomNum;
        public DateTime EndTiming;
        public double angle = 179.3;
        public double radius = 0;
        public bool isHorseEnd = false;
        public int canHorsePictureRotate = 0;
        Point p;

        //Method to make the horse Run
        public bool Run()
        {
            //// Speed Calculation
            RandomNum = new Random();
            speed = RandomNum.Next(1, 5);
            speed = speed / 100;

            //Horse picture moviments
            p = horsePictureBox.Location;


            //Define Radius for each horse
            if (InitialPositionX == 66)
            {
                radius = 270;
            }
            else if (InitialPositionX == 117)
            {
                radius = 220;
            }
            else if (InitialPositionX == 169)
            {
                radius = 170;
            }

            //Move Horse
            double px = 680 / 2 + Math.Cos(angle) * radius;
            double py = 670 / 2 + Math.Sin(angle) * radius;
            angle = angle + speed; // Speed definition

            p.X = Convert.ToInt32(px);
            p.Y = Convert.ToInt32(py);

            horsePictureBox.Location = p;

            //Rotate Image
            if (p.Y >= 332)
            {
                canHorsePictureRotate++;
            }


            //Check if it is the winner
            if (p.X <= EndPositionX && p.Y >= EndPositionY)
            {
                EndTiming = DateTime.Now;
                isHorseEnd = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to restart position of Horse
        public void ReturnToInitialPosition()
        {
            p = horsePictureBox.Location;

            p.X = InitialPositionX;
            p.Y = InitialPositionY;

            horsePictureBox.Location = p;

            isHorseEnd = false;

            angle = 179.3;

            canHorsePictureRotate = 0;
        }
    }
}
