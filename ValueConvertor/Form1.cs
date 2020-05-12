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

        //Helper helper = new Helper();
        ComboBox comboBox1 = Helper.InitCombobox("comboBox1", 100, 50);
        ComboBox comboBox2 = Helper.InitCombobox("comboBox2", 350, 50);
        Button button1 = Helper.InitButton("button1", 225, 100, "Convert");
        TextBox textBox1 = Helper.InitTextBox("textBox1", 100, 225, 100);
        TextBox textBox2 = Helper.InitTextBox("textBox2", 250, 225, 200);
        Label label1 = Helper.InitLabel("label1", 100, 210, "Date");
        Label label2 = Helper.InitLabel("label2", 250, 210, "Value convertation");
        

        public Form1()
        {
            Basis = "EUR";
            ConvTo = "RUB";
            
            InitializeComponent();

            //var cb1 = helper.InitCombobox("comboBox1_1", 100, 100);
            this.Controls.Add(comboBox1);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            //var cb2 = helper.InitCombobox("comboBox2_1", 300, 100);
            this.Controls.Add(comboBox2);
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            //var btn1 = helper.InitButton("button1_1", 200, 200, "Convert");
            this.Controls.Add(button1);
            button1.Click += button_Convert_Click;

            //var lbl1 = helper.InitLabel("label1_1", 100, 250, "Date");
            this.Controls.Add(label1);

            //var lbl2 = helper.InitLabel("label2_1", 250, 250, "Value convertation");
            this.Controls.Add(label2);

            //var tb1 = helper.InitTextBox("textBox1_1", 100, 300, 100);
            this.Controls.Add(textBox1);

            //var tb2 = helper.InitTextBox("textBox2_1", 250, 300, 200);
            this.Controls.Add(textBox2);

            //button1.Enabled = false;

        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            Currency currencyData = Currency.APIValue(Basis, ConvTo);

            textBox1.Text = Convert.ToString(currencyData.Date);
            textBox2.Text = Basis + " = " + Convert.ToString(currencyData.Rates[ConvTo]) + "  " + ConvTo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Basis = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvTo = comboBox2.Text;
            //button1.Enabled = true;
        }
    }
}
