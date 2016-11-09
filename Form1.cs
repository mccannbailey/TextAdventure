using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventuregame
{
    public partial class Form1 : Form
    {
        string choice;
        int scene = 0;
        public Form1()
        {
            InitializeComponent();
            sceneLabel.Text = Convert.ToString(scene);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            sceneLabel.Text = Convert.ToString(scene);
            //Scenes on A key press
            if (e.KeyCode == Keys.A)
            {
               switch (scene )
                {
                    case 0:
                        outcomeLabel.Text = "You say yes. Your boss gives you a hefty stack of paperwork.";
                        outputLabel.Text = "Your boss leaves the office for the night, leaving you alone.";
                        achoiceLabel.Text = "Put the paperwork on your boss' desk and leave.";
                        bchoiceLabel.Text = "Start working on the paperwork.";
                        scene = 1;                 
                        break;
                    case 1:
                        //restart button visible
                        outcomeLabel.Text = "You put the paperwork on your boss' desk. You go to leave and your boss catches you in the parking lot, FIRED!";
                        outcomeLabel.ForeColor = Color.White;
                        outcomeLabel.BackColor = Color.Red;
                        outputLabel.Text = "";
                        break;
                    case 3:
                        outcomeLabel.Text = "You run back into your office and lock the door, just in case. You look out your window and notice it's raining.";
                        outputLabel.Text = "it's 10:30, the paperwork is sitting on your desk.";
                        achoiceLabel.Text = "Continue working.";
                        bchoiceLabel.Text = "See if the window will open.";
                        scene = 4;
                        break;
                    case 4:
                        outcomeLabel.Text = "You continue to work, ugh.";
                        outputLabel.Text = "You hear a breath by your ear over the sound of the rain.";
                        achoiceLabel.Text = "Turn around sharply.";
                        bchoiceLabel.Text = "Ignore it.";
                        scene = 5;
                        break;
                } 
            }
            //Scenes on B key press
            if (e.KeyCode == Keys.B)
            {
                switch (scene)
                {
                    case 1:
                        outcomeLabel.Text = "Start working on the paperwork.";
                        outputLabel.Text = "It's 10 o'clock, you're not even halfway done.";
                        achoiceLabel.Text = "Keep working, your boss will be\nimpressed.";
                        bchoiceLabel.Text = "Pack up for the night, whatever.";
                        scene = 2;
                        break;
                    case 2:
                        outcomeLabel.Text = "You pack up.";
                        outputLabel.Text = "You step out of your office, the lights flicker. There's a custodian closet to your right.";
                        achoiceLabel.Text = "Run back into your office, that's\ntoo spooky.";
                        bchoiceLabel.Text = "Look in the closet.";
                        cchoiceLabel.Text = "Ignore the lights, leave the building.";
                        scene = 3;
                        break;
                    case 3:
                        outcomeLabel.Text = "You open the custodian closet door.";
                        outputLabel.Text = "You find a poorly written Big Bang Theory fan fiction on lined paper.";
                        achoiceLabel.Text = "Leave the closet";
                        bchoiceLabel.Text = "Read the fan fiction";
                        scene = 4;
                        break;
                    case 4:
                        outcomeLabel.Text = "You read the fan fiction in the closet.";
                        outputLabel.Text = "You see a rope hanging up in the closet. You check the time, it's 11 o'clock.";
                        achoiceLabel.Text = "Go back to your office to work, you've\nwasted enough time";
                        bchoiceLabel.Text = "Put the fan fiction in your pocket";
                        cchoiceLabel.Text = "Rip the fan fiction into pieces,\nthis cannot see the light of day.";
                        scene = 5;
                        break;
                }
            }
            //Scenes on C key press
            if (e.KeyCode == Keys.C)
            {
                switch (scene)
                {
                    case 3:
                        outcomeLabel.Text = "You continue walking.";
                        outputLabel.Text = "You approach the front of the building. The front door is ahead and a side door to the parking lot is to your right.";
                        achoiceLabel.Text = "Take the front door and walk around the building to your car";
                        bchoiceLabel.Text = "Take the side door, it's faster.";
                        cchoiceLabel.Text = "";
                        scene = 4;
                        break;
                    case 5:

                        break;
                }
            }

            //Output and outcome labels
            switch (scene)
            {
                case 0:
                    
                    break;
            }            
        }
    }
}
