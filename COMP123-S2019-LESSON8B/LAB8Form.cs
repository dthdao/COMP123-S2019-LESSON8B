using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSON8B
{
    public partial class LAB8Form : Form
    {
        //propety (shortcut prop tab x2)
        public string UsertName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// this is the constructor for lab8Form
        /// </summary>
        public LAB8Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the Submitbutton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UsertName = NameTextBox.Text;


            UserAge = float.Parse(AgeTextBox.Text);
            // or Convert.ToSingle(string);

            //option A : to clear      
            OutputLabel.Text = NameTextBox.Text+ " " +AgeTextBox.Text;
            ClearForm();
            //option B
            //NameTextBox.Text = string.Empty;

        }

        /// <summary>
        /// this method clears the text boxes on the form
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();

        }

        /// <summary>
        /// this is the Event Handler for hte AgeTextBox TextChange event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //simple input validation
                try
                {
                    float.Parse(AgeTextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch
                {
                    SubmitButton.Enabled = false;
                }
        }

        /// <summary>
        /// this is the event handler for the lab08form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LAB8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// this is the event handler for the nameTextBox TextChange Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
