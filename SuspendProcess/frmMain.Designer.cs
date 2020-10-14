namespace SuspendProcess
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.gbLoop = new System.Windows.Forms.GroupBox();
            this.txtLoopDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoopInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoopProcessName = new System.Windows.Forms.TextBox();
            this.cbLoop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.BtnSuspendProcess = new System.Windows.Forms.Button();
            this.lbProcessList = new System.Windows.Forms.ListBox();
            this.BtnRefreshList = new System.Windows.Forms.Button();
            this.TmrLoopProcessSuspend = new System.Windows.Forms.Timer(this.components);
            this.gbLoop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoop
            // 
            this.gbLoop.Controls.Add(this.txtLoopDelay);
            this.gbLoop.Controls.Add(this.label3);
            this.gbLoop.Controls.Add(this.txtLoopInterval);
            this.gbLoop.Controls.Add(this.label4);
            this.gbLoop.Controls.Add(this.txtLoopProcessName);
            this.gbLoop.Controls.Add(this.cbLoop);
            this.gbLoop.Controls.Add(this.label1);
            this.gbLoop.Location = new System.Drawing.Point(21, 346);
            this.gbLoop.Name = "gbLoop";
            this.gbLoop.Size = new System.Drawing.Size(343, 141);
            this.gbLoop.TabIndex = 6;
            this.gbLoop.TabStop = false;
            this.gbLoop.Text = "LOOP";
            // 
            // txtLoopDelay
            // 
            this.txtLoopDelay.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtLoopDelay.Location = new System.Drawing.Point(104, 64);
            this.txtLoopDelay.Name = "txtLoopDelay";
            this.txtLoopDelay.Size = new System.Drawing.Size(84, 25);
            this.txtLoopDelay.TabIndex = 4;
            this.txtLoopDelay.Text = "0";
            this.txtLoopDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoopDelay_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delay (MS)";
            // 
            // txtLoopInterval
            // 
            this.txtLoopInterval.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtLoopInterval.Location = new System.Drawing.Point(104, 104);
            this.txtLoopInterval.Name = "txtLoopInterval";
            this.txtLoopInterval.Size = new System.Drawing.Size(84, 25);
            this.txtLoopInterval.TabIndex = 3;
            this.txtLoopInterval.Text = "1000";
            this.txtLoopInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoopInterval_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interval (MS)";
            // 
            // txtLoopProcessName
            // 
            this.txtLoopProcessName.Location = new System.Drawing.Point(125, 30);
            this.txtLoopProcessName.Name = "txtLoopProcessName";
            this.txtLoopProcessName.Size = new System.Drawing.Size(208, 25);
            this.txtLoopProcessName.TabIndex = 0;
            // 
            // cbLoop
            // 
            this.cbLoop.AutoSize = true;
            this.cbLoop.Location = new System.Drawing.Point(250, 110);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(83, 19);
            this.cbLoop.TabIndex = 1;
            this.cbLoop.Text = "ENABLE";
            this.cbLoop.UseVisualStyleBackColor = true;
            this.cbLoop.CheckedChanged += new System.EventHandler(this.cbLoop_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Process Name";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(137, 18);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(227, 25);
            this.txtProcessName.TabIndex = 0;
            // 
            // BtnSuspendProcess
            // 
            this.BtnSuspendProcess.Location = new System.Drawing.Point(21, 49);
            this.BtnSuspendProcess.Name = "BtnSuspendProcess";
            this.BtnSuspendProcess.Size = new System.Drawing.Size(343, 32);
            this.BtnSuspendProcess.TabIndex = 2;
            this.BtnSuspendProcess.Text = "Suspend Process";
            this.BtnSuspendProcess.UseVisualStyleBackColor = true;
            this.BtnSuspendProcess.Click += new System.EventHandler(this.BtnSuspendProcess_Click);
            // 
            // lbProcessList
            // 
            this.lbProcessList.FormattingEnabled = true;
            this.lbProcessList.ItemHeight = 15;
            this.lbProcessList.Location = new System.Drawing.Point(21, 87);
            this.lbProcessList.Name = "lbProcessList";
            this.lbProcessList.Size = new System.Drawing.Size(343, 244);
            this.lbProcessList.TabIndex = 8;
            this.lbProcessList.Click += new System.EventHandler(this.lbProcessList_Click);
            // 
            // BtnRefreshList
            // 
            this.BtnRefreshList.Location = new System.Drawing.Point(251, 87);
            this.BtnRefreshList.Name = "BtnRefreshList";
            this.BtnRefreshList.Size = new System.Drawing.Size(113, 23);
            this.BtnRefreshList.TabIndex = 9;
            this.BtnRefreshList.Text = "Refresh List";
            this.BtnRefreshList.UseVisualStyleBackColor = true;
            this.BtnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // TmrLoopProcessSuspend
            // 
            this.TmrLoopProcessSuspend.Interval = 1000;
            this.TmrLoopProcessSuspend.Tick += new System.EventHandler(this.TmrLoopProcessSuspend_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 505);
            this.Controls.Add(this.BtnRefreshList);
            this.Controls.Add(this.lbProcessList);
            this.Controls.Add(this.BtnSuspendProcess);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbLoop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Suspend Process";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbLoop.ResumeLayout(false);
            this.gbLoop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLoop;
        private System.Windows.Forms.TextBox txtLoopProcessName;
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Button BtnSuspendProcess;
        private System.Windows.Forms.ListBox lbProcessList;
        private System.Windows.Forms.TextBox txtLoopInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoopDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRefreshList;
        private System.Windows.Forms.Timer TmrLoopProcessSuspend;
    }
}

