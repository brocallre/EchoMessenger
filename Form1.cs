namespace Echo_Messenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 전송 버튼 클릭 이벤트 핸들러
        private void btnSend_Click(object sender, EventArgs e)
        {
            // 입력된 메시지 가져오기
            string typed_msg = txtInput.Text;

            // 메시지를 리스트박스에 추가
            lstMessages.Items.Add(typed_msg);

            // 입력창 비우기
            txtInput.Clear();
        }
    }
}
