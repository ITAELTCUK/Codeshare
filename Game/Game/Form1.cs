using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string strName = "";
            //Global.gamername = prompt.ShowDialog("name", "Please Enter Name");
            using(Dialog frmDialog=new Dialog())
            {
                if((frmDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK) && (frmDialog.strName.Length >0))
                {
                    strName = frmDialog.strName;
                }
                else
                {
                    MessageBox.Show("Name Mandatory");
                    this.Close();

                }

            }
            Game.Global.name = strName;
            this.lblName.Text = "Welcome " + strName;

            lblMaxAttemptNo.Text = Game.Global.maxAttempts.ToString();
            txtWord.Visible = false;

            RefreshScorerList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Initialize();
            RefreshScorerList();

        }


        private void txtBox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[a-zA-Z ]"))
            {

                Boolean blnfinish = false;
                Game.Helper objHelper = new Game.Helper();

                string id = ((TextBox)sender).Name.ToString();
                char[] txt = ((TextBox)sender).Text.ToString().ToCharArray();
                int num = Int32.Parse(id);
                bool rtnFlag = MatchWord(num, txt[0], txtWord.Text);
                if (rtnFlag)
                {
                    ((TextBox)sender).Enabled = false;
                    ((TextBox)sender).ForeColor = Color.Green;

                    //Check all digits matched
                    if (txtWord.Text.Length == Game.Global.wordmatchcounter)
                    {
                        
                        lblWarning.Text = "Congrats ! Press start to play game again";
                        lblWarning.ForeColor = Color.DarkGreen;
                        lblWarning.Visible = true;
                        pnlBox.Enabled = false;
                        blnfinish = true;

                        objHelper.AddtoCSV(Game.Global.name, true);
                    }

                }
                else
                {
                    ((TextBox)sender).ForeColor = Color.Red;
                }

                //Check if attempts limit cross
                if (Game.Global.attempts >= Game.Global.maxAttempts)
                {

                    lblWarning.Text = "Better luck next time! Press start to play game again";
                    lblWarning.Visible = true;
                    lblWarning.ForeColor = Color.Red;

                    for (int X = 0; X <= txtWord.Text.Length; X++)
                    {
                        pnlBox.Enabled = false;
                        blnfinish = true;
                    }

                    objHelper.AddtoCSV(Game.Global.name, false);


                }

                if (!blnfinish)
                {
                    lblCrntAttemptNo.Text = (Game.Global.maxAttempts- Game.Global.attempts).ToString();
                }
                else
                {
                    lblCrntAttemptNo.Text = "0";
                    txtWord.Visible = true;


                }

            }

        }

       
        private void Initialize ()
        {
            
            Game.Words objWords = new Words();
            pnlBox.Enabled = true;

            List<string> listWords = objWords.ListWords;
            Random randGen = new Random();
            var indx = randGen.Next(0, 3);
            string newWord = listWords[indx];

            txtWord.Text = newWord;

            //Create Masked String **********************************
            StringBuilder maskedWord = new StringBuilder();

            for (int i = 0; i < newWord.Length; i++)
                maskedWord.Append('*');

            newWord = maskedWord.ToString();
            GenerateBoxes(newWord);

            Game.Global.gamestarted = true;
            Game.Global.wordmatchcounter = 0;
            Game.Global.attempts = 0;

            //************************************************
            lblCrntAttemptNo.Text = (Game.Global.maxAttempts- Game.Global.attempts).ToString();
            lblCrntAttemptNo.Visible = true;
            lblCrntAttempts.Visible = true;
            lblWarning.Visible = false;
            txtWord.Visible = false;

        }


        private void GenerateBoxes(string word)
        {
            int pointX = 10;
            int pointY = 10;

            //Remove if exists
            for (int x = 0; x < word.Length; x++)
            {
                try { pnlBox.Controls.Remove(pnlBox.Controls.Find(x.ToString(), true)[0]); }
                catch(Exception e) { }

                
            }

            //Generate new
            for (int x=0; x<word.Length;x++)
            {
                TextBox txtbx = new TextBox();
                txtbx.Name =  x.ToString();
                
                txtbx.Text = "*";
                txtbx.Width = 25;
                txtbx.Font = new Font(txtbx.Font.FontFamily, 20);
                txtbx.Font = new Font(txtbx.Font, FontStyle.Bold);

                txtbx.Location = new Point(pointX, pointY);
                txtbx.TextChanged += new EventHandler(txtBox_TextChanged);
                pnlBox.Controls.Add(txtbx);
                pnlBox.Show();
                pointX += 35;
            }

        }

        private Boolean MatchWord(int wordpos, char WordValue,string MatchValue)
        {
            bool returnVal = false;
            
                        
            char[] chrMatch = MatchValue.ToCharArray();
            //int atmmpt= Game.Global.attempts;
            //atmmpt = atmmpt + 1;
            //Game.Global.attempts = atmmpt;

            if(WordValue == chrMatch[wordpos])
            {
                returnVal = true;
            }


          
            if (returnVal == true)
            {
                Game.Global.wordmatchcounter = Game.Global.wordmatchcounter + 1;

            }   
            else
            {
                Game.Global.attempts += 1;
            }

            return returnVal;

        }

        
        private void RefreshScorerList()
        {
            Game.Helper objList = new Game.Helper();
            List<string> returnList = objList.ReadFromCSV();
            lstGamers.DataSource = returnList;

            List<string> Scoreslsts= objList.GetScoreList(Game.Global.name);
            lstScores.DataSource = Scoreslsts;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.Helper objList = new Game.Helper();
            List<string> returnList=   objList.ReadFromCSV();
            lstGamers.DataSource = returnList;

        }

   
    }
}
