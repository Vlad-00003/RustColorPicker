namespace RustColorPicker
{
    partial class frm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.lblHex = new System.Windows.Forms.Label();
            this.lblRust = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtRust = new System.Windows.Forms.TextBox();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnRust = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.tbA = new System.Windows.Forms.TrackBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.picboxColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForceTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(15, 207);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(29, 13);
            this.lblHex.TabIndex = 1;
            this.lblHex.Text = "HEX";
            // 
            // lblRust
            // 
            this.lblRust.AutoSize = true;
            this.lblRust.Location = new System.Drawing.Point(15, 237);
            this.lblRust.Name = "lblRust";
            this.lblRust.Size = new System.Drawing.Size(29, 13);
            this.lblRust.TabIndex = 3;
            this.lblRust.Text = "Rust";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(50, 207);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(176, 20);
            this.txtHex.TabIndex = 4;
            // 
            // txtRust
            // 
            this.txtRust.Location = new System.Drawing.Point(50, 234);
            this.txtRust.Name = "txtRust";
            this.txtRust.Size = new System.Drawing.Size(176, 20);
            this.txtRust.TabIndex = 6;
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(232, 207);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(88, 23);
            this.btnHex.TabIndex = 7;
            this.btnHex.Text = "Convert Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnRust
            // 
            this.btnRust.Location = new System.Drawing.Point(232, 233);
            this.btnRust.Name = "btnRust";
            this.btnRust.Size = new System.Drawing.Size(88, 23);
            this.btnRust.TabIndex = 7;
            this.btnRust.Text = "Convert Rust";
            this.btnRust.UseVisualStyleBackColor = true;
            this.btnRust.Click += new System.EventHandler(this.btnRust_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(326, 207);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(118, 47);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Windows Color Picker";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(43, 6);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(222, 45);
            this.tbR.TabIndex = 9;
            this.tbR.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(43, 57);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(222, 45);
            this.tbG.TabIndex = 10;
            this.tbG.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(43, 108);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(222, 45);
            this.tbB.TabIndex = 11;
            this.tbB.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(43, 159);
            this.tbA.Maximum = 255;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(222, 45);
            this.tbA.TabIndex = 12;
            this.tbA.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(262, 14);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(60, 20);
            this.txtR.TabIndex = 13;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(262, 63);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(60, 20);
            this.txtG.TabIndex = 13;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(262, 113);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(60, 20);
            this.txtB.TabIndex = 13;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(262, 165);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(60, 20);
            this.txtA.TabIndex = 13;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(22, 14);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(27, 13);
            this.lblR.TabIndex = 14;
            this.lblR.Text = "Red";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(11, 63);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(36, 13);
            this.lblG.TabIndex = 14;
            this.lblG.Text = "Green";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(21, 113);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(28, 13);
            this.lblB.TabIndex = 14;
            this.lblB.Text = "Blue";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(15, 159);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(34, 13);
            this.lblA.TabIndex = 14;
            this.lblA.Text = "Alpha";
            // 
            // picboxColor
            // 
            this.picboxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxColor.Location = new System.Drawing.Point(328, 14);
            this.picboxColor.Name = "picboxColor";
            this.picboxColor.Size = new System.Drawing.Size(116, 171);
            this.picboxColor.TabIndex = 15;
            this.picboxColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(47, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Разработка RustPlugin.ru | Vlad-00003";
            // 
            // btnForceTop
            // 
            this.btnForceTop.Location = new System.Drawing.Point(326, 257);
            this.btnForceTop.Name = "btnForceTop";
            this.btnForceTop.Size = new System.Drawing.Size(118, 23);
            this.btnForceTop.TabIndex = 17;
            this.btnForceTop.Text = "Force on top: Off";
            this.btnForceTop.UseVisualStyleBackColor = true;
            this.btnForceTop.Click += new System.EventHandler(this.btnForceTop_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 284);
            this.Controls.Add(this.btnForceTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxColor);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnRust);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.txtRust);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.lblRust);
            this.Controls.Add(this.lblHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.Text = "Rust Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblRust;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtRust;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnRust;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.TrackBar tbA;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.PictureBox picboxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForceTop;
    }
}

