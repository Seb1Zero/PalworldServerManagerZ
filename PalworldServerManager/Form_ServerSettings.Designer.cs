namespace PalworldServerManager
{
    partial class Form_ServerSettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ServerSettings));
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button3 = new System.Windows.Forms.Button(); // <-- wieder hinzugefügt
            button_manualSave = new System.Windows.Forms.Button();
            button_openManualAutoSaveDirectory = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label71 = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            panel4 = new System.Windows.Forms.Panel();
            button_customServerLaunchArgument = new System.Windows.Forms.Button();
            textBox_customServerLaunchArgument = new System.Windows.Forms.TextBox();
            label68 = new System.Windows.Forms.Label();
            textBox_autoRestartEvery = new System.Windows.Forms.TextBox();
            label70 = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            textBox_onServerCmdCrashRestartInterval = new System.Windows.Forms.TextBox();
            label73 = new System.Windows.Forms.Label();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            textBox_restartServerRCONAlertInterval = new System.Windows.Forms.TextBox();
            textBox_restartServerRCONAlertMessage = new System.Windows.Forms.TextBox();
            label75 = new System.Windows.Forms.Label();
            panel_backup = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            panel5 = new System.Windows.Forms.Panel();
            textBox_backupTo = new System.Windows.Forms.TextBox();
            button_backupTo = new System.Windows.Forms.Button();
            label66 = new System.Windows.Forms.Label();
            label65 = new System.Windows.Forms.Label();
            textBox_backupInterval = new System.Windows.Forms.TextBox();
            label67 = new System.Windows.Forms.Label();
            textBox_maxBackup = new System.Windows.Forms.TextBox();
            label72 = new System.Windows.Forms.Label();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            textBox_backupRCONAlertInterval = new System.Windows.Forms.TextBox();
            textBox_backupRCONAlertMessage = new System.Windows.Forms.TextBox();
            label74 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            label63 = new System.Windows.Forms.Label();
            richTextBox_alert = new System.Windows.Forms.RichTextBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer_onCMDCrashRestart = new System.Windows.Forms.Timer(components);
            timer_backupRCONAlertTimer = new System.Windows.Forms.Timer(components);
            timer_restartServerRCONAlertTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel_backup.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            // Reihenfolge/Spalten wie zuvor: (1) button3, (2) manualSave, (3) open dir
            tableLayoutPanel1.Controls.Add(button3, 1, 0);                        // <-- wieder hinzugefügt
            tableLayoutPanel1.Controls.Add(button_manualSave, 2, 0);
            tableLayoutPanel1.Controls.Add(button_openManualAutoSaveDirectory, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            toolTip1.SetToolTip(button3, resources.GetString("button3.ToolTip"));
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;                                       // <-- Handler existiert bereits im Code-Behind
            // 
            // button_manualSave
            // 
            resources.ApplyResources(button_manualSave, "button_manualSave");
            button_manualSave.Name = "button_manualSave";
            button_manualSave.UseVisualStyleBackColor = true;
            button_manualSave.Click += button_manualSave_Click;
            // 
            // button_openManualAutoSaveDirectory
            // 
            resources.ApplyResources(button_openManualAutoSaveDirectory, "button_openManualAutoSaveDirectory");
            button_openManualAutoSaveDirectory.Name = "button_openManualAutoSaveDirectory";
            button_openManualAutoSaveDirectory.UseVisualStyleBackColor = true;
            button_openManualAutoSaveDirectory.Click += button_openManualAutoSaveDirectory_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(panel_backup);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(richTextBox_alert);
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.Controls.Add(label71);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // label71
            // 
            resources.ApplyResources(label71, "label71");
            label71.Name = "label71";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(panel4, 1, 3);
            tableLayoutPanel2.Controls.Add(label68, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox_autoRestartEvery, 1, 0);
            tableLayoutPanel2.Controls.Add(label70, 0, 3);
            tableLayoutPanel2.Controls.Add(label69, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox_onServerCmdCrashRestartInterval, 1, 2);
            tableLayoutPanel2.Controls.Add(label73, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // panel4
            // 
            panel4.Controls.Add(button_customServerLaunchArgument);
            panel4.Controls.Add(textBox_customServerLaunchArgument);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // button_customServerLaunchArgument
            // 
            resources.ApplyResources(button_customServerLaunchArgument, "button_customServerLaunchArgument");
            button_customServerLaunchArgument.Name = "button_customServerLaunchArgument";
            button_customServerLaunchArgument.UseVisualStyleBackColor = true;
            button_customServerLaunchArgument.Click += button_customServerLaunchArgument_Click;
            // 
            // textBox_customServerLaunchArgument
            // 
            resources.ApplyResources(textBox_customServerLaunchArgument, "textBox_customServerLaunchArgument");
            textBox_customServerLaunchArgument.Name = "textBox_customServerLaunchArgument";
            // 
            // label68
            // 
            resources.ApplyResources(label68, "label68");
            label68.Name = "label68";
            toolTip1.SetToolTip(label68, resources.GetString("label68.ToolTip"));
            // 
            // textBox_autoRestartEvery
            // 
            resources.ApplyResources(textBox_autoRestartEvery, "textBox_autoRestartEvery");
            textBox_autoRestartEvery.Name = "textBox_autoRestartEvery";
            // 
            // label70
            // 
            resources.ApplyResources(label70, "label70");
            label70.Name = "label70";
            toolTip1.SetToolTip(label70, resources.GetString("label70.ToolTip"));
            // 
            // label69
            // 
            resources.ApplyResources(label69, "label69");
            label69.Name = "label69";
            toolTip1.SetToolTip(label69, resources.GetString("label69.ToolTip"));
            // 
            // textBox_onServerCmdCrashRestartInterval
            // 
            resources.ApplyResources(textBox_onServerCmdCrashRestartInterval, "textBox_onServerCmdCrashRestartInterval");
            textBox_onServerCmdCrashRestartInterval.Name = "textBox_onServerCmdCrashRestartInterval";
            // 
            // label73
            // 
            resources.ApplyResources(label73, "label73");
            label73.Name = "label73";
            toolTip1.SetToolTip(label73, resources.GetString("label73.ToolTip"));
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.Controls.Add(textBox_restartServerRCONAlertInterval, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox_restartServerRCONAlertMessage, 2, 0);
            tableLayoutPanel6.Controls.Add(label75, 1, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // textBox_restartServerRCONAlertInterval
            // 
            resources.ApplyResources(textBox_restartServerRCONAlertInterval, "textBox_restartServerRCONAlertInterval");
            textBox_restartServerRCONAlertInterval.Name = "textBox_restartServerRCONAlertInterval";
            // 
            // textBox_restartServerRCONAlertMessage
            // 
            resources.ApplyResources(textBox_restartServerRCONAlertMessage, "textBox_restartServerRCONAlertMessage");
            textBox_restartServerRCONAlertMessage.Name = "textBox_restartServerRCONAlertMessage";
            // 
            // label75
            // 
            resources.ApplyResources(label75, "label75");
            label75.Name = "label75";
            // 
            // panel_backup
            // 
            resources.ApplyResources(panel_backup, "panel_backup");
            panel_backup.Controls.Add(tableLayoutPanel3);
            panel_backup.Name = "panel_backup";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(panel5, 1, 3);
            tableLayoutPanel3.Controls.Add(label66, 0, 3);
            tableLayoutPanel3.Controls.Add(label65, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox_backupInterval, 1, 0);
            tableLayoutPanel3.Controls.Add(label67, 0, 2);
            tableLayoutPanel3.Controls.Add(textBox_maxBackup, 1, 2);
            tableLayoutPanel3.Controls.Add(label72, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_backupTo);
            panel5.Controls.Add(button_backupTo);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // textBox_backupTo
            // 
            resources.ApplyResources(textBox_backupTo, "textBox_backupTo");
            textBox_backupTo.Name = "textBox_backupTo";
            // 
            // button_backupTo
            // 
            resources.ApplyResources(button_backupTo, "button_backupTo");
            button_backupTo.Name = "button_backupTo";
            button_backupTo.UseVisualStyleBackColor = true;
            button_backupTo.Click += button_backupTo_Click;
            // 
            // label66
            // 
            resources.ApplyResources(label66, "label66");
            label66.Name = "label66";
            toolTip1.SetToolTip(label66, resources.GetString("label66.ToolTip"));
            // 
            // label65
            // 
            resources.ApplyResources(label65, "label65");
            label65.Name = "label65";
            toolTip1.SetToolTip(label65, resources.GetString("label65.ToolTip"));
            // 
            // textBox_backupInterval
            // 
            resources.ApplyResources(textBox_backupInterval, "textBox_backupInterval");
            textBox_backupInterval.Name = "textBox_backupInterval";
            // 
            // label67
            // 
            resources.ApplyResources(label67, "label67");
            label67.Name = "label67";
            toolTip1.SetToolTip(label67, resources.GetString("label67.ToolTip"));
            // 
            // textBox_maxBackup
            // 
            resources.ApplyResources(textBox_maxBackup, "textBox_maxBackup");
            textBox_maxBackup.Name = "textBox_maxBackup";
            // 
            // label72
            // 
            resources.ApplyResources(label72, "label72");
            label72.Name = "label72";
            toolTip1.SetToolTip(label72, resources.GetString("label72.ToolTip"));
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.Controls.Add(textBox_backupRCONAlertInterval, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox_backupRCONAlertMessage, 2, 0);
            tableLayoutPanel5.Controls.Add(label74, 1, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // textBox_backupRCONAlertInterval
            // 
            resources.ApplyResources(textBox_backupRCONAlertInterval, "textBox_backupRCONAlertInterval");
            textBox_backupRCONAlertInterval.Name = "textBox_backupRCONAlertInterval";
            // 
            // textBox_backupRCONAlertMessage
            // 
            resources.ApplyResources(textBox_backupRCONAlertMessage, "textBox_backupRCONAlertMessage");
            textBox_backupRCONAlertMessage.Name = "textBox_backupRCONAlertMessage";
            // 
            // label74
            // 
            resources.ApplyResources(label74, "label74");
            label74.Name = "label74";
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox2);
            panel2.Controls.Add(label63);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(richTextBox2, "richTextBox2");
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            // 
            // label63
            // 
            resources.ApplyResources(label63, "label63");
            label63.Name = "label63";
            // 
            // richTextBox_alert
            // 
            resources.ApplyResources(richTextBox_alert, "richTextBox_alert");
            richTextBox_alert.Name = "richTextBox_alert";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer_onCMDCrashRestart
            // 
            timer_onCMDCrashRestart.Tick += timer_onCMDCrashRestart_Tick;
            // 
            // timer_backupRCONAlertTimer
            // 
            timer_backupRCONAlertTimer.Tick += timer_backupRCONAlertTimer_Tick;
            // 
            // timer_restartServerRCONAlertTimer
            // 
            timer_restartServerRCONAlertTimer.Tick += timer_restartServerRCONAlertTimer_Tick;
            // 
            // Form_ServerSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Name = "Form_ServerSettings";
            Load += Form_ServerSettings_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel_backup.ResumeLayout(false);
            panel_backup.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3; // <-- wieder hinzugefügt
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox textBox_backupInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox_backupTo;
        private System.Windows.Forms.Button button_backupTo;
        private System.Windows.Forms.Button button_manualSave;
        private System.Windows.Forms.TextBox textBox_maxBackup;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Button button_openManualAutoSaveDirectory;
        private System.Windows.Forms.Panel panel_backup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox textBox_autoRestartEvery;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox richTextBox_alert;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox textBox_onServerCmdCrashRestartInterval;
        private System.Windows.Forms.Timer timer_onCMDCrashRestart;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox textBox_customServerLaunchArgument;
        private System.Windows.Forms.Button button_customServerLaunchArgument;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBox_backupRCONAlertInterval;
        private System.Windows.Forms.TextBox textBox_backupRCONAlertMessage;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBox_restartServerRCONAlertInterval;
        private System.Windows.Forms.TextBox textBox_restartServerRCONAlertMessage;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Timer timer_backupRCONAlertTimer;
        private System.Windows.Forms.Timer timer_restartServerRCONAlertTimer;
    }
}
