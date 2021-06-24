
namespace SmallpaintWF
{
    partial class Рисовашка
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
            this.pCbox1 = new System.Windows.Forms.PictureBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.panel_trackbara = new System.Windows.Forms.Panel();
            this.label1_panel1 = new System.Windows.Forms.Label();
            this.trackBar_panel1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pCbox1)).BeginInit();
            this.panel_trackbara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCbox1
            // 
            this.pCbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCbox1.Location = new System.Drawing.Point(0, 0);
            this.pCbox1.Name = "pCbox1";
            this.pCbox1.Size = new System.Drawing.Size(900, 473);
            this.pCbox1.TabIndex = 0;
            this.pCbox1.TabStop = false;
            this.pCbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCbox1_MouseDown);
            this.pCbox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCbox1_MouseMove);
            this.pCbox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pCbox1_MouseUp);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(3, 401);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(207, 60);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(3, 332);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(207, 63);
            this.buttonclear.TabIndex = 2;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_trackbara
            // 
            this.panel_trackbara.Controls.Add(this.label1_panel1);
            this.panel_trackbara.Controls.Add(this.trackBar_panel1);
            this.panel_trackbara.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_trackbara.Location = new System.Drawing.Point(0, 0);
            this.panel_trackbara.Name = "panel_trackbara";
            this.panel_trackbara.Size = new System.Drawing.Size(217, 100);
            this.panel_trackbara.TabIndex = 4;
            this.panel_trackbara.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_trackbara_Paint);
            // 
            // label1_panel1
            // 
            this.label1_panel1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_panel1.Location = new System.Drawing.Point(37, 23);
            this.label1_panel1.Name = "label1_panel1";
            this.label1_panel1.Size = new System.Drawing.Size(147, 29);
            this.label1_panel1.TabIndex = 1;
            this.label1_panel1.Text = "Выбор толщины!";
            this.label1_panel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_panel1
            // 
            this.trackBar_panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_panel1.Location = new System.Drawing.Point(0, 55);
            this.trackBar_panel1.Name = "trackBar_panel1";
            this.trackBar_panel1.Size = new System.Drawing.Size(217, 45);
            this.trackBar_panel1.TabIndex = 0;
            this.trackBar_panel1.Scroll += new System.EventHandler(this.trackBar_panel1_Scroll);
            this.trackBar_panel1.ValueChanged += new System.EventHandler(this.trackBar_panel1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(109, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(15, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(15, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SpringGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(109, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumPurple;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(109, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_trackbara);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.buttonsave);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonclear);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(683, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 473);
            this.panel1.TabIndex = 11;
            // 
            // Рисовашка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pCbox1);
            this.Name = "Рисовашка";
            this.Text = "Рисовашка с сохранением";
            ((System.ComponentModel.ISupportInitialize)(this.pCbox1)).EndInit();
            this.panel_trackbara.ResumeLayout(false);
            this.panel_trackbara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pCbox1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Panel panel_trackbara;
        private System.Windows.Forms.TrackBar trackBar_panel1;
        private System.Windows.Forms.Label label1_panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

