namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Weather> weatherList = new List<Weather>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.weatherList.Clear();
            for (var i = 0; i<10; ++i)
            {
                this.weatherList.Add(new Sun());
            }
        }
        private void ShowInfo()
        {
            int sunCount = 0;
            int rainCount = 0;
            int snowCount = 0;

            foreach(var weather in this.weatherList)
            {
                if (weather is Sun)
                {
                    sunCount += 1;
                }
                else if (weather is Rain)
                {
                    rainCount += 1;
                }
                else if (weather is Snow)
                {
                    snowCount += 1;
                }
            }
            txtInfo.Text = "Солнце\tДождь\tСнег";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", sunCount, rainCount, snowCount);
        }
    }
}
