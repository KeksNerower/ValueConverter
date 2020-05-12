using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueConvertor
{
    public partial class Form1 : Form
    {
        public string Basis { get; set; }
        public string ConvTo { get; set; }

        public Form1()
        {
            InitializeComponent();

            /*
            // Initialize an array with data to bind to the combo box.
            var daysOfWeek =
                new[] { "Monday", "Tuesday", "Wednesday",
                        "Thursday", "Friday", "Saturday",
                        "Sunday" };

            // Initialize combo box
            var comboBox = new ComboBox
            {
                DataSource = daysOfWeek,
                Location = new System.Drawing.Point(12, 12),
                Name = "comboBox",
                Size = new System.Drawing.Size(166, 21),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add the combo box to the form.
            this.Controls.Add(comboBox);
            */
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            Currency currencyData = Helper.APIValue(Basis, ConvTo);

            textBox1.Text = Convert.ToString(currencyData.Date);
            textBox2.Text = Convert.ToString(currencyData.Rates[ConvTo]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Basis = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvTo = comboBox2.Text;
        }
    }
}
