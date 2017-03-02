using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevolutionCreator
{
    public partial class Form1 : Form
    {

        private class FTCField
        {
            public Image FieldImage { get; set; }
            public string FieldName { get; set; }

            public FTCField(string _name, string imagePath)
            {
                FieldImage = Image.FromFile(Directory.GetCurrentDirectory() + "/Fields/" + imagePath);
                FieldName = _name;
            }


        }

        private BindingList<FTCField> FTCFields = new BindingList<FTCField>();
        

        public Form1()
        {
            FTCFields.Add(new FTCField("FTC Velocity Vortex (2016-2017)", "VelocityVortex.png"));

            InitializeComponent();

            UpdateFieldSettings();
            UpdateConnectionStatus();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void UpdateFieldSettings()
        {
            //Add Field Dropdown Options

            comboBox_fields.ValueMember = "FieldName";
            comboBox_fields.DisplayMember = "FieldName";
            comboBox_fields.DataSource = FTCFields;
        }

        public void UpdateConnectionStatus()
        {
            label_pcIP.Text = "Local IP: " + ConnectionFunctions.GetLocalIP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
