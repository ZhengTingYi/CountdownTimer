namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        private int secondsLeft = 100;  // 倒數初始秒數為 100
        private System.Windows.Forms.Timer timer;            // Timer 控制項，用來每秒觸發
        public Form1()
        {
            InitializeComponent();

            // 初始化 Timer 元件
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 設定為 1 秒（1000 毫秒）
            timer.Tick += Timer_Tick; // 每秒觸發一次事件
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
   
        }

        // 計時器每秒觸發一次，處理倒數邏輯
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;                                     // 每秒減 1
            label1.Text = secondsLeft.ToString();             // 更新畫面顯示

            if (secondsLeft <= 0)
            {
                timer.Stop();                                  // 停止 Timer
                MessageBox.Show("時間到！", "提醒");           // 顯示訊息框
            }
        }
        // 點擊按鈕開始倒數
        private void button1_Click(object sender, EventArgs e)
        {
            secondsLeft = 100;                                 // 重設為 100 秒（可選）
            label1.Text = secondsLeft.ToString();             // 顯示初始秒數
            timer.Start();                                     // 啟動計時器
        }
    }
}
