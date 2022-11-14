using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ciel_schedule
{
    public partial class Form3 : Form
    {
        public string setValueForTextBox = "";
        public static string setjob1 = "BAR";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DEUTERI SEIRA BUTTONS  




            if (Form1.day == "button8")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx1_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "10:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "11:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "12:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "13:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "14:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "15:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "16:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "17:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "18:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "19:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "20:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "21:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "22:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }

            }
            if (Form1.day == "button9")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx2_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "10:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "11:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "12:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "13:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "14:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "15:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "16:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "17:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "18:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "19:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "20:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "21:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "22:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button10")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx3_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "10:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "11:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "12:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "13:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "14:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "15:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "16:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "17:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "18:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "19:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "20:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "21:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "22:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button11")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx4_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "10:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "11:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "12:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "13:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "14:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "15:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "16:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "17:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "18:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "19:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "20:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "21:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "22:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button12")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx5_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "10:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "11:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "12:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "13:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "14:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "15:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "16:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "17:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "18:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "19:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "20:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "21:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "22:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button13")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx6_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "10:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "11:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "12:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "13:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "14:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "15:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "16:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "17:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "18:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "19:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "20:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "21:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "22:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button14")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx7_sec.Text = setValueForTextBox;
                Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "10:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "11:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "12:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "13:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "14:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "15:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "16:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "17:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "18:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "19:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "20:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "21:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "22:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }



            if (deutera_box.CheckState == CheckState.Checked)
            {

                Form1.form1Instance.tbx1_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "10:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "11:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "12:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "13:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "14:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "15:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "16:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "17:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "18:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "19:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "20:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "21:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_sec.Text = "22:00"; Form1.form1Instance.tbx1_sec.BackColor = Color.FromArgb(255, 128, 0); }



            }
            if (triti_box.CheckState == CheckState.Checked)
            {

                Form1.form1Instance.tbx2_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "10:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "11:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "12:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "13:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "14:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "15:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "16:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "17:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "18:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "19:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "20:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "21:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_sec.Text = "22:00"; Form1.form1Instance.tbx2_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }



            if (tetarti_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx3_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "10:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "11:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "12:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "13:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "14:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "15:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "16:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "17:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "18:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "19:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "20:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "21:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_sec.Text = "22:00"; Form1.form1Instance.tbx3_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (pempti_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx4_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "10:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "11:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "12:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "13:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "14:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "15:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "16:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "17:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "18:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "19:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "20:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "21:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_sec.Text = "22:00"; Form1.form1Instance.tbx4_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (paraskeui_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx5_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "10:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "11:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "12:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "13:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "14:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "15:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "16:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "17:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "18:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "19:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "20:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "21:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_sec.Text = "22:00"; Form1.form1Instance.tbx5_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (savvato_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx6_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "10:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "11:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "12:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "13:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "14:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "15:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "16:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "17:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "18:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "19:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "20:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "21:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_sec.Text = "22:00"; Form1.form1Instance.tbx6_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (kiriaki_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx7_sec.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_sec.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "10:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "11:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "12:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "13:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "14:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "15:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "16:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "17:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "18:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "19:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "20:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "21:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_sec.Text = "22:00"; Form1.form1Instance.tbx7_sec.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (BAR_Box1.CheckState == CheckState.Checked)
            {
                if (Form1.day == "button1")
                {
                    Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job.Text = setjob1;
                }
                else if (Form1.day == "button2")
                {
                    Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job1.Text = setjob1;
                }

            }
            if (MARKA_Box2.CheckState == CheckState.Checked)
            {
                //Form1.form1Instance.label1.Text = "MARKA";
            }

            this.Close();
        }
    }
}
