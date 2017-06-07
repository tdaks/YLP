namespace 서버_개발
{
    partial class Main
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
            this.btn_DBManager = new System.Windows.Forms.Button();
            this.btn_connectMobile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DBManager
            // 
            this.btn_DBManager.Location = new System.Drawing.Point(12, 12);
            this.btn_DBManager.Name = "btn_DBManager";
            this.btn_DBManager.Size = new System.Drawing.Size(96, 48);
            this.btn_DBManager.TabIndex = 0;
            this.btn_DBManager.Text = "DB 관리";
            this.btn_DBManager.UseVisualStyleBackColor = true;
            this.btn_DBManager.Click += new System.EventHandler(this.btn_DBManager_Click);
            // 
            // btn_connectMobile
            // 
            this.btn_connectMobile.Location = new System.Drawing.Point(12, 66);
            this.btn_connectMobile.Name = "btn_connectMobile";
            this.btn_connectMobile.Size = new System.Drawing.Size(96, 48);
            this.btn_connectMobile.TabIndex = 0;
            this.btn_connectMobile.Text = "모바일 통신?";
            this.btn_connectMobile.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 125);
            this.Controls.Add(this.btn_connectMobile);
            this.Controls.Add(this.btn_DBManager);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DBManager;
        private System.Windows.Forms.Button btn_connectMobile;
    }
}

