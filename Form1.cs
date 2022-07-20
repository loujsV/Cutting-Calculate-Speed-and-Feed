using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cutting_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // https://www.cnclathing.com/milling-speed-and-feed-calculator

        

        private void Calculator(object sender, EventArgs e)
        {
            try
            {
                double Tool_Dia = 0;

                double Feed_rate_IPM = 0;

                double Feed_per_Tooth_IPT = 0;

                double Cutting_feed_IPR = 0;

                int Num_of_teeth = 0;

                int Cutting_speed_SFM = 0;

                int Spindle_Speed_RPM = 0;


                //Declare all textbox value

                if (txt_NoofTeeth.Text != "")
                    Num_of_teeth = ((Convert.ToInt32(txt_NoofTeeth.Text)) != 0) ? (Convert.ToInt32(txt_NoofTeeth.Text)) : 0;

                if (txt_ToolDia.Text != "")
                {
                    Tool_Dia = ((Convert.ToDouble(txt_ToolDia.Text)) != 0) ? (Convert.ToDouble(txt_ToolDia.Text)) : 0;
                    label_ToolDia.Text = txt_ToolDia.Text + " × π";
                }
                    

                if (txt_FeedRate.Text != "")
                    Feed_rate_IPM = ((Convert.ToDouble(txt_FeedRate.Text)) != 0) ? (Convert.ToDouble(txt_FeedRate.Text)) : 0;

                if (txt_FeedperTooth.Text != "")
                {
                    double text_FeedperTooth = Convert.ToDouble(txt_FeedperTooth.Text);

                    Feed_per_Tooth_IPT = (text_FeedperTooth != 0) ? text_FeedperTooth : 0;

                    Cutting_feed_IPR = Feed_per_Tooth_IPT * Num_of_teeth;

                    txt_CuttingFeed.Text = Cutting_feed_IPR.ToString();

                    label_CuttingFeed.Text = Cutting_feed_IPR.ToString();
                }
                    

                if (txt_CuttingFeed.Text != "")
                    Cutting_feed_IPR = ((Convert.ToDouble(txt_CuttingFeed.Text)) != 0) ? (Convert.ToDouble(txt_CuttingFeed.Text)) : 0;



                if (txt_CuttingSpeed.Text != "")
                {
                    int text_Cutting_speed = Convert.ToInt32(txt_CuttingSpeed.Text);
                    Cutting_speed_SFM = (text_Cutting_speed != 0) ? text_Cutting_speed : 0;

                    Spindle_Speed_RPM = Convert.ToInt32(Cutting_speed_SFM * 12 / Tool_Dia / 3.14159265358979);

                    txt_SpindleSpeed.Text = Spindle_Speed_RPM.ToString();

                    label_SpindleSpeed.Text = Spindle_Speed_RPM.ToString();
                }
                    

                if (txt_SpindleSpeed.Text != "")
                    Spindle_Speed_RPM = ((Convert.ToInt32(txt_SpindleSpeed.Text)) != 0) ? (Convert.ToInt32(txt_SpindleSpeed.Text)) : 0;


                //Declare label
                label_NoofTeeth.Text = (txt_NoofTeeth.Text != "") ? txt_NoofTeeth.Text : "0";

                label_CuttingFeed.Text = (txt_CuttingFeed.Text != "") ? txt_CuttingFeed.Text : "0";

                label_SpindleSpeed.Text = (txt_SpindleSpeed.Text != "") ? txt_SpindleSpeed.Text : "0";

                if (Cutting_feed_IPR != 0 && Spindle_Speed_RPM != 0)
                {
                    Feed_rate_IPM = Cutting_feed_IPR * Spindle_Speed_RPM;

                    txt_FeedRate.Text = Feed_rate_IPM.ToString();
                }
                   

            }
            catch
            { }
        }

    }
}
