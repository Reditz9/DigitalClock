namespace Digital_Clock
{
    partial class Clock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Horario = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Meridium = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Horario
            // 
            this.Horario.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Horario.Location = new System.Drawing.Point(37, 83);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(426, 138);
            this.Horario.TabIndex = 2;
            this.Horario.Text = "00:00:00";
            this.Horario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data.Location = new System.Drawing.Point(37, 9);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(426, 46);
            this.Data.TabIndex = 4;
            this.Data.Text = "segunda-feira, 1 de janeiro de 0000";
            this.Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "BR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "EN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Meridium
            // 
            this.Meridium.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Meridium.Location = new System.Drawing.Point(367, 96);
            this.Meridium.Name = "Meridium";
            this.Meridium.Size = new System.Drawing.Size(67, 58);
            this.Meridium.TabIndex = 7;
            this.Meridium.Text = "AM";
            this.Meridium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.Meridium);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Horario);
            this.Name = "Clock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label Horario;
        private Label Data;
        private Button button1;
        private Button button2;
        private Label Meridium;
    }
}