using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;


namespace TankBattle
{

    enum PowerState
    {
        Up,
        Down,
        None
    }
    enum AngleState
    {
        Up,
        Down,
        None
    }

    public partial class Form1 : Form
    {

        PowerState Power1State = PowerState.None;
        PowerState Power2State = PowerState.None;
        AngleState Angle1State = AngleState.None;
        AngleState Angle2State = AngleState.None;

        const float Gravity = 0.08f;
        const float VelocityMultiplier = 0.125f;
        const float WindStrengthMultiplier = 0.004f;

        Vector2 Position;
        Vector2 Velocity;
        PointF RedCannonStart;
        PointF GreenCannonStart;
        PointF RedCannonEnd;
        PointF GreenCannonEnd;
        float WindStrength = 0;
        int P1Power = 0;
        int P1AngleInt = 0;
        int P2Power = 0;
        int P2AngleInt = 0;
        bool P1Ready = false;
        bool P2Ready = false;
        bool IsP1Shooting = false;

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
           
            P1Power = 0;
            P1AngleInt = 0;
            P2Power = 0;
            P2AngleInt = 0;
          
            lblCurrentStage.Text = "Planning Stage";
            lblP1Angle.Text = "Angle = 0 degrees";
            lblP2Angle.Text = "Angle = 0 degrees";
            lblP1Power.Text = "Power = 0%";
            lblP2Power.Text = "Power = 0%";
        
            picP1Health.Width = 156;
            picP2Health.Width = 156;

            //make bullet invisible
            picBullet.Visible = false;

            //randomize who has high ground, where the tanks are
            RandomizeSides();
            RandomizeTankPlacement();

            //redraw tank cannons
            this.Refresh();

            StartPlanningStage();
        }

        private void RandomizeSides()
        {
            int CoinFlip = r.Next(2); //random number from 1 to 2

            if (CoinFlip == 1) //red has the high ground
            {
                //move the ground picboxes
                picHighGround.Left = 0;
                picHighGround.Top = 650;
                picLowGround.Left = 645;
                picLowGround.Top = 750;
                //move the tanks
                picRedTankTop.Top = 628;
                picRedTankBottom.Top = 637;
                picGreenTankTop.Top = 728;
                picGreenTankBottom.Top = 737;
                //move power and angle labels
                lblP1Angle.Top = 664;
                lblP1Power.Top = 691;
                lblP2Angle.Top = 765;
                lblP2Power.Top = 792;
            }
            else //green has the high ground
            {
                //move the ground picboxes
                picHighGround.Left = 535;
                picHighGround.Top = 650;
                picLowGround.Left = 0;
                picLowGround.Top = 750;
                //move the tanks
                picRedTankTop.Top = 728;
                picRedTankBottom.Top = 737;
                picGreenTankTop.Top = 628;
                picGreenTankBottom.Top = 637;
                //move power and angle labels
                lblP1Angle.Top = 765;
                lblP1Power.Top = 792;
                lblP2Angle.Top = 664;
                lblP2Power.Top = 691;
            }
        }

        private void RandomizeTankPlacement()
        {
            int RandPlace = r.Next(50, 400); //random number based on acceptable boundaries of left side
            //set horizontal position of red tank
            picRedTankTop.Left = RandPlace + 8;
            picRedTankBottom.Left = RandPlace;

            RandPlace = r.Next(780, 1120); //random number based on acceptable boundaries of left side
            //set horizontal position of green tank
            picGreenTankTop.Left = RandPlace + 16;
            picGreenTankBottom.Left = RandPlace;

            //set the point for where the cannon starts to make it inside of the top of the tank
            RedCannonStart = new PointF(picRedTankTop.Right - 4, picRedTankTop.Top + 4);
            GreenCannonStart = new PointF(picGreenTankTop.Left + 4, picGreenTankTop.Top + 4);
        }

        private void StartPlanningStage()
        {
            //reset ready bools and ready pictures
            P1Ready = false;
            P2Ready = false;
            picP1Ready.Image = Resource1.EmptyCheck;
            picP2Ready.Image = Resource1.EmptyCheck;
            //make all labels and pictures neccessary for the Planning Stage visible
            LabelVisibility(true);

            //enable planning timer
            tmrPlanning.Enabled = true;

            //randomize wind
            RandomizeWind();
        }

        private void RandomizeWind()
        {
            int RandWind = r.Next(-125, 125); //based size of each wind bar (125)
            WindStrength = (float)RandWind * WindStrengthMultiplier; //this is the value used for velocity calculations

            //SETTING WIND ARROWS
            //default values with arrows completely covered
            picWindCoverLeft.Left = 468;
            picWindCoverLeft.Width = 125;
            picWindCoverRight.Left = 595;
            picWindCoverRight.Width = 125;
            
            if (RandWind > 0) 
            {
                //if it's blowing to the right: partially cover right side by moving cover over and making it shorter
                picWindCoverRight.Left += RandWind;
                picWindCoverRight.Width -= RandWind;
            }
            else if (RandWind < 0) 
            {
                //if it's blowing to the left: change width of left cover to partially cover left side
                picWindCoverLeft.Width += RandWind;
            }
        }

