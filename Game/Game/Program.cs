using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

       
    }


    public static class prompt
    {
        public static string ShowDialog(string txt,string caption)
        {

            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox txtName = new TextBox() { Left = 50, Top = 10, Width = 175};
            Font font = new Font("Arial", 18.0f, FontStyle.Bold);

            txtName.Font = font;
            Button btnconfirmation = new Button() { Text = "OK", Left =100, Width = 100, Top = 50,Height=50, DialogResult = DialogResult.OK };
            btnconfirmation.Font = font;
            btnconfirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(txtName);
            prompt.Controls.Add(btnconfirmation);
 
            return prompt.ShowDialog() == DialogResult.OK? txtName.Text : "";

        }


    }

 
      

}
