using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciel_schedule
{
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        /*Giannis*/
        public Button tbx1_frst, tbx2_frst, tbx3_frst, tbx4_frst, tbx5_frst, tbx6_frst, tbx7_frst;
        /*vasilis*/
        public Button tbx1_sec, tbx2_sec, tbx3_sec, tbx4_sec, tbx5_sec, tbx6_sec, tbx7_sec;
        /*katerina*/
        public Button tbx1_th, tbx2_th, tbx3_th, tbx4_th, tbx5_th, tbx6_th, tbx7_th;

        public static string day = "";
        public Label job, job1, job2, job3, job4, job5, job6;
        public static int triti;
        public CheckBox box;

        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
            //first line buttons :
            tbx1_frst = btn1_first_line;
            tbx2_frst = btn2_first_line;
            tbx3_frst = btn3_first_line;
            tbx4_frst = btn4_first_line;
            tbx5_frst = btn5_first_line;
            tbx6_frst = btn6_first_line;
            tbx7_frst = btn7_first_line;
            //second line buttons
            tbx1_sec = btn1_sec_line;
            tbx2_sec = btn2_sec_line;
            tbx3_sec = btn3_sec_line;
            tbx4_sec = btn4_sec_line;
            tbx5_sec = btn5_sec_line;
            tbx6_sec = btn6_sec_line;
            tbx7_sec = btn7_sec_line;
            job = job_title;
            job1 = job_title_1; job2 = job_title_2; job3 = job_title_3; job4 = job_title_4; job5 = job_title_5;



        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn1_sec_line_Click(object sender, EventArgs e)
        {
            day = "button8";
            Form3 fm = new Form3();
            fm.Show();
        }

        private void btn2_sec_line_Click(object sender, EventArgs e)
        {
            day = "button9";
            Form3 fm = new Form3();
            fm.Show();
        }

        private void btn3_sec_line_Click(object sender, EventArgs e)
        {
            day = "button10";
            Form3 fm = new Form3();
            fm.Show();
        }

        private void btn4_sec_line_Click(object sender, EventArgs e)
        {
            day = "button11";
            Form3 fm = new Form3();
            fm.Show();
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button139_Click(object sender, EventArgs e)
        {

        }

        private void button146_Click(object sender, EventArgs e)
        {

        }

        private void button153_Click(object sender, EventArgs e)
        {

        }

        private void button160_Click(object sender, EventArgs e)
        {

        }

        private void button181_Click(object sender, EventArgs e)
        {

        }

        private void button180_Click(object sender, EventArgs e)
        {

        }

        private void button159_Click(object sender, EventArgs e)
        {

        }

        private void button152_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void btn5_sec_line_Click(object sender, EventArgs e)
        {
            day = "button12";
            Form3 fm = new Form3();
            fm.Show();
        }

        private void btn6_sec_line_Click(object sender, EventArgs e)
        {
            day = "button13";
            Form3 fm = new Form3();
            fm.Show();
        }

        private void btn7_sec_line_Click(object sender, EventArgs e)
        {
            day = "button14";
            Form3 fm = new Form3();
            fm.Show();
        }


        //ektupwse san pdf

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            day = "button1";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;

            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.deutera.Enabled = false;
            Form2.form2Instance.deutera.Checked = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            day = "button4";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;
            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.pempti.Enabled = false;
            Form2.form2Instance.pempti.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            day = "button2";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;
            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.triti.Enabled = false;
            Form2.form2Instance.triti.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            day = "button3";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;
            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.tetarti.Enabled = false;
            Form2.form2Instance.tetarti.Checked = true;
        }

        private void btn5_first_line_Click(object sender, EventArgs e)
        {
            day = "button5";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;
            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.paraskeui.Enabled = false;
            Form2.form2Instance.paraskeui.Checked = true;
        }

        private void btn6_first_line_Click(object sender, EventArgs e)
        {
            day = "button6";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;
            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.savvato.Enabled = false;
            Form2.form2Instance.savvato.Checked = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Monday_date.Text = dateTimePicker1.Value.Day.ToString() + " / " + dateTimePicker1.Value.Month.ToString();
            tuesday_date.Text = (dateTimePicker1.Value.Day + 1) + " / " + dateTimePicker1.Value.Month.ToString();
            Wednesday_date.Text = (dateTimePicker1.Value.Day + 2) + " / " + dateTimePicker1.Value.Month.ToString();
            Thursday_date.Text = (dateTimePicker1.Value.Day + 3) + " / " + dateTimePicker1.Value.Month.ToString();
            Friday_date.Text = (dateTimePicker1.Value.Day + 4) + " / " + dateTimePicker1.Value.Month.ToString();
            Saturday_date.Text = (dateTimePicker1.Value.Day + 5) + " / " + dateTimePicker1.Value.Month.ToString();
            Sunday_date.Text = dateTimePicker2.Value.Day.ToString() + " / " + dateTimePicker2.Value.Month.ToString();
        }

        private void btn7_first_line_Click(object sender, EventArgs e)
        {
            day = "button7";
            Form2 fm = new Form2();
            fm.Show();
            Form2.form2Instance.bar.Enabled = false;
            Form2.form2Instance.ranner.Enabled = false;
            Form2.form2Instance.pda.Enabled = false;
            Form2.form2Instance.marka.Enabled = false;
            Form2.form2Instance.kiriaki.Enabled = false;
            Form2.form2Instance.kiriaki.Checked = true;
        }

        private void button84_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }

        private void giannhs_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}