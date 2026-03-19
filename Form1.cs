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

            // 앞뒤 공백 제거
            typed_msg = typed_msg.Trim();

            // 글자 수 50자 초과 시 경고 메시지 표시 및 전송 차단
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이내로 입력해주세요.", "글자 수 초과",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 타임스탬프를 메시지 앞에 결합
            string result = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {typed_msg}";

            // 메시지를 리스트박스에 추가
            lstMessages.Items.Add(result);

            // 메시지 개수를 하단 라벨에 업데이트
            lblCount.Text = $"현재 대화: {lstMessages.Items.Count}개";

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

        // 선택 항목 삭제 버튼 클릭 이벤트 핸들러
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택된 항목이 없는 경우 예외 처리
            if (lstMessages.SelectedItem == null)
            {
                MessageBox.Show("삭제할 항목을 먼저 선택해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 선택된 항목 삭제
            lstMessages.Items.Remove(lstMessages.SelectedItem);

            // 메시지 개수 업데이트
            lblCount.Text = $"현재 대화: {lstMessages.Items.Count}개";
        }

        // 대화 기록 전체 삭제 버튼 클릭 이벤트 핸들러
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // 리스트의 모든 내용을 한 번에 삭제
            lstMessages.Items.Clear();

            // 메시지 개수 업데이트
            lblCount.Text = $"현재 대화: 0개";
        }
    }
}
