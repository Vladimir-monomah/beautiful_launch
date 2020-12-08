namespace красивый_запуск
{
    partial class Устный_счёт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Устный_счёт));
            this.text_max = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button_divs = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.text_answer = new System.Windows.Forms.TextBox();
            this.label_think = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_max
            // 
            this.text_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_max.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_max.Location = new System.Drawing.Point(623, 172);
            this.text_max.Margin = new System.Windows.Forms.Padding(4);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(117, 39);
            this.text_max.TabIndex = 12;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(13, 121);
            this.progress.Margin = new System.Windows.Forms.Padding(4);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(728, 28);
            this.progress.TabIndex = 11;
            this.progress.Visible = false;
            // 
            // button_divs
            // 
            this.button_divs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divs.Location = new System.Drawing.Point(481, 172);
            this.button_divs.Margin = new System.Windows.Forms.Padding(4);
            this.button_divs.Name = "button_divs";
            this.button_divs.Size = new System.Drawing.Size(135, 43);
            this.button_divs.TabIndex = 7;
            this.button_divs.Text = "Деление";
            this.button_divs.UseVisualStyleBackColor = true;
            this.button_divs.Click += new System.EventHandler(this.button_divs_Click);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mult.Location = new System.Drawing.Point(311, 172);
            this.button_mult.Margin = new System.Windows.Forms.Padding(4);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(161, 43);
            this.button_mult.TabIndex = 8;
            this.button_mult.Text = "Умножение";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(155, 172);
            this.button_minus.Margin = new System.Windows.Forms.Padding(4);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(148, 43);
            this.button_minus.TabIndex = 9;
            this.button_minus.Text = "Вычитание";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(13, 172);
            this.button_plus.Margin = new System.Windows.Forms.Padding(4);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(135, 43);
            this.button_plus.TabIndex = 10;
            this.button_plus.Text = "Сложение";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // text_answer
            // 
            this.text_answer.Enabled = false;
            this.text_answer.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_answer.Location = new System.Drawing.Point(471, 9);
            this.text_answer.Margin = new System.Windows.Forms.Padding(4);
            this.text_answer.Name = "text_answer";
            this.text_answer.Size = new System.Drawing.Size(268, 105);
            this.text_answer.TabIndex = 6;
            this.text_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_answer_KeyDown);
            // 
            // label_think
            // 
            this.label_think.BackColor = System.Drawing.Color.White;
            this.label_think.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_think.Enabled = false;
            this.label_think.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_think.Location = new System.Drawing.Point(13, 9);
            this.label_think.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_think.Name = "label_think";
            this.label_think.Size = new System.Drawing.Size(450, 104);
            this.label_think.TabIndex = 5;
            this.label_think.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Устный_счёт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 235);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button_divs);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.text_answer);
            this.Controls.Add(this.label_think);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Устный_счёт";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устный счёт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button button_divs;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.TextBox text_answer;
        private System.Windows.Forms.Label label_think;
    }
}