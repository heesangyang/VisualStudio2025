namespace _005_LoginForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnL = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnL.Location = new System.Drawing.Point(100, 166);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(81, 23);
            this.btnL.TabIndex = 0;
            this.btnL.Text = "로그인 하기";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(37, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "아이디";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPW.Location = new System.Drawing.Point(37, 113);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(55, 15);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "패스워드";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(100, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 23);
            this.txtID.TabIndex = 3;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPW.Location = new System.Drawing.Point(100, 104);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(85, 23);
            this.txtPW.TabIndex = 4;
            // 
            // txtL
            // 
            this.txtL.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtL.Location = new System.Drawing.Point(100, 210);
            this.txtL.Name = "txtL";
            this.txtL.ReadOnly = true;
            this.txtL.Size = new System.Drawing.Size(81, 23);
            this.txtL.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 263);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnL);
            this.Name = "Form1";
            this.Text = "로그인 창";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtL;
    }
}

