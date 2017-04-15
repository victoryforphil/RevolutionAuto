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
        //
        // Field Data
        //
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
            //Add Fields
            FTCFields.Add(new FTCField("FTC Velocity Vortex (2016-2017)", RevolutionCreator.Properties.Resources.VelocityVortex));
            FTCFields.Add(new FTCField("FTC Blank Field", RevolutionCreator.Properties.Resources.BlankFieldFTC));

            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateFieldSettings();
            UpdateConnectionStatus();
            UpdateHardware();

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void UpdateFieldMap()
        {
            pictureBox_fieldmap.Image = CurrentField.FieldImage;
            label_fieldname.Text = CurrentField.FieldName;
        }

        public void UpdateFieldSettings()
        {
            //Add Field Dropdown Options
            comboBox_fields.ValueMember = "FieldName";
            comboBox_fields.DisplayMember = "FieldName";
            comboBox_fields.DataSource = FTCFields;

            //Update FieldSize Control based on Auto Data
            numericUpDown_fieldSize.Value = (decimal)AutoData.FieldSize;
        }

        public void UpdateConnectionStatus()
        {
            //Update Local IP Label
            label_pcIP.Text = "Local IP: " + ConnectionFunctions.GetLocalIP();
        }

        public void UpdateHardware()
        {
            comboBox_hardwareType.Items.AddRange(AutoConsts.HARDWARE_ALL);
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

        private void numericUpDown_fieldSize_ValueChanged(object sender, EventArgs e)
        {
            AutoData.FieldSize = (double)numericUpDown_fieldSize.Value;
            UpdateFieldSettings();
        }

        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AutoFileManager.ConvertToJSON());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
