using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Backup_bro
{
    public partial class Form1 : Form
    {
        private Config config;
        private string conf_path = @"backup_config.txt";
        private string src_exten = "";
        private Int32 timer_interval = 600000; //10 sec
        bool IsVisibilityChangeAllowed { get; set; }

        protected override void SetVisibleCore(bool value)
        {
            if (this.IsVisibilityChangeAllowed)
            {
                base.SetVisibleCore(value);
            }
        }
        public Form1()
        {
            IsVisibilityChangeAllowed = true;
            bool exist = true;
            if(File.Exists(conf_path))
            {
                string readConf = File.ReadAllText(conf_path, Encoding.Default);
                config = JsonConvert.DeserializeObject<Config>(readConf);
                timer_interval = Convert.ToInt32(config.Interval, 10);  
            }
            else
            {
                exist = false;
            }
            InitializeComponent();

            if(exist)
            {
                errLabel.Text = "Файл конфигурации успешно открыт\nSrc: "
                             + config.Src
                             + "\nDst: "
                             + config.Dst
                             + "\nInterval: "
                             + timer_interval / 1000
                             + " sec\n";
                
                if(File.Exists(config.Src))
                {
                    errLabel.Text += "Файл для создания копий успешно найден";
                    src_exten = Path.GetExtension(config.Src);
                    IsVisibilityChangeAllowed = false;
                }
                else
                {
                    errLabel.Text += "Файл для создания копий не найден.\nСоздание копий отключено\n";
                    backup_timer.Enabled = false;
                }
            }
            else
            {
                errLabel.Text = "Файл конфигурации не найден\nОжидаемый путь: "
                             + Path.GetFullPath(conf_path)
                             + "\nПрограмма не инициализирована\nСоздание копий отключено";
                backup_timer.Enabled = false;
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IsVisibilityChangeAllowed = true;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              DateTime date = DateTime.Now;
              string dst = config.Dst + "//" + date.ToString("dd.MM.yy") + "//";
              Directory.CreateDirectory(dst);
              dst += date.ToString("HH.mm.ss") + src_exten;
              File.Copy(config.Src, dst);
        }

        private void applyIntervalButton_Click(object sender, EventArgs e)
        {
            timer_interval = (Int32)numSec.Value * 1000;
            timer_interval += (Int32)numMin.Value * 60000;
            timer_interval += (Int32)numHour.Value * 3600000;
            config.Interval = timer_interval.ToString();
            string writeConf = JsonConvert.SerializeObject(config);
            File.WriteAllText(conf_path, writeConf, Encoding.Unicode);

            errLabel.Text = "Новое значение интервала,\nравное "
                            + timer_interval / 1000
                            + " сек применено\nи записано в файл конфигурации.";
            backup_timer.Interval = timer_interval;
            backup_timer.Start();
        }


        private void setSrcButton_Click(object sender, EventArgs e)
        {
            if(openSrc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.Src = openSrc.FileName.ToString();
                File.WriteAllText(conf_path, JsonConvert.SerializeObject(config), Encoding.Unicode);

                errLabel.Text = "Новый путь к сохраняемому файлу:\n"
                                + config.Src;
            }
        }

        private void setDstButton_Click(object sender, EventArgs e)
        {
            if (openDst.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.Dst = openDst.SelectedPath.ToString();
                File.WriteAllText(conf_path, JsonConvert.SerializeObject(config), Encoding.Unicode);

                errLabel.Text = "Новый путь к для резервных копий:\n"
                                + config.Dst;
            }
        }
    }
}
