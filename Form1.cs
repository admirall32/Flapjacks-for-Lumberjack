using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flapjacks_for_Lumberjack
{
    public partial class Form1 : Form
    {
        private Queue<Classes.Lumberjack> line = new Queue<Classes.Lumberjack>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddLumberjackButton_Click(object sender, EventArgs e)
        {
            line.Enqueue(new Classes.Lumberjack(LumberjackNameTextBox.Text));
            RedrawList();
        }

        private void addFlapjacksButton_Click(object sender, EventArgs e)
        {
            if (line.Count == 0) return;

            Classes.Flapjack food;

            if(crispy.Checked == true)
                food = Classes.Flapjack.Crispy;    
            else if (soggy.Checked == true) 
                food = Classes.Flapjack.Soggy; 
            else if (browned.Checked == true) 
                food = Classes.Flapjack.Browned; 
            else 
                food = Classes.Flapjack.Banana;

            Classes.Lumberjack currentLumberjack = line.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void nextLumberjackButton_Click(object sender, EventArgs e)
        {
            if (line.Count > 0)
            {
                line.Peek().EatFlapjacks();
                line.Dequeue();
            }
            
            RedrawList();
        }

        private void RedrawList() 
        {
            Line.Items.Clear();

            int number = 1;

            foreach(Classes.Lumberjack lumberjack in line)
            {
                Line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (line.Count > 0)
            {
                Classes.Lumberjack currentClient = line.Peek();

                listLamberjacks.Text = currentClient.Name + " has " + currentClient.FlapjackCount +
                    " flapjacks. \r\n";
            }
            else
                listLamberjacks.Text = "";
            
        }
    }
}