        private void StartShootingStage()
        {
            //make Planning Stage labels,picboxes invisible
            LabelVisibility(false);

            //set stage label to shoot
            lblCurrentStage.Text = "Shoot!";

            //reset power states for next planning stage
            Power1State = PowerState.None;
            Power2State = PowerState.None;
            Angle1State = AngleState.None;
            Angle2State = AngleState.None;
            
            tmrPlanning.Enabled = false; //turn off planning timer
            IsP1Shooting = true; //set shooter to P1

            //do shooting calculations using given Power and Angle
            CalculateShooting((float)P1Power, (float)P1AngleInt);
        }

        private void CalculateShooting(float Power, float Angle)
        {
            //POSITION CALCULATIONS --------------------------------------

            //set bullet position to tanks barrel based on whos shooting
            if (IsP1Shooting == true) Position = new Vector2(RedCannonEnd.X, RedCannonEnd.Y);
            else Position = new Vector2(GreenCannonEnd.X, GreenCannonEnd.Y);

            //make the position where the bullet appears
            picBullet.Left = (int)Position.X;
            picBullet.Top = (int)Position.Y;

            //VELOCITY CALCULATIONS --------------------------------------

            //convert angle to radians
            Angle = MathHelper.ToRadians(Angle);

            //calculate x,y initial velocity based on power and angle
            float VelocityX = Power * (float)Math.Cos(Angle) * VelocityMultiplier;
            float VelocityY = Power * (float)Math.Sin(Angle) * VelocityMultiplier;

            //flip y velocity to make it arc upwards instead of downward
            VelocityY *= -1;

            //if P2 is shooting, flip the x veocity so it shoots the other way
            if (IsP1Shooting == false) VelocityX *= -1;

            //add wind to change the X velocity
            VelocityX += WindStrength;

            //make velocity into vector
            Velocity = new Vector2(VelocityX, VelocityY);

            //make bullet visible and start shooting timer
            picBullet.Visible = true;
            tmrShoot.Enabled = true;
        }

        private void P2Shoot()
        {
            //this method only gets called after the P1 bullet hits something
            IsP1Shooting = false; //set shooter to P2

            //do shooting calculations using P2's angle and power
            CalculateShooting((float)P2Power, (float)P2AngleInt);
        }

     
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
  
            if (e.KeyCode == Keys.Enter && tmrPlanning.Enabled == false && tmrShoot.Enabled == false)
            {
                mnuGameReset.Enabled = true;
                Reset();
            }

