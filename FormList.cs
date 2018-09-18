using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamsLib;
using SportSubClass;

/// <summary>
/// Developer:  Frankie Barrios 
/// Date:       9/17/2018
/// Purpose:    Tester Ex 5 App
/// </summary>
namespace SportsEx5App
{
   
    public partial class FormList : Form
    {
        //Class Fields
        Tennis[] tenAry;
        Football[] footAry;

        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            lblHeading.Visible = false;
            lblSportInfo.Visible = false;

            tenAry = new Tennis[3];
            footAry = new Football[3];

            tenAry[0] = new Tennis("Tennis", "Racketeers", "Coach Fred", "Raquet", "Rod Laver Arena", 40);
            tenAry[1] = new Tennis("Tennis", "Ballers", "Coach Tim", "Ball", "Xtreme Arena", 40);
            tenAry[2] = new Tennis("Tennis", "Bulls", "Coach Mike", "Sweatband", "Bulls Arena", 40);

            footAry[0] = new Football("Football", "Chargers", "Coach Ed", "Astro Turf", "Chicago", 300);
            footAry[1] = new Football("Football", "Packers", "Coach Jim", "Asphalt", "St.Louis", 350);
            footAry[2] = new Football("Football", "Bears", "Coach Al", "Green", "New York", 400);

        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxSports.Items.Clear();
            lblHeading.Visible = false;
            lblSportInfo.Visible = false;

            if(cmbType.SelectedIndex == 0)
            {
                foreach(Tennis tn in tenAry)
                {
                    if (tn != null)
                        lstBxSports.Items.Add(tn.TeamName);
                }//End of foreach

            }//End of if
            else if (cmbType.SelectedIndex == 1)
            {
                foreach(Football ft in footAry)
                {
                    if (ft != null)
                        lstBxSports.Items.Add(ft.TeamName);
                }//End of foreach
            }//End of else if
        }//End of private void cmbType_SelectedIndexChanged

        private void lstBxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHeading.Visible = true;
            lblSportInfo.Visible = true;

            if (cmbType.SelectedIndex == 0) //Tennis
            {
                foreach (Tennis tn in tenAry)
                {
                    if (tn.TeamName.Equals(lstBxSports.SelectedItem))
                    {
                        lblHeading.Visible = true;
                        lblSportInfo.Visible = true;
                        lblSportInfo.Text = tn.ToString();
                    }//End of if
                }
            }//End of foreach
            else if (cmbType.SelectedIndex == 1)//Football
            {
                foreach (Football ft in footAry)
                {
                    if (ft.TeamName.Equals(lstBxSports.SelectedItem))
                        lblSportInfo.Text = ft.ToString();
                }//End of foreach
            }//End of else if

            }//End of if
        }//End of private void lstBxSports_SelectedIndexChanged
    }//End of Class
//End of Solution
