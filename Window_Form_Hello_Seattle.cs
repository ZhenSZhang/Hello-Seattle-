using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSeattle_Window_Form
{
    class Program
    {
        static void Main()
        {
            myForm myForm = new myForm();
            myForm.ShowDialog();
        }
    }

    class myForm: Form      //created a new class inhereted from Form class
    {
        private TextBox myTextBox;
        private Button myButton;
        private Button myBotton2;
        public myForm()
        {
            this.myTextBox = new TextBox(); //created textbox and button
            this.myButton = new Button();
            this.myBotton2 = new Button();
            this.Controls.Add(this.myTextBox);//make button and textbox show up
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.myBotton2);
            this.myButton.Click += this.myButtonClicked;//created an event here
            this.myBotton2.Click += this.myBotton2Clicked;
            this.myButton.Text = "say hello!";
            this.myBotton2.Text = "say goodbye!";
            this.myButton.Top = 50; //position button
            this.myBotton2.Top = 75;
        }

        private void myBotton2Clicked(object sender, EventArgs e)
        {
            this.myTextBox.Text = this.myTextBox.Text.Replace("Hello", "See ya");
        }

        private void myButtonClicked(object sender, EventArgs e)
        {
            this.myTextBox.Text = "Hello Seattle!";
        }
    }
}
