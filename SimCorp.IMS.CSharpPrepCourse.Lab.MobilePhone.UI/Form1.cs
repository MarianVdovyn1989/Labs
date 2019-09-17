using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone.UI
{
    public partial class Form1 : Form,IOutput
    {
        IOutput WinForm;
     

        public Form1()
        {
            InitializeComponent();
            WinForm = new TextBox(tbOutput);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            //=======================================================================================
            //Clear textBox
            tbOutput.Clear();
            //return Selected radiobutton index
            int SelectedRadioButtonIndex = CheckSelectedRadioButton(WinForm);
            //create class with DI
            SimCorpMobile MyMobile = new SimCorpMobile(WinForm);
            //create component class
            MyMobile.PlaybackComponent = MyMobile.PlayBackFactory.Create(SelectedRadioButtonIndex);
            //show playing device in textbox
            MyMobile.Play();
            //=======================================================================================
        }


        private int CheckSelectedRadioButton(IOutput Output)
        {
                int Index = 0;
                Exception Ex = null;
                try
                {
                    Index = int.Parse(ReturnRadioButtonIndex(Output));
                    return Index;
                }
                catch (Exception ex)
                {
                    Ex = ex;
                //Return default value 0
                return Index;
                }
        }
            string ReturnRadioButtonIndex(IOutput Output)
            {
                if (rbIPhoneHeadset.Checked)
                {
                    Output.WriteLine($"{nameof(PlayBackIPhoneHeadset)} was selected.\nSet PlayBack to Mobile");
                    return "1";
                }
                else if (rbPhoneSpeaker.Checked)
                {
                    Output.WriteLine($"{nameof(PlayBackPhoneSpeaker)} was selected\n Set Playback to {nameof(Mobile)}");
                    return "2";
                }
                else if (rbSamsungHeadset.Checked)
                {
                    Output.WriteLine($"{nameof(PlayBackSamsungHeadset)} was selected\n Set Playback to {nameof(Mobile)}");
                    return "3";
                }
                else if (rbUnofficialHeadset.Checked)
                {
                    Output.WriteLine($"{nameof(PlayBackUnofficialHeadset)} was selected\n Set Playback to {nameof(Mobile)}");
                    return "4";
                }
                return "";
            }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        public void Write(string text)
        {
            WinForm.WriteLine(text);
        }

        public void WriteLine(string text)
        {
            WinForm.WriteLine(text);
        }
    }
}
