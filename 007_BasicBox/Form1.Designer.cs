namespace _007_BasicBox
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
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblN.Location = new System.Drawing.Point(107, 145);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(42, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "이름 : ";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtN.Location = new System.Drawing.Point(184, 142);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 23);
            this.txtN.TabIndex = 1;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnC.Location = new System.Drawing.Point(374, 139);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "클릭";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblR.Location = new System.Drawing.Point(109, 213);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 15);
            this.lblR.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 334);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblR;
    }
}

