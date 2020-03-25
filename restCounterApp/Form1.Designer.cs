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
            this.btnSaveScore = new System.Windows.Forms.Button();
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
            this.pnlOpenScore = new System.Windows.Forms.Panel();
            this.lblPieceNameEnter = new System.Windows.Forms.Label();
            this.mtxtFileName = new System.Windows.Forms.MaskedTextBox();
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
            this.lblTitle.Location = new System.Drawing.Point(3, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REST COUNTER";
            // 
            // btnNewScore
            // 
            this.btnNewScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewScore.Location = new System.Drawing.Point(74, 163);
            this.btnNewScore.Name = "btnNewScore";
            this.btnNewScore.Size = new System.Drawing.Size(74, 23);
            this.btnNewScore.TabIndex = 1;
            this.btnNewScore.Text = "new score";
            this.btnNewScore.UseVisualStyleBackColor = true;
            this.btnNewScore.Click += new System.EventHandler(this.btnNewScore_Click);
            // 
            // btnSavedScore
            // 
            this.btnSavedScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavedScore.Location = new System.Drawing.Point(74, 203);
            this.btnSavedScore.Name = "btnSavedScore";
            this.btnSavedScore.Size = new System.Drawing.Size(74, 23);
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
            this.pnlMainMenu.Location = new System.Drawing.Point(59, 26);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(224, 299);
            this.pnlMainMenu.TabIndex = 3;
            this.pnlMainMenu.Visible = false;
            // 
            // pnlInputNewScore
            // 
            this.pnlInputNewScore.Controls.Add(this.mtxtFileName);
            this.pnlInputNewScore.Controls.Add(this.lblPieceNameEnter);
            this.pnlInputNewScore.Controls.Add(this.btnSaveScore);
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
            this.pnlInputNewScore.Location = new System.Drawing.Point(12, 12);
            this.pnlInputNewScore.Name = "pnlInputNewScore";
            this.pnlInputNewScore.Size = new System.Drawing.Size(318, 326);
            this.pnlInputNewScore.TabIndex = 4;
            this.pnlInputNewScore.Visible = false;
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScore.Location = new System.Drawing.Point(24, 287);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(120, 23);
            this.btnSaveScore.TabIndex = 16;
            this.btnSaveScore.Text = "save";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
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
            this.cmbQueueType.Location = new System.Drawing.Point(25, 196);
            this.cmbQueueType.Name = "cmbQueueType";
            this.cmbQueueType.Size = new System.Drawing.Size(120, 23);
            this.cmbQueueType.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(25, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCmbDescript
            // 
            this.lblCmbDescript.AutoSize = true;
            this.lblCmbDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmbDescript.Location = new System.Drawing.Point(24, 179);
            this.lblCmbDescript.Name = "lblCmbDescript";
            this.lblCmbDescript.Size = new System.Drawing.Size(33, 15);
            this.lblCmbDescript.TabIndex = 13;
            this.lblCmbDescript.Text = "type:";
            // 
            // lblMeasureDescript
            // 
            this.lblMeasureDescript.AutoSize = true;
            this.lblMeasureDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasureDescript.Location = new System.Drawing.Point(24, 132);
            this.lblMeasureDescript.Name = "lblMeasureDescript";
            this.lblMeasureDescript.Size = new System.Drawing.Size(91, 15);
            this.lblMeasureDescript.TabIndex = 12;
            this.lblMeasureDescript.Text = "number of bars:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(24, 229);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 23);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "add to queue";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtEnterQueue
            // 
            this.txtEnterQueue.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterQueue.Location = new System.Drawing.Point(25, 149);
            this.txtEnterQueue.Name = "txtEnterQueue";
            this.txtEnterQueue.Size = new System.Drawing.Size(120, 23);
            this.txtEnterQueue.TabIndex = 9;
            // 
            // lstboxQueues
            // 
            this.lstboxQueues.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxQueues.FormattingEnabled = true;
            this.lstboxQueues.ItemHeight = 15;
            this.lstboxQueues.Location = new System.Drawing.Point(172, 132);
            this.lstboxQueues.Name = "lstboxQueues";
            this.lstboxQueues.Size = new System.Drawing.Size(123, 124);
            this.lstboxQueues.TabIndex = 7;
            // 
            // nudNumerator
            // 
            this.nudNumerator.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumerator.Location = new System.Drawing.Point(41, 56);
            this.nudNumerator.Name = "nudNumerator";
            this.nudNumerator.Size = new System.Drawing.Size(48, 38);
            this.nudNumerator.TabIndex = 6;
            // 
            // lblBpmDescript
            // 
            this.lblBpmDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpmDescript.Location = new System.Drawing.Point(226, 59);
            this.lblBpmDescript.Name = "lblBpmDescript";
            this.lblBpmDescript.Size = new System.Drawing.Size(69, 32);
            this.lblBpmDescript.TabIndex = 5;
            this.lblBpmDescript.Text = "beats per minute";
            // 
            // lblNumeratorDescript
            // 
            this.lblNumeratorDescript.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeratorDescript.Location = new System.Drawing.Point(94, 57);
            this.lblNumeratorDescript.Name = "lblNumeratorDescript";
            this.lblNumeratorDescript.Size = new System.Drawing.Size(50, 35);
            this.lblNumeratorDescript.TabIndex = 4;
            this.lblNumeratorDescript.Text = "beats per bar";
            // 
            // mtxtBpm
            // 
            this.mtxtBpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtBpm.Location = new System.Drawing.Point(172, 56);
            this.mtxtBpm.Mask = "999";
            this.mtxtBpm.Name = "mtxtBpm";
            this.mtxtBpm.Size = new System.Drawing.Size(48, 35);
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
            this.label1.Location = new System.Drawing.Point(93, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "INPUT RESTS";
            // 
            // lblTimeSignature
            // 
            this.lblTimeSignature.AutoSize = true;
            this.lblTimeSignature.Font = new System.Drawing.Font("Caladea", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSignature.Location = new System.Drawing.Point(45, 22);
            this.lblTimeSignature.Name = "lblTimeSignature";
            this.lblTimeSignature.Size = new System.Drawing.Size(228, 22);
            this.lblTimeSignature.TabIndex = 0;
            this.lblTimeSignature.Text = "INPUT TIME SIGNATURE";
            // 
            // pnlRunScore
            // 
            this.pnlRunScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.pnlRunScore.Location = new System.Drawing.Point(0, 0);
            this.pnlRunScore.Name = "pnlRunScore";
            this.pnlRunScore.Size = new System.Drawing.Size(343, 351);
            this.pnlRunScore.TabIndex = 16;
            this.pnlRunScore.Visible = false;
            // 
            // pnlOpenScore
            // 
            this.pnlOpenScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlOpenScore.Location = new System.Drawing.Point(0, 0);
            this.pnlOpenScore.Name = "pnlOpenScore";
            this.pnlOpenScore.Size = new System.Drawing.Size(343, 351);
            this.pnlOpenScore.TabIndex = 0;
            // 
            // lblPieceNameEnter
            // 
            this.lblPieceNameEnter.AutoSize = true;
            this.lblPieceNameEnter.Font = new System.Drawing.Font("Frank Ruhl Hofshi", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieceNameEnter.Location = new System.Drawing.Point(170, 270);
            this.lblPieceNameEnter.Name = "lblPieceNameEnter";
            this.lblPieceNameEnter.Size = new System.Drawing.Size(71, 15);
            this.lblPieceNameEnter.TabIndex = 18;
            this.lblPieceNameEnter.Text = "name of file:";
            // 
            // mtxtFileName
            // 
            this.mtxtFileName.Location = new System.Drawing.Point(172, 289);
            this.mtxtFileName.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.mtxtFileName.Name = "mtxtFileName";
            this.mtxtFileName.Size = new System.Drawing.Size(123, 20);
            this.mtxtFileName.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlOpenScore);
            this.Controls.Add(this.pnlRunScore);
            this.Controls.Add(this.pnlInputNewScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rest Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Panel pnlOpenScore;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.Label lblPieceNameEnter;
        private System.Windows.Forms.MaskedTextBox mtxtFileName;
    }
}