            if (tmrPlanning.Enabled == true)
            {
        
                if (e.KeyCode == Keys.R) // Player 1 Ready
                {
                    if (P1Ready == false)
                    {
                        if (P2Ready) StartShootingStage();
                        else
                        {
                            P1Ready = true;
                            picP1Ready.Image = Resource1.RedCheck;
                        }
                    }
                    else
                    {
                        P1Ready = false;
                        picP1Ready.Image = Resource1.EmptyCheck;
                    }
                }
                else if (e.KeyCode == Keys.M) // Player 2 Ready
                {
                    if (P2Ready == false)
                    {
                        if (P1Ready) StartShootingStage(); 
                        else
                        {
                            P2Ready = true;
                            picP2Ready.Image = Resource1.GreenCheck;
                        }
                    }
                    else
                    {
                        P2Ready = false;
                        picP2Ready.Image = Resource1.EmptyCheck;
                    }
                }

     
                else if (e.KeyCode == Keys.A) 
                {
                    picRedTankTop.Left -= 5;
                    picRedTankBottom.Left -= 5;
                    RedCannonStart = new PointF(picRedTankTop.Right - 4, picRedTankTop.Top + 4);
                    this.Refresh();
                }
                else if (e.KeyCode == Keys.D) 
                {
                    picRedTankTop.Left += 5;
                    picRedTankBottom.Left += 5;
                    RedCannonStart = new PointF(picRedTankTop.Right - 4, picRedTankTop.Top + 4);
                    this.Refresh();
                }
                else if (e.KeyCode == Keys.X) 
                {
                    if (P1Power < 100) P1Power++;
                    lblP1Power.Text = "Power = " + P1Power + "%";
                }
                else if (e.KeyCode == Keys.Z) 
                {
                    if (P1Power > 0) P1Power--;
                    lblP1Power.Text = "Power = " + P1Power + "%";
                }
                else if (e.KeyCode == Keys.W) 
                {
                    if (P1AngleInt < 90) P1AngleInt++;
                    lblP1Angle.Text = "Angle = " + P1AngleInt + " degrees";
                    this.Refresh();
                }
                else if (e.KeyCode == Keys.S) 
                {
                    if (P1AngleInt > 0) P1AngleInt--;
                    lblP1Angle.Text = "Angle = " + P1AngleInt + " degrees";
                    this.Refresh();
                }

                
                else if (e.KeyCode == Keys.Left) 
                {
                    picGreenTankTop.Left -= 5;
                    picGreenTankBottom.Left -= 5;
                    GreenCannonStart = new PointF(picGreenTankTop.Left + 4, picGreenTankTop.Top + 4);
                    this.Refresh();
                }
                else if (e.KeyCode == Keys.Right) 
                {
                    picGreenTankTop.Left += 5;
                    picGreenTankBottom.Left += 5;
                    GreenCannonStart = new PointF(picGreenTankTop.Left + 4, picGreenTankTop.Top + 4);
                    this.Refresh();
                }
                else if (e.KeyCode == Keys.L) 
                {
                    if (P2Power < 100) P2Power++;
                    lblP2Power.Text = "Power = " + P2Power + "%";
                }
                else if (e.KeyCode == Keys.K) 
                {
                    if (P2Power > 0) P2Power--;
                    lblP2Power.Text = "Power = " + P2Power + "%";
                }
                else if (e.KeyCode == Keys.Up) 
                {
                    if (P2AngleInt < 90) P2AngleInt++;
                    lblP2Angle.Text = "Angle = " + P2AngleInt + " degrees";
                    this.Refresh();
                }
                else if (e.KeyCode == Keys.Down) 
                {
                    if (P2AngleInt > 0) P2AngleInt--;
                    lblP2Angle.Text = "Angle = " + P2AngleInt + " degrees";
                    this.Refresh();
                }
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tmrPlanning.Enabled == true)
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.D || e.KeyCode == Keys.W || e.KeyCode == Keys.S) Power1State = PowerState.None;
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) Power2State = PowerState.None;
            }
        }



        private void tmrShoot_Tick(object sender, EventArgs e) //controls shooting stage
        {
            //every tick, add velovity and gravity to position
            Position += Velocity;
            Velocity.Y += Gravity;

            //limit velocity Y so its impossible to fly over the tank hitbox (13px)
            if (Velocity.Y > 12.9f) Velocity.Y = 12.9f;

            //set bullet's position to match vector
            picBullet.Left = (int)Position.X;
            picBullet.Top = (int)Position.Y;

            //on collision with ground or wall or flys out of sides of window
            if (picBullet.Bounds.IntersectsWith(picHighGround.Bounds) || 
                picBullet.Bounds.IntersectsWith(picLowGround.Bounds) || 
                picBullet.Bounds.IntersectsWith(picWallHitBox.Bounds) || 
                picBullet.Left < -5 || 
                picBullet.Left > ClientSize.Width)
            {
                ShotFinished(); //switch whos shooting or end stage if both players shot
            }

            //if red bullet hits green tank
            else if (IsP1Shooting && (picBullet.Bounds.IntersectsWith(picGreenTankBottom.Bounds) || picBullet.Bounds.IntersectsWith(picGreenTankTop.Bounds)))
            {
                picP2Health.Width -= 52; //shorten the green health bar by a third of it

                //if green has no more health, red wins
                if (picP2Health.Width == 0)
                {
                    EndGame();
                    MessageBox.Show("Red wins!");
                }
                else { ShotFinished(); } //switch whos shooting or end stage if both players shot
            }

            //if green bullet hits red tank
            else if (IsP1Shooting == false && (picBullet.Bounds.IntersectsWith(picRedTankBottom.Bounds) || IsP1Shooting == false && picBullet.Bounds.IntersectsWith(picRedTankTop.Bounds)))
            {
                picP1Health.Width -= 52; //shorten the red health bar by a third of it

                //if red has no more health, green wins
                if (picP1Health.Width == 0)
                {
                    EndGame();
                    MessageBox.Show("Green wins!");
                }
                else { ShotFinished(); } //switch whos shooting or end stage if both players shot
            }
        }

        private void EndGame()
        {
            //when game ends, turn off all timers
            tmrPlanning.Enabled = false;
            tmrShoot.Enabled = false;
            //turn off reset button
            mnuGameReset.Enabled = false;
            lblCurrentStage.Text = "Press Enter to Play again";
        }

        private void ShotFinished()
        {
            if (IsP1Shooting == true) //let P2 shoot if P1 was shooting
            {
                P2Shoot();
            }
            else //end shooting if P2 shot
            {
                //disable shooting timer, make bullet invisible
                picBullet.Visible = false;
                tmrShoot.Enabled = false;
                //start the planning stage
                StartPlanningStage();
            }
        }

        private void mnuGameReset_Click(object sender, EventArgs e)
        {
            //reset the game
            Reset();
        }

        private void mnuAboutHelp_Click(object sender, EventArgs e) //show all the controls
        {
            MessageBox.Show(
                "The goal of the game is to hit the enemy tank 3 times by shooting at it over the tower.\n\n" +
                "Controls:\n\n" +
                "Player 1 Controls:\n" +
                "- Use 'A' and 'D' to move left and right\n" +
                "- Use 'X' and 'Z' to adjust power of shot\n" +
                "- Use 'W' and 'S' to adjust the angle of shot\n" +
                "- Use 'R' to toggle the Ready indicator\n\n" +
                "Player 2 Controls:\n" +
                "- Use Left and Right arrow keys to move left and right\n" +
                "- Use 'K' and 'L' to adjust power of shot\n" +
                "- Use Up and Down arrow keys to adjust the angle of shot\n" +
                "- Use 'M' to toggle the Ready indicator\n\n" +
                "Shooting will begin once both players are ready.\n" +
                "The game alternates between planning and shooting stages until one player wins.\n" +
                "You can reset the game at any time from the Game Menu."
            );
        }



        private void mnuGameExit_Click(object sender, EventArgs e) //exit game
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float CannonLength = 24;

            //convert angles to radians
            float P1AngleRad = MathHelper.ToRadians(P1AngleInt);
            float P2AngleRad = MathHelper.ToRadians(P2AngleInt);

            //create graphics objects and pens
            Graphics g = this.CreateGraphics();
            Pen RedPen = new Pen(System.Drawing.Color.Red, 6);
            Pen GreenPen = new Pen(System.Drawing.Color.Green, 6);

            //cannon end point is the start point plus a multiple of the X and Y component of the angle
            //flip y so cannon points upwards 
            //flip x for green tank so it faces to the other way
            RedCannonEnd = new PointF(RedCannonStart.X + (float)Math.Cos(P1AngleRad) * CannonLength, RedCannonStart.Y + -((float)Math.Sin(P1AngleRad) * CannonLength));
            GreenCannonEnd = new PointF(GreenCannonStart.X + -((float)Math.Cos(P2AngleRad) * CannonLength), GreenCannonStart.Y + -((float)Math.Sin(P2AngleRad) * CannonLength));
            
            //draw a line for the cannon between each start and end point
            g.DrawLine(RedPen, RedCannonStart, RedCannonEnd);
            g.DrawLine(GreenPen, GreenCannonStart, GreenCannonEnd);

            //release drawing objects from memory
            RedPen.Dispose();
            GreenPen.Dispose();
            g.Dispose();
        }

        private void tmrPlanning_Tick(object sender, EventArgs e)
        {
            //ANGLE: change angles based on user input: max 90, min 0

            //P1 angle
            if ((Angle1State == AngleState.Up && P1AngleInt < 90) || (Angle1State == AngleState.Down && P1AngleInt > 0))
            {
                if (Angle1State == AngleState.Up) P1AngleInt++;
                else P1AngleInt--;
                
                //change label for angle, and redraw cannons
                lblP1Angle.Text = "Angle = " + P1AngleInt + " degrees";
                this.Refresh();
            }

            //P2 angle
            if ((Angle2State == AngleState.Up && P2AngleInt < 90) || (Angle2State == AngleState.Down && P2AngleInt > 0))
            {
                if (Angle2State == AngleState.Up) P2AngleInt++;
                else P2AngleInt--;

                //change label for angle, and redraw cannons
                lblP2Angle.Text = "Angle = " + P2AngleInt + " degrees";
                this.Refresh();
            }

            //POWER: change power based on what is input by user: max 100, min 0

            //P1 power
            if ((Power1State == PowerState.Up && P1Power < 100) || (Power1State == PowerState.Down && P1Power > 0))
            {
                //add/subtract 1 and change label
                if (Power1State == PowerState.Up) P1Power++;
                else P1Power--;
                lblP1Power.Text = "Power = " + P1Power + "%"; ;
            }

            //P2 power
            if ((Power2State == PowerState.Up && P2Power < 100) || Power2State == PowerState.Down && P2Power > 0)
            {
                //add/subtract 1 and change label
                if (Power2State == PowerState.Up) P2Power++;
                else P2Power--;
                lblP2Power.Text = "Power = " + P2Power + "%"; ;
            }
        }

        private void LabelVisibility(bool Visibility)
        {
            //set all labels to whats given
            picP1Ready.Visible = Visibility;
            picP2Ready.Visible = Visibility;
            lblReady1.Visible = Visibility;
            lblReady2.Visible = Visibility;
            lblP1Angle.Visible = Visibility;
            lblP2Angle.Visible = Visibility;
            lblP1Power.Visible = Visibility;
            lblP2Power.Visible = Visibility;
        }
    }
}
