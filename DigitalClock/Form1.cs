using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public static CultureInfo cult = new CultureInfo("en-US", false); //default culture
        public Form1()
        {
            
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            dateLabel.Text = DateTime.Now.ToString("d",cult.DateTimeFormat);
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // Load All Specific Cultures into listbox
            CultureInfo[] allCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in allCultures)
            {
                listBox1.Items.Add(culture.IetfLanguageTag);       //culture.EnglishName ako želimo puna imena
            }
            
        }

        private void f(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            CultureInfo[] allCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            int index = listBox1.SelectedIndex;

            cult = (CultureInfo)allCultures.GetValue(index);
            
            
           
          
            
        }
            
        
    }
}
