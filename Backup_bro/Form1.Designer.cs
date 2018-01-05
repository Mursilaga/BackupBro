namespace Backup_bro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.backup_timer = new System.Windows.Forms.Timer(this.components);
            this.errLabel = new System.Windows.Forms.Label();
            this.applyIntervalButton = new System.Windows.Forms.Button();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.openSrc = new System.Windows.Forms.OpenFileDialog();
            this.setSrcButton = new System.Windows.Forms.Button();
            this.setDstButton = new System.Windows.Forms.Button();
            this.openDst = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Backup_bro";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // backup_timer
            // 
            this.backup_timer.Enabled = true;
            this.backup_timer.Interval = timer_interval;
            this.backup_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Location = new System.Drawing.Point(12, 168);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(35, 13);
            this.errLabel.TabIndex = 0;
            this.errLabel.Text = "label1";
            // 
            // applyIntervalButton
            // 
            this.applyIntervalButton.Location = new System.Drawing.Point(64, 113);
            this.applyIntervalButton.Name = "applyIntervalButton";
            this.applyIntervalButton.Size = new System.Drawing.Size(137, 23);
            this.applyIntervalButton.TabIndex = 1;
            this.applyIntervalButton.Text = "Применить интервал";
            this.applyIntervalButton.UseVisualStyleBackColor = true;
            this.applyIntervalButton.Click += new System.EventHandler(this.applyIntervalButton_Click);
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(64, 35);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(42, 20);
            this.numHour.TabIndex = 2;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(64, 61);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(42, 20);
            this.numMin.TabIndex = 3;
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(64, 87);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(42, 20);
            this.numSec.TabIndex = 4;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(112, 37);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(35, 13);
            this.hourLabel.TabIndex = 5;
            this.hourLabel.Text = "Часы";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(112, 63);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(46, 13);
            this.minLabel.TabIndex = 6;
            this.minLabel.Text = "Минуты";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(112, 89);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(51, 13);
            this.secLabel.TabIndex = 7;
            this.secLabel.Text = "Секунды";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(43, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(192, 13);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Интервал создания резевных копий";
            // 
            // openSrc
            // 
            this.openSrc.FileName = "openFileDialog1";
            // 
            // setSrcButton
            // 
            this.setSrcButton.Location = new System.Drawing.Point(15, 142);
            this.setSrcButton.Name = "setSrcButton";
            this.setSrcButton.Size = new System.Drawing.Size(104, 23);
            this.setSrcButton.TabIndex = 9;
            this.setSrcButton.Text = "Путь к файлу";
            this.setSrcButton.UseVisualStyleBackColor = true;
            this.setSrcButton.Click += new System.EventHandler(this.setSrcButton_Click);
            // 
            // setDstButton
            // 
            this.setDstButton.Location = new System.Drawing.Point(126, 142);
            this.setDstButton.Name = "setDstButton";
            this.setDstButton.Size = new System.Drawing.Size(167, 23);
            this.setDstButton.TabIndex = 10;
            this.setDstButton.Text = "Путь для сохранения копий";
            this.setDstButton.UseVisualStyleBackColor = true;
            this.setDstButton.Click += new System.EventHandler(this.setDstButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 273);
            this.Controls.Add(this.setDstButton);
            this.Controls.Add(this.setSrcButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.numSec);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.applyIntervalButton);
            this.Controls.Add(this.errLabel);
            this.Name = "Form1";
            this.Text = "BackupBro";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer backup_timer;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Button applyIntervalButton;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.OpenFileDialog openSrc;
        private System.Windows.Forms.Button setSrcButton;
        private System.Windows.Forms.Button setDstButton;
        private System.Windows.Forms.FolderBrowserDialog openDst;
    }
}

