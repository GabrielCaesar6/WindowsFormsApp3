using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "November", "December" };
            Combo2.Items.AddRange(month);
            foreach (String months in month)
            {
                Console.WriteLine(months);
            }

            ArrayList day = new ArrayList();
            for (int i = 0; i < 31; i++)
            {
                day.Add(i + 1);
                Combo1.Items.Add(day[i]);

            }

            ArrayList year = new ArrayList();
            for (int i = 1900; i <= 2024; i++)
            {
                year.Add(i);
                Combo3.Items.Add(year[i - 1900]);
            }

            ArrayList program = new ArrayList();
            program.Add("Bachelor of Science in Computer Science");
            program.Add("Bachelor of Science in Information Technology");
            program.Add("Bachelor of Science in Information Systems");
            program.Add("Bachelor of Science in Computer Engineering");
            Combo4.Items.AddRange(program.ToArray());
            foreach (String programName in program)
            {
                Console.Write(programName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String month = Combo2.GetItemText(Combo2.SelectedItem);
            String day = Combo1.GetItemText(Combo1.SelectedItem);
            String year = Combo3.GetItemText(Combo3.SelectedItem);
            String gender = Radio1.Checked == true ? "Male" : "Female";

            String fn = Box2.Text;
            String mn = Box3.Text;
            String ln = Box1.Text;
            String program = Combo4.Text;

            RegisterStudent(ln, fn, mn, gender, day, month, year, program);
            RegisterStudent(ln, fn, mn, program);
            RegisterStudent(ln, fn, program);
        }

        public void RegisterStudent(String ln, String fn, String mn, String gender, String day, String month, String year, String program)
        {
            MessageBox.Show("Student name: " + fn + " " + mn + " " + ln + "\nGender: " + gender + "\nDate of Birth " + day + " / " + month + " / " + year + "\nProgram " + program);
        }

        public void RegisterStudent(String ln, String fn, String mn, String program)
        {
            MessageBox.Show("Student Name: " + fn + " " + mn + " " + ln + "\nProgram: " + program);
        }
        public void RegisterStudent(String ln, String fn, String program)
        {
            MessageBox.Show("Student name: " + fn + " " + ln + "\nProgram " + program);
        

        }
    }
}
