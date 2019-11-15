using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StadiumBox.Items.AddRange(new object[]
            {
                "Soldier Feild",
                "U.S. Bank Stadium",
                "Empower Feild",
                "Ford Feild",
                "AT&T Stadium",
            });
            QuarterbackListBox.Items.AddRange(new object[]
          {
                "Mitch Trubisky",
                "Kirk Cousins",
                "Joe Flacco",
                "Matthew Stafford",
                "Dak Prescott",
          });


        }
      
            

        private void StadiumBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int count;
            string quarterbackString;
            int selectedQB = QuarterbackListBox.SelectedItems.Count;

            string[] qbItem = new string[selectedQB];

            count = 0;

            quarterbackString = "Quarterback: ";
            foreach(var quarterback in QuarterbackListBox.SelectedItems)
            {
                qbItem[count] = quarterback.ToString();
                quarterbackString += " " + qbItem[count];
                ++count;
            }
            if (selectedQB == 0)
            {
                Quarterbacklabel.Text = "No quarterback was selected";
            }
            else
            {
                Quarterbacklabel.Text = quarterbackString;
            }

            Citylabel.Text = "City: " + CityBox.SelectedItem;
            Stadiumlabel.Text = "Stadium: " + StadiumBox.SelectedItem;

            if (CityBox.SelectedItem == "Chicago" && StadiumBox.SelectedItem == "Soldier Feild" && QuarterbackListBox.SelectedItem == "Mitch Trubisky")
            {
                Resultlabel.Text = "Correct!!";
            }
            else if(CityBox.SelectedItem == "Minneapolis" && StadiumBox.SelectedItem == "U.S. Bank Stadium" && QuarterbackListBox.SelectedItem == "Kirk Cousins")
            {
                Resultlabel.Text = "Correct!!";
            }
            else if (CityBox.SelectedItem == "Denver" && StadiumBox.SelectedItem == "Empower Field" && QuarterbackListBox.SelectedItem == "Joe Flacco")
            {
                Resultlabel.Text = "Correct!!";
            }
            else if (CityBox.SelectedItem == "Detroit" && StadiumBox.SelectedItem == "Ford Feild" && QuarterbackListBox.SelectedItem == "Matthew Stafford")
            {
                Resultlabel.Text = "Correct!!";
            }
            else if (CityBox.SelectedItem == "Dallas" && StadiumBox.SelectedItem == "AT&T Stadium" && QuarterbackListBox.SelectedItem == "Dak Prescott")
            {
                Resultlabel.Text = "Correct!!";
            }
            else
            {
                Resultlabel.Text = "Inncorrect";
            }


        }
    }
}
