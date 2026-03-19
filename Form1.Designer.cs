namespace Echo_Messenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lstMessages = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            lblCount = new Label();
            btnDelete = new Button();
            btnClearAll = new Button();
            SuspendLayout();
            //
            // lblTitle - 타이틀 라벨
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 71);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            //
            // lstMessages - 메시지 목록
            //
            lstMessages.Font = new Font("맑은 고딕", 11F);
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(30, 110);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(720, 370);
            lstMessages.TabIndex = 1;
            //
            // txtInput - 메시지 입력창
            //
            txtInput.Font = new Font("맑은 고딕", 11F);
            txtInput.Location = new Point(30, 500);
            txtInput.MaxLength = 50;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(560, 47);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            //
            // btnSend - 전송 버튼
            //
            btnSend.BackColor = Color.LimeGreen;
            btnSend.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            btnSend.Location = new Point(610, 490);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(140, 60);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            //
            // lblCount - 메시지 개수 표시 라벨
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("맑은 고딕", 10F);
            lblCount.Location = new Point(30, 560);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(200, 35);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            //
            // btnDelete - 선택 항목 삭제 버튼
            //
            btnDelete.Font = new Font("맑은 고딕", 10F);
            btnDelete.Location = new Point(450, 555);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // btnClearAll - 대화 기록 전체 삭제 버튼
            //
            btnClearAll.Font = new Font("맑은 고딕", 10F);
            btnClearAll.Location = new Point(600, 555);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(150, 45);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "대화 기록 삭제";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 620);
            Controls.Add(btnClearAll);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lstMessages);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstMessages;
        private TextBox txtInput;
        private Button btnSend;
        private Label lblCount;
        private Button btnDelete;
        private Button btnClearAll;
    }
}
