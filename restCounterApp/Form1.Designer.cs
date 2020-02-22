namespace restCounterApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewScore = new System.Windows.Forms.Button();
            this.btnSavedScore = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlInputNewScore = new System.Windows.Forms.Panel();
            this.cmbQueueType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCmbDescript = new System.Windows.Forms.Label();
            this.lblMeasureDescript = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtEnterQueue = new System.Windows.Forms.TextBox();
            this.lstboxQueues = new System.Windows.Forms.ListBox();
            this.nudNumerator = new System.Windows.Forms.NumericUpDown();
            this.lblBpmDescript = new System.Windows.Forms.Label();
            this.lblNumeratorDescript = new System.Windows.Forms.Label();
            this.mtxtBpm = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeSignature = new System.Windows.Forms.Label();
            this.pnlRunScore = new System.Windows.Forms.Panel();
            this.pnlMainMenu.SuspendLayout();
            this.pnlInputNewScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Caladea", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 144);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REST COUNTER";
            // 
            // btnNewScore
            // 
            this.btnNewScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewScore.Location = new System.Drawing.Point(148, 313);
            this.btnNewScore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewScore.Name = "btnNewScore";
            this.btnNewScore.Size = new System.Drawing.Size(148, 44);
            this.btnNewScore.TabIndex = 1;
            this.btnNewScore.Text = "new score";
            this.btnNewScore.UseVisualStyleBackColor = true;
            this.btnNewScore.Click += new System.EventHandler(this.btnNewScore_Click);
            // 
            // btnSavedScore
            // 
            this.btnSavedScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavedScore.Location = new System.Drawing.Point(148, 390);
            this.btnSavedScore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSavedScore.Name = "btnSavedScore";
            this.btnSavedScore.Size = new System.Drawing.Size(148, 44);
            this.btnSavedScore.TabIndex = 2;
            this.btnSavedScore.Text = "saved score";
            this.btnSavedScore.UseVisualStyleBackColor = true;
            this.btnSavedScore.Click += new System.EventHandler(this.btnSavedScore_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.lblTitle);
            this.pnlMainMenu.Controls.Add(this.btnSavedScore);
            this.pnlMainMenu.Controls.Add(this.btnNewScore);
            this.pnlMainMenu.Location = new System.Drawing.Point(118, 50);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(448, 575);
            this.pnlMainMenu.TabIndex = 3;
            this.pnlMainMenu.Visible = false;
            // 
            // pnlInputNewScore
            // 
            this.pnlInputNewScore.Controls.Add(this.cmbQueueType);
            this.pnlInputNewScore.Controls.Add(this.btnStart);
            this.pnlInputNewScore.Controls.Add(this.lblCmbDescript);
            this.pnlInputNewScore.Controls.Add(this.lblMeasureDescript);
            this.pnlInputNewScore.Controls.Add(this.btnEnter);
            this.pnlInputNewScore.Controls.Add(this.txtEnterQueue);
            this.pnlInputNewScore.Controls.Add(this.lstboxQueues);
            this.pnlInputNewScore.Controls.Add(this.nudNumerator);
            this.pnlInputNewScore.Controls.Add(this.lblBpmDescript);
            this.pnlInputNewScore.Controls.Add(this.lblNumeratorDescript);
            this.pnlInputNewScore.Controls.Add(this.mtxtBpm);
            this.pnlInputNewScore.Controls.Add(this.label1);
            this.pnlInputNewScore.Controls.Add(this.lblTimeSignature);
            this.pnlInputNewScore.Location = new System.Drawing.Point(24, 23);
            this.pnlInputNewScore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlInputNewScore.Name = "pnlInputNewScore";
            this.pnlInputNewScore.Size = new System.Drawing.Size(636, 627);
            this.pnlInputNewScore.TabIndex = 4;
            this.pnlInputNewScore.Visible = false;
            // 
            // cmbQueueType
            // 
            this.cmbQueueType.AutoCompleteCustomSource.AddRange(new string[] {
            "music",
            "rest"});
            this.cmbQueueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueueType.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQueueType.FormattingEnabled = true;
            this.cmbQueueType.Items.AddRange(new object[] {
            "music",
            "rest"});
            this.cmbQueueType.Location = new System.Drawing.Point(50, 415);
            this.cmbQueueType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbQueueType.Name = "cmbQueueType";
            this.cmbQueueType.Size = new System.Drawing.Size(236, 39);
            this.cmbQueueType.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(54, 548);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(236, 44);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCmbDescript
            // 
            this.lblCmbDescript.AutoSize = true;
            this.lblCmbDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmbDescript.Location = new System.Drawing.Point(48, 383);
            this.lblCmbDescript.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCmbDescript.Name = "lblCmbDescript";
            this.lblCmbDescript.Size = new System.Drawing.Size(66, 31);
            this.lblCmbDescript.TabIndex = 13;
            this.lblCmbDescript.Text = "type:";
            // 
            // lblMeasureDescript
            // 
            this.lblMeasureDescript.AutoSize = true;
            this.lblMeasureDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasureDescript.Location = new System.Drawing.Point(48, 292);
            this.lblMeasureDescript.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMeasureDescript.Name = "lblMeasureDescript";
            this.lblMeasureDescript.Size = new System.Drawing.Size(180, 31);
            this.lblMeasureDescript.TabIndex = 12;
            this.lblMeasureDescript.Text = "number of bars:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(50, 481);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(240, 44);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "add to queue";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtEnterQueue
            // 
            this.txtEnterQueue.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterQueue.Location = new System.Drawing.Point(50, 325);
            this.txtEnterQueue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEnterQueue.Name = "txtEnterQueue";
            this.txtEnterQueue.Size = new System.Drawing.Size(236, 38);
            this.txtEnterQueue.TabIndex = 9;
            // 
            // lstboxQueues
            // 
            this.lstboxQueues.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxQueues.FormattingEnabled = true;
            this.lstboxQueues.ItemHeight = 31;
            this.lstboxQueues.Location = new System.Drawing.Point(344, 292);
            this.lstboxQueues.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstboxQueues.Name = "lstboxQueues";
            this.lstboxQueues.Size = new System.Drawing.Size(242, 283);
            this.lstboxQueues.TabIndex = 7;
            // 
            // nudNumerator
            // 
            this.nudNumerator.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumerator.Location = new System.Drawing.Point(82, 127);
            this.nudNumerator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudNumerator.Name = "nudNumerator";
            this.nudNumerator.Size = new System.Drawing.Size(96, 69);
            this.nudNumerator.TabIndex = 6;
            // 
            // lblBpmDescript
            // 
            this.lblBpmDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpmDescript.Location = new System.Drawing.Point(452, 133);
            this.lblBpmDescript.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBpmDescript.Name = "lblBpmDescript";
            this.lblBpmDescript.Size = new System.Drawing.Size(138, 62);
            this.lblBpmDescript.TabIndex = 5;
            this.lblBpmDescript.Text = "beats per minute";
            // 
            // lblNumeratorDescript
            // 
            this.lblNumeratorDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeratorDescript.Location = new System.Drawing.Point(188, 129);
            this.lblNumeratorDescript.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeratorDescript.Name = "lblNumeratorDescript";
            this.lblNumeratorDescript.Size = new System.Drawing.Size(100, 67);
            this.lblNumeratorDescript.TabIndex = 4;
            this.lblNumeratorDescript.Text = "beats per bar";
            // 
            // mtxtBpm
            // 
            this.mtxtBpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtBpm.Location = new System.Drawing.Point(344, 127);
            this.mtxtBpm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mtxtBpm.Mask = "999";
            this.mtxtBpm.Name = "mtxtBpm";
            this.mtxtBpm.Size = new System.Drawing.Size(92, 62);
            this.mtxtBpm.TabIndex = 3;
            this.mtxtBpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtBpm.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtBpm.ValidatingType = typeof(int);
            this.mtxtBpm.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtBpm_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caladea", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "INPUT RESTS";
            // 
            // lblTimeSignature
            // 
            this.lblTimeSignature.AutoSize = true;
            this.lblTimeSignature.Font = new System.Drawing.Font("Caladea", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSignature.Location = new System.Drawing.Point(90, 42);
            this.lblTimeSignature.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTimeSignature.Name = "lblTimeSignature";
            this.lblTimeSignature.Size = new System.Drawing.Size(431, 44);
            this.lblTimeSignature.TabIndex = 0;
            this.lblTimeSignature.Text = "INPUT TIME SIGNATURE";
            // 
            // pnlRunScore
            // 
            this.pnlRunScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.pnlRunScore.Location = new System.Drawing.Point(0, 0);
            this.pnlRunScore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlRunScore.Name = "pnlRunScore";
            this.pnlRunScore.Size = new System.Drawing.Size(686, 675);
            this.pnlRunScore.TabIndex = 16;
            this.pnlRunScore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 673);
            this.Controls.Add(this.pnlRunScore);
            this.Controls.Add(this.pnlInputNewScore);
            this.Controls.Add(this.pnlMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Rest Counter";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.pnlInputNewScore.ResumeLayout(false);
            this.pnlInputNewScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewScore;
        private System.Windows.Forms.Button btnSavedScore;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlInputNewScore;
        private System.Windows.Forms.Label lblBpmDescript;
        private System.Windows.Forms.Label lblNumeratorDescript;
        private System.Windows.Forms.MaskedTextBox mtxtBpm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeSignature;
        private System.Windows.Forms.NumericUpDown nudNumerator;
        private System.Windows.Forms.Label lblCmbDescript;
        private System.Windows.Forms.Label lblMeasureDescript;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtEnterQueue;
        private System.Windows.Forms.ListBox lstboxQueues;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbQueueType;
        private System.Windows.Forms.Panel pnlRunScore;
    }
}

