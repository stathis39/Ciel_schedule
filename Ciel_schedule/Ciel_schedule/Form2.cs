using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ciel_schedule
{
    public partial class Form2 : Form
    {
        public static Form2 form2Instance;
        public CheckBox bar, marka, pda, ranner, deutera, triti, tetarti, pempti, paraskeui, savvato, kiriaki;
        public string setValueForTextBox = "";
        public static string setjob1 = "BAR";
        public static string setjob2 = "RANNER";
        public static string setjob3 = "MARKA";
        public static string setjob4 = "PDA";

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.day == "button1")
            {
                Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx1_frst.Text = "";
            }else if (Form1.day == "button2")
            {
                Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx2_frst.Text = "";
            }else if (Form1.day == "button3")
            {
                Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx3_frst.Text = "";
            }else if (Form1.day == "button4")
            {
                Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx4_frst.Text = "";
            }else if (Form1.day == "button5")
            {
                Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx5_frst.Text = "";
            }else if (Form1.day == "button6")
            {
                Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx6_frst.Text = "";
            }else if (Form1.day == "button7")
            {
                Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(224, 224, 224);
                Form1.form1Instance.tbx7_frst.Text = "";
            }
            this.Close();
        }

        public Form2()
        {
            InitializeComponent();
            form2Instance = this;
            bar = BAR_Box1;
            marka = MARKA_Box2;
            pda = PDA_box4;
            ranner = RANNER_box3;
            deutera = deutera_box;
            triti = triti_box;
            tetarti = tetarti_box;
            pempti = pempti_box;
            paraskeui = paraskeui_box;
            savvato = savvato_box;
            kiriaki = kiriaki_box;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.day == "button1")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx1_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen;

                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked){Form1.form1Instance.tbx1_frst.Text = "09:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }

            }
            if (Form1.day == "button2")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx2_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button3")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx3_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button4")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx4_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button5")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx5_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button6")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx6_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }
            if (Form1.day == "button7")
            {
                setValueForTextBox = text_value.Text;
                Form1.form1Instance.tbx7_frst.Text = setValueForTextBox;
                Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "10:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "11:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "12:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "13:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "14:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "15:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "16:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "17:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "18:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "19:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "20:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "21:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "22:00"; Form1.form1Instance.job.Text = ""; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }



            if (deutera_box.CheckState == CheckState.Checked)
            {

                Form1.form1Instance.tbx1_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                    Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen;
                }
                else if (box9.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "09:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "10:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "11:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "12:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "13:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "14:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "15:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "16:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "17:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "18:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "19:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "20:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "21:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx1_frst.Text = "22:00"; Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); }



            }
            if (triti_box.CheckState == CheckState.Checked)
            {

                Form1.form1Instance.tbx2_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx2_frst.Text = "09:00";
                    Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen;
                }

                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "10:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "11:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "12:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "13:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "14:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "15:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "16:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "17:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "18:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "19:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "20:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "21:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx2_frst.Text = "22:00"; Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }



            if (tetarti_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx3_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx3_frst.Text = "09:00";
                    Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen;
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "10:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "11:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "12:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "13:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "14:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "15:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "16:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "17:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "18:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "19:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "20:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "21:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx3_frst.Text = "22:00"; Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (pempti_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx4_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx4_frst.Text = "09:00";
                    Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen;
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "10:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "11:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "12:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "13:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "14:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "15:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "16:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "17:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "18:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "19:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "20:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "21:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx4_frst.Text = "22:00"; Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (paraskeui_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx5_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx5_frst.Text = "09:00";
                    Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen;
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "10:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "11:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "12:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "13:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "14:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "15:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "16:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "17:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "18:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "19:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "20:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "21:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx5_frst.Text = "22:00"; Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (savvato_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx6_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx6_frst.Text = "09:00";
                    Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen;
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "10:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "11:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "12:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "13:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "14:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "15:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "16:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "17:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "18:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "19:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "20:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "21:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx6_frst.Text = "22:00"; Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); }
            }


            if (kiriaki_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx7_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx7_frst.Text = "09:00";
                    Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen;
                }
                else if (box10.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "10:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box11.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "11:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box12.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "12:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box13.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "13:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box14.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "14:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box15.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "15:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; }
                else if (box16.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "16:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box17.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "17:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box18.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "18:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box19.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "19:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box20.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "20:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box21.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "21:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
                else if (box22.CheckState == CheckState.Checked) { Form1.form1Instance.tbx7_frst.Text = "22:00"; Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); }
            } 
            if (kathemera_box.CheckState == CheckState.Checked)
            {
                Form1.form1Instance.tbx7_frst.Text = setValueForTextBox;
                /*---check boxes gia grigoroteri epilogh toy wrariou*/
                if (box9.CheckState == CheckState.Checked)
                {
                    Form1.form1Instance.tbx1_frst.Text = "09:00";
                    Form1.form1Instance.tbx2_frst.Text = "09:00";
                    Form1.form1Instance.tbx3_frst.Text = "09:00";
                    Form1.form1Instance.tbx4_frst.Text = "09:00";
                    Form1.form1Instance.tbx5_frst.Text = "09:00";
                    Form1.form1Instance.tbx6_frst.Text = "09:00";
                    Form1.form1Instance.tbx7_frst.Text = "09:00";
                    Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen;
                    Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen;
                    Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen;
                    Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen;
                    Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen;
                    Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen;
                    Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen;
                }
                else if (box10.CheckState == CheckState.Checked) { 
                                                                   Form1.form1Instance.tbx1_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx2_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx3_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx4_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx5_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx6_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx7_frst.Text = "10:00"; 
                                                                   Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen;
                                                                   Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen;
                                                                   Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen;
                                                                   Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen;
                                                                   Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen;
                                                                   Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen;
                                                                   Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen;
                }
                else if (box11.CheckState == CheckState.Checked) { 
                                                                   Form1.form1Instance.tbx1_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx2_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx3_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx4_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx5_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx6_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx7_frst.Text = "11:00"; 
                                                                   Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; 
                                                                   Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; 
                                                                   Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; 
                                                                   Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; 
                                                                   Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; 
                                                                   Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; 
                                                                   Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; 
                }
                else if (box12.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "12:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; 
                }
                else if (box13.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx2_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx3_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx4_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx5_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx6_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx7_frst.Text = "13:00"; 
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen; 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen; 
                }
                else if (box14.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx2_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx3_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx4_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx5_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx6_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx7_frst.Text = "14:00"; 
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen;
                }
                else if (box15.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "15:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.LightGreen;
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.LightGreen;
                }
                else if (box16.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "16:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0);
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0);
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0);
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0);
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0);
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0);
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0);
                }
                else if (box17.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "17:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); 
                }
                else if (box18.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx2_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx3_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx4_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx5_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx6_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx7_frst.Text = "18:00"; 
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); 
                }
                else if (box19.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx2_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx3_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx4_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx5_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx6_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx7_frst.Text = "19:00"; 
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); 
                }
                else if (box20.CheckState == CheckState.Checked) { 
                                                                  Form1.form1Instance.tbx1_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "20:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); 
                }
                else if (box21.CheckState == CheckState.Checked) {
                                                                  Form1.form1Instance.tbx1_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "21:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); 
                }
                else if (box22.CheckState == CheckState.Checked) { 
                                                                  Form1.form1Instance.tbx1_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx2_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx3_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx4_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx5_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx6_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx7_frst.Text = "22:00";
                                                                  Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 128, 0); 
                                                                  Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 128, 0); 
                }
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
                else if (Form1.day == "button3")
                {
                    Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job2.Text = setjob1;
                }
                else if (Form1.day == "button4")
                {
                    Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job3.Text = setjob1;
                }
                else if (Form1.day == "button5")
                {
                    Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job4.Text = setjob1;
                }
                else if (Form1.day == "button6")
                {
                    Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job5.Text = setjob1;
                }
                else if (Form1.day == "button7")
                {
                    Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job6.Text = setjob1;
                }

            }
            if (MARKA_Box2.CheckState == CheckState.Checked)
            {
                if (Form1.day == "button1")
                {
                    Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job.Text = setjob3;
                }
                else if (Form1.day == "button2")
                {
                    Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job1.Text = setjob3;
                }
                else if (Form1.day == "button3")
                {
                    Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job2.Text = setjob3;
                }
                else if (Form1.day == "button4")
                {
                    Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job3.Text = setjob3;
                }
                else if (Form1.day == "button5")
                {
                    Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job4.Text = setjob3;
                }
                else if (Form1.day == "button6")
                {
                    Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job5.Text = setjob3;
                }
                else if (Form1.day == "button7")
                {
                    Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job6.Text = setjob3;
                }
            }
            if (RANNER_box3.CheckState == CheckState.Checked)
            {
                if (Form1.day == "button1")
                {
                    Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job.Text = setjob2;
                }
                else if (Form1.day == "button2")
                {
                    Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job1.Text = setjob2;
                }
                else if (Form1.day == "button3")
                {
                    Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job2.Text = setjob2;
                }
                else if (Form1.day == "button4")
                {
                    Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job3.Text = setjob2;
                }
                else if (Form1.day == "button5")
                {
                    Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job4.Text = setjob2;
                }
                else if (Form1.day == "button6")
                {
                    Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job5.Text = setjob2;
                }
                else if (Form1.day == "button7")
                {
                    Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job6.Text = setjob2;
                }
            }
            if (PDA_box4.CheckState == CheckState.Checked)
            {
                if (Form1.day == "button1")
                {
                    Form1.form1Instance.tbx1_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job.Text = setjob4;
                }
                else if (Form1.day == "button2")
                {
                    Form1.form1Instance.tbx2_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job1.Text = setjob4;
                }
                else if (Form1.day == "button3")
                {
                    Form1.form1Instance.tbx3_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job2.Text = setjob4;
                }
                else if (Form1.day == "button4")
                {
                    Form1.form1Instance.tbx4_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job3.Text = setjob4;
                }
                else if (Form1.day == "button5")
                {
                    Form1.form1Instance.tbx5_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job4.Text = setjob4;
                }
                else if (Form1.day == "button6")
                {
                    Form1.form1Instance.tbx6_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job5.Text = setjob4;
                }
                else if (Form1.day == "button7")
                {
                    Form1.form1Instance.tbx7_frst.BackColor = Color.FromArgb(255, 255, 153);
                    Form1.form1Instance.job6.Text = setjob4;
                }
            }




            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAR_Box1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box9_CheckedChanged(object sender, EventArgs e)
        {
            box9.Checked = true;
        }
    }
}
