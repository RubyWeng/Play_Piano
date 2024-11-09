namespace piano2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDo = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnFa = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.btnLa = new System.Windows.Forms.Button();
            this.btnSo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(243, 385);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 25);
            this.btnDo.TabIndex = 0;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnRe
            // 
            this.btnRe.Location = new System.Drawing.Point(323, 385);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(75, 25);
            this.btnRe.TabIndex = 1;
            this.btnRe.Text = "Re";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnFa
            // 
            this.btnFa.Location = new System.Drawing.Point(483, 385);
            this.btnFa.Name = "btnFa";
            this.btnFa.Size = new System.Drawing.Size(75, 25);
            this.btnFa.TabIndex = 3;
            this.btnFa.Text = "Fa";
            this.btnFa.UseVisualStyleBackColor = true;
            this.btnFa.Click += new System.EventHandler(this.btnFe_Click);
            // 
            // btnMi
            // 
            this.btnMi.Location = new System.Drawing.Point(403, 385);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(75, 25);
            this.btnMi.TabIndex = 2;
            this.btnMi.Text = "Mi";
            this.btnMi.UseVisualStyleBackColor = true;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // btnLa
            // 
            this.btnLa.Location = new System.Drawing.Point(643, 385);
            this.btnLa.Name = "btnLa";
            this.btnLa.Size = new System.Drawing.Size(75, 25);
            this.btnLa.TabIndex = 5;
            this.btnLa.Text = "La";
            this.btnLa.UseVisualStyleBackColor = true;
            this.btnLa.Click += new System.EventHandler(this.btnLa_Click);
            // 
            // btnSo
            // 
            this.btnSo.Location = new System.Drawing.Point(563, 385);
            this.btnSo.Name = "btnSo";
            this.btnSo.Size = new System.Drawing.Size(75, 25);
            this.btnSo.TabIndex = 4;
            this.btnSo.Text = "So";
            this.btnSo.UseVisualStyleBackColor = true;
            this.btnSo.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(723, 385);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 25);
            this.btnSi.TabIndex = 6;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(35, 388);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(75, 23);
            this.btnPaint.TabIndex = 7;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "小蜜蜂",
            "小星星"});
            this.comboBox1.Location = new System.Drawing.Point(29, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(125, 33);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(171, 319);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 452);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnLa);
            this.Controls.Add(this.btnSo);
            this.Controls.Add(this.btnFa);
            this.Controls.Add(this.btnMi);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnDo);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnFa;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Button btnLa;
        private System.Windows.Forms.Button btnSo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

