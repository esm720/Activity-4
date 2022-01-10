namespace Logic_Practice_CH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secVal = 0;
            int curSecVal = 0;
            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            try
            {
                if (int.TryParse(secIn.Text, out secVal)) // same with double.tryparse
                {
                    curSecVal = secVal;
                    if (secVal > 0)
                    {
                        if (curSecVal >= 86400)
                        {
                            days = curSecVal / 86400;
                            curSecVal = curSecVal % 86400;
                        }
                        if (curSecVal >= 3600)
                        {
                            hours = curSecVal / 3600;
                            curSecVal = curSecVal % 3600;
                        }
                        if (curSecVal >= 60)
                        {
                            minutes = curSecVal / 60;
                            curSecVal = curSecVal % 60;
                        }
                        if (curSecVal <= 60)
                        {
                            seconds = curSecVal;
                        }

                    }
                    else if (secVal <= 0)
                    {
                        MessageBox.Show("Can not convert input of negative or zero seconds.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid input.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid input (integer).");
                }

                minsOut.Text = minutes.ToString();
                daysOut.Text = days.ToString();
                secOut.Text =  seconds.ToString();
                hoursOut.Text = hours.ToString();

            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message); 
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minsOut.Text = string.Empty;
            daysOut.Text = string.Empty;   
            secOut.Text = string.Empty;
            hoursOut.Text = string.Empty;
            secIn.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}