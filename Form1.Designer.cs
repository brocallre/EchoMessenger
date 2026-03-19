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
            lstMessages.Size = new Size(720, 400);
            lstMessages.TabIndex = 1;
            //
            // txtInput - 메시지 입력창
            //
            txtInput.Font = new Font("맑은 고딕", 11F);
            txtInput.Location = new Point(30, 540);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(560, 47);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            //
            // btnSend - 전송 버튼
            //
            btnSend.BackColor = Color.LimeGreen;
            btnSend.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            btnSend.Location = new Point(610, 530);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(140, 60);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 620);
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
    }
}
