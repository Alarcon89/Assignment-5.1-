using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using People;



namespace SpaceShip_Crew
{
    
    public partial class Main : Form
    {
        // Here I will creating objects from our ClassMission and ClassCrew classes
        private ClassMission FirstCrewMember = new ClassMission("Jose", "Alarcon", "Democracy!");
        private ClassCrew SecondCrewMember = new ClassCrew("John", "Smith", "Democracy!");
        private ClassCrew ThirdCrewMember = new ClassCrew("Bic", "Tech", "Democracy!");
        private ClassCrew FourthCrewMember = new ClassCrew("Tammy", "Doid", "Democracy!");
        private ClassMission FifthCrewMember = new ClassMission("Waukee", "Mills", "Democracy!");
        private ClassCrew SixthCrewMember = new ClassCrew("Lily", "Smith", "Democracy!");
        private ClassMission SeventhCrewMember = new ClassMission("Cicil", "Safway", "Democracy!");
        private ClassCrew EighthCrewMember = new ClassCrew("Donald", "Duck", "Democracy!");
        private ClassMission NinthCrewMember = new ClassMission("Goofy", "Brandy", "Democracy!");
        private ClassCrew TenthCrewMember = new ClassCrew("Apollo", "Dog", "Democracy!");


        public Main()
        {
            
            InitializeComponent();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Here when the user doesn't want to continue they will be able to exit or continue
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // User chose to continue, do nothing
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Here the user will have no choice but to continue with the game
            // This could be a placeholder for starting the game logic
            // If they want to play the game, they will click this button only.
            MessageBox.Show("Start your mission.", "Game Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {
           PopulateCrew();
           
        }

        private void PopulateCrew()
        {
            // I added the crew and should say in mission or ready to fight.
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + FirstCrewMember.GetMissionDetails();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + SecondCrewMember.GetFullName();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + ThirdCrewMember.GetFullName();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + FourthCrewMember.GetFullName();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + FifthCrewMember.GetMissionDetails();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + SixthCrewMember.GetFullName();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + SeventhCrewMember.GetMissionDetails();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + EighthCrewMember.GetFullName();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + NinthCrewMember.GetMissionDetails();
            textBoxInsideCrew.Text = textBoxInsideCrew.Text + "\n\r\n" + TenthCrewMember.GetFullName();
        }





        private void ListBoxCrew_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBoxInsideCrew_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTransferTroops_Click(object sender, EventArgs e)
        {
            // Here the troops that are ready to transfer will be displayed in the rich text box
            richTextBoxTransferCrew.Text = string.Empty;
            //richTextBoxTransferCrew.Text += FirstCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferCrew.Text += SecondCrewMember.GetFullName() + "\n";
            richTextBoxTransferCrew.Text += ThirdCrewMember.GetFullName() + "\n";
            richTextBoxTransferCrew.Text += FourthCrewMember.GetFullName() + "\n";
            //richTextBoxTransferCrew.Text += FifthCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferCrew.Text += SixthCrewMember.GetFullName() + "\n";
            //richTextBoxTransferCrew.Text += SeventhCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferCrew.Text += EighthCrewMember.GetFullName() + "\n";
            //richTextBoxTransferCrew.Text += NinthCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferCrew.Text += TenthCrewMember.GetFullName() + "\n";


        }

        private void labelMoveOverTheFightingTroops_Click(object sender, EventArgs e)
        {
            // The user can see what troops are fighting for Democracy!
            richTextBoxTransferFightCrew.Text = string.Empty;
            richTextBoxTransferFightCrew.Text += FirstCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferFightCrew.Text += FifthCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferFightCrew.Text += SeventhCrewMember.GetMissionDetails() + "\n";
            richTextBoxTransferFightCrew.Text += NinthCrewMember.GetMissionDetails() + "\n";


        }
    }
}
