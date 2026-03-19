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

            // 빈 문자열이나 공백만 있는 경우 전송 방지
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtInput.Clear();
                txtInput.Focus();
                return;
            }

            // 메시지를 리스트박스에 추가
            lstMessages.Items.Add(typed_msg);

            // 입력창 비우기
            txtInput.Clear();

            // 입력창에 포커스 자동 이동
            txtInput.Focus();
        }

        // 입력창에서 엔터키 누르면 전송
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 전송 버튼 클릭과 동일하게 처리
                btnSend_Click(sender, e);

                // 엔터키 입력 소리 방지
                e.SuppressKeyPress = true;
            }
        }
    }
}
