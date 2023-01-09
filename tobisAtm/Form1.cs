using System.Media;
namespace tobisAtm
{
    public partial class Form1 : Form
    {
        String[] instruct = { "enter your pin. \n and enter ok to continue", "welcome to tobisATM, please select an option", "please enter the amount you want to withdraw, press enter to continue ", "please enter the amount you want to transfer, press enter to continue", "would you like to see your receipt"};
        String[] answer1 = { "withdraw", "transfer", "Deposite"};
        String[] answer2 = { "yes", "no" };
        int balance = 1000000000;
        string opt = "";
        int bal = 0;
        int amt = 0;
        private SoundPlayer soundPlayer;
        private SoundPlayer soundPlayer1;
        private SoundPlayer soundPlayer2;
        private SoundPlayer soundPlayer3;
        private SoundPlayer soundPlayer4;
        public Form1()
        {
            InitializeComponent();
            soundPlayer= new SoundPlayer("Recording (3).wav");
            soundPlayer1 = new SoundPlayer("Recording.wav");
            soundPlayer2 = new SoundPlayer("Recording (4).wav");
            soundPlayer3 = new SoundPlayer("Recording (5).wav");
            soundPlayer4 = new SoundPlayer("Recording (2).wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayer.Play();
           instructLabl.Text = instruct[0];
            label3.Visible = false;
            trueBtn.Visible = false;
            falseBtn.Visible = false;
            Deposite.Visible = false;
        }

        private void trueBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 4 && textBox1.Text == "1234") {
                soundPlayer2.Play();
                label1.Visible = false;
                textBox1.Visible = false;
                Deposite.Text = answer1[2];
                instructLabl.Text = instruct[1];
                label3.Visible = false;
                trueBtn.Visible = true;
                falseBtn.Visible = true;
                Deposite.Visible = true;
                trueBtn.Text = answer1[0];
                falseBtn.Text = answer1[1];
                Deposite.Text = answer1[2];
                label3.Visible = false;
                textBox1.Text = "";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void doubleTwoBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void downClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Amount";
            textBox1.Visible = true;
            if (trueBtn.Checked)
            {
                opt = "withdraw";
                instructLabl.Text = instruct[1];
                trueBtn.Visible = false;
                falseBtn.Visible = false;
                Deposite.Visible= false;
                if (textBox1.Text != "")
                {
                    int amount = Convert.ToInt32(textBox1.Text);
                    amt = amount;

                    if (amount > balance)
                    {
                        instructLabl.Text = "insueffient fund";
                    }
                    else
                    {
                        balance -= amount;
                        bal = balance;
                        instructLabl.Text = "transaction sucessful.\n do you want a receipt if yes \n please enter receipt to continue";
                        trueBtn.Visible = true;
                        falseBtn.Visible = true;
                        trueBtn.Text = answer2[0];
                        falseBtn.Text = answer2[1];

                    }
                }
            } else if(Deposite.Checked)
            {
                opt = "transfer";
                instructLabl.Text = "please enter amount you want to Deposite";
                trueBtn.Visible = false;
                falseBtn.Visible = false;
                Deposite.Visible = false;
                if (textBox1.Text != "")
                {
                    int amount = Convert.ToInt32(textBox1.Text);
                    amt = amount;
                    balance += amount;
                    bal = balance;
                    opt = "Deposite"; 
                    DateTime a = DateTime.Now;
                    instructLabl.Text = "transaction sucessful.\n Do you want receipt if yes enter ok or the receipt key ";
                    //label3.Visible= true;
                    //label3.Text = "............................\nATM\nTobisTech\n" + a + "\n ...........................\n Acct no: 1234-5613-1234 \n" + opt + ":" + amt + "\nBalance:" + bal + "\n\n.................\n thank you for banking with us";
                    soundPlayer1.Play();
                }
            } else {
                opt = "transfer";
                instructLabl.Text = "please enter amount you want to transfer";
                trueBtn.Visible = false;
                falseBtn.Visible = false;
                if (textBox1.Text != "")
                {
                    int amount = Convert.ToInt32(textBox1.Text);
                    amt = amount;
                    balance -= amount;
                    bal = balance;
                    DateTime a = DateTime.Now;
                    instructLabl.Text = "transaction sucessful.\n Do you want receipt if yes enter ok or the receipt key ";
                    label3.Visible= true;
                    label3.Text = "............................\nATM\nTobisTech\n" + a + "\n ...........................\n Acct no: 1234-5613-1234 \n" + opt + ":" + amt + "\nBalance:" + bal + "\n\n.................\n thank you for banking with us";
                    soundPlayer1.Play();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptBtn_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible= false;
            DateTime a = DateTime.Now;
            trueBtn.Visible= false;
            falseBtn.Visible= false;
            label3.Visible= true;
            label3.Text= "............................\nATM\nTobisTech\n" + a + "\n ...........................\n Acct no: 1234-5613-1234 \n" + opt + ":" + amt + "\nBalance:" + bal + "\n\n............................\n thank you for banking with us";
            soundPlayer4.Play();
            instructLabl.Visible= false;
        }

        private void downEnter_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Amount";
            textBox1.Visible = true;
            if (trueBtn.Checked)
            {
                opt = "withdraw";
                instructLabl.Text = instruct[1];
                if (textBox1.Text != "")
                {
                    int amount = Convert.ToInt32(textBox1.Text);
                    amt = amount;

                    if (amount > balance)
                    {
                        instructLabl.Text = "insueffient fund";
                    }
                    else
                    {
                        balance -= amount;
                        bal = balance;
                        trueBtn.Visible = false;
                        falseBtn.Visible = false;
                        instructLabl.Text = "transaction sucessful.\n do you want a receipt if yes \n please enter receipt to continue";
                        trueBtn.Visible = true;
                        falseBtn.Visible = true;
                        trueBtn.Text = answer2[0];
                        falseBtn.Text = answer2[1];

                    }
                }
            } else if(Deposite.Checked)
            {
                opt = "transfer";
                instructLabl.Text = "please enter amount you want to Deposite";
                trueBtn.Visible = false;
                falseBtn.Visible = false;
                Deposite.Visible = false;
                if (textBox1.Text != "")
                {
                    int amount = Convert.ToInt32(textBox1.Text);
                    amt = amount;
                    balance += amount;
                    bal = balance;
                    opt = "Deposite"; 
                    DateTime a = DateTime.Now;
                    trueBtn.Visible = false;
                    falseBtn.Visible = false;
                    instructLabl.Text = "transaction sucessful.\n Do you want receipt if yes enter the receipt key ";
                    //label3.Visible= true;
                    //label3.Text = "............................\nATM\nTobisTech\n" + a + "\n ...........................\n Acct no: 1234-5613-1234 \n" + opt + ":" + amt + "\nBalance:" + bal + "\n\n.................\n thank you for banking with us";
                    soundPlayer2.Play();
                }
            }
            else
            {
                opt = "transfer";
                instructLabl.Text = "please enter amount you want to transfer";
                trueBtn.Visible = false;
                falseBtn.Visible = false;
                if (textBox1.Text != "")
                {
                    int amount = Convert.ToInt32(textBox1.Text);
                    amt = amount;
                    balance -= amount;
                    bal = balance;
                    DateTime a = DateTime.Now;
                    trueBtn.Visible = false;
                    falseBtn.Visible = false;
                    instructLabl.Text = "transaction sucessful.\n Do you want receipt if yes enter the receipt key ";
                   // label3.Visible= true;
                   // label3.Text = "............................\nATM\nTobisTech\n" + a + "\n ...........................\n Acct no: 1234-5613-1234 \n" + opt + ":" + amt + "\nBalance:" + bal + "\n\n.................\n thank you for banking with us";
                    soundPlayer1.Play();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            balance = 1000000000;
                soundPlayer.Play();
            label1.Visible = false;
            textBox1.Visible = false;
            instructLabl.Text = instruct[0];
            trueBtn.Text = answer1[0];
            falseBtn.Text = answer1[1];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}