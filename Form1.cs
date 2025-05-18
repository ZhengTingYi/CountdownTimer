namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        private int secondsLeft = 100;  // �˼ƪ�l��Ƭ� 100
        private System.Windows.Forms.Timer timer;            // Timer ����A�ΨӨC��Ĳ�o
        public Form1()
        {
            InitializeComponent();

            // ��l�� Timer ����
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // �]�w�� 1 ��]1000 �@��^
            timer.Tick += Timer_Tick; // �C��Ĳ�o�@���ƥ�
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
   
        }

        // �p�ɾ��C��Ĳ�o�@���A�B�z�˼��޿�
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;                                     // �C��� 1
            label1.Text = secondsLeft.ToString();             // ��s�e�����

            if (secondsLeft <= 0)
            {
                timer.Stop();                                  // ���� Timer
                MessageBox.Show("�ɶ���I", "����");           // ��ܰT����
            }
        }
        // �I�����s�}�l�˼�
        private void button1_Click(object sender, EventArgs e)
        {
            secondsLeft = 100;                                 // ���]�� 100 ��]�i��^
            label1.Text = secondsLeft.ToString();             // ��ܪ�l���
            timer.Start();                                     // �Ұʭp�ɾ�
        }
    }
}
