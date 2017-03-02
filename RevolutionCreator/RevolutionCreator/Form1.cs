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

            public FTCField(string _name, Image image){ FieldImage = image; FieldName = _name; }
        }
            
        private BindingList<FTCField> FTCFields = new BindingList<FTCField>();
        private FTCField CurrentField;
        

        public Form1()
        {
            FTCFields.Add(new FTCField("FTC Velocity Vortex (2016-2017)", RevolutionCreator.Properties.Resources.VelocityVortex));
            FTCFields.Add(new FTCField("FTC Blank Field", RevolutionCreator.Properties.Resources.BlankFieldFTC));

            InitializeComponent();

            UpdateFieldSettings();
            UpdateConnectionStatus();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void UpdateFieldMap()
        {
            pictureBox_fieldmap.Image = CurrentField.FieldImage;
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



        //
        //
        // EVENTS
        //
        //


        private void comboBox_fields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_fields.SelectedValue != null)
            {
                CurrentField = (FTCField)comboBox_fields.SelectedItem;
                UpdateFieldMap();
            }
        }
    }
}
