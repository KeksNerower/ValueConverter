using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace ValueConvertor
{
    class Helper
    {
        private static string[] FileValNames(string path)
        {
            string[] names = new string[32];

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    names[i] = line;
                    i++;
                }
            }

            return names;
        }

        public static ComboBox InitCombobox(string name, int x, int y)
        {
            //var valNames = new[] { "EUR", "USD", "RUB", "CAD", "HKD", "ISK", "PHP", "DKK", "HUF", "CZK", "AUD" };
            
            var valNames = Helper.FileValNames("Names.txt");

            var valBox = new ComboBox
            {
                DataSource = valNames,
                Location = new Point(x, y),
                Name = name,
                Size = new Size(100, 50),
                DropDownStyle = ComboBoxStyle.DropDownList,
                DropDownHeight = 100,

                Font = new Font(ComboBox.DefaultFont.ToString(), 10)

            };
            
            return valBox;
        }

        public static Button InitButton(string name, int x, int y, string text)
        {
            var btn = new Button
            {
                Location = new Point(x, y),
                Name = name,
                Size = new Size(100, 40),
                Text = text,
                Font = new Font("Trebuchet MS", 12)
            };

            return btn;
        }

        public static Label InitLabel(string name, int x, int y, string text)
        {
            var lbl = new Label
            {
                Location = new Point(x, y),
                Name = name,
                //Size = new Size(100, 40),
                AutoSize = true,
                Text = text,
                Font = new Font("Trebuchet MS", 12)
            };

            return lbl;
        }

        public static TextBox InitTextBox(string name, int xl, int yl, int xs)
        {
            var textBox = new TextBox
            {
                Location = new Point(xl, yl),
                Name = name,
                Size = new Size(xs, 40),
                Font = new Font("Trebuchet MS", 12)
            };

            return textBox;
        }
    }
}

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
