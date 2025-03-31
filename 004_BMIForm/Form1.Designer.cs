namespace _004_BMIForm
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
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.PicC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblH.Location = new System.Drawing.Point(60, 62);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(44, 15);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "키(cm)";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblW.Location = new System.Drawing.Point(60, 131);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(54, 15);
            this.lblW.TabIndex = 1;
            this.lblW.Text = "체중(kg)";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtH.Location = new System.Drawing.Point(175, 59);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 23);
            this.txtH.TabIndex = 2;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtW.Location = new System.Drawing.Point(175, 128);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 23);
            this.txtW.TabIndex = 3;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBMI
            // 
            this.btnBMI.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBMI.Location = new System.Drawing.Point(175, 182);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(100, 21);
            this.btnBMI.TabIndex = 4;
            this.btnBMI.Text = "BMI 계산";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBMI.Location = new System.Drawing.Point(36, 246);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 15);
            this.lblBMI.TabIndex = 5;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblR.Location = new System.Drawing.Point(39, 294);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 15);
            this.lblR.TabIndex = 6;
            // 
            // PicC
            // 
            this.PicC.Location = new System.Drawing.Point(210, 246);
            this.PicC.Name = "PicC";
            this.PicC.Size = new System.Drawing.Size(64, 59);
            this.PicC.TabIndex = 7;
            this.PicC.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 360);
            this.Controls.Add(this.PicC);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "BMI 계산기 v.01 by 양희상";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.PictureBox PicC;
    }
}

