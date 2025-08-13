namespace PalworldServerManager
{
    partial class Form_REST
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
            this.textBox_ipREST = new System.Windows.Forms.TextBox();
            this.textBox_portREST = new System.Windows.Forms.TextBox();
            this.textBox_passwordREST = new System.Windows.Forms.TextBox();
            this.textBox_command = new System.Windows.Forms.TextBox();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.button_sendCommand = new System.Windows.Forms.Button();
            this.button_saveRestSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ipREST
            // 
            this.textBox_ipREST.Location = new System.Drawing.Point(12, 12);
            this.textBox_ipREST.Name = "textBox_ipREST";
            this.textBox_ipREST.Size = new System.Drawing.Size(150, 20);
            this.textBox_ipREST.TabIndex = 0;
            // 
            // textBox_portREST
            // 
            this.textBox_portREST.Location = new System.Drawing.Point(168, 12);
            this.textBox_portREST.Name = "textBox_portREST";
            this.textBox_portREST.Size = new System.Drawing.Size(60, 20);
            this.textBox_portREST.TabIndex = 1;
            // 
            // textBox_passwordREST
            // 
            this.textBox_passwordREST.Location = new System.Drawing.Point(234, 12);
            this.textBox_passwordREST.Name = "textBox_passwordREST";
            this.textBox_passwordREST.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwordREST.TabIndex = 2;
            this.textBox_passwordREST.UseSystemPasswordChar = true;
            // 
            // textBox_command
            // 
            this.textBox_command.Location = new System.Drawing.Point(12, 50);
            this.textBox_command.Name = "textBox_command";
            this.textBox_command.Size = new System.Drawing.Size(400, 20);
            this.textBox_command.TabIndex = 3;
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(12, 105);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ReadOnly = true;
            this.richTextBox_output.Size = new System.Drawing.Size(460, 250);
            this.richTextBox_output.TabIndex = 5;
            this.richTextBox_output.Text = "";
            this.richTextBox_output.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.richTextBox_output.ForeColor = System.Drawing.Color.LightGreen;
            this.richTextBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // button_sendCommand
            // 
            this.button_sendCommand.Location = new System.Drawing.Point(418, 48);
            this.button_sendCommand.Name = "button_sendCommand";
            this.button_sendCommand.Size = new System.Drawing.Size(54, 23);
            this.button_sendCommand.TabIndex = 4;
            this.button_sendCommand.Text = "Send";
            this.button_sendCommand.UseVisualStyleBackColor = true;
            this.button_sendCommand.Click += new System.EventHandler(this.button_sendCommand_Click);
            // 
            // button_saveRestSettings
            // 
            this.button_saveRestSettings.Location = new System.Drawing.Point(340, 10);
            this.button_saveRestSettings.Name = "button_saveRestSettings";
            this.button_saveRestSettings.Size = new System.Drawing.Size(132, 23);
            this.button_saveRestSettings.TabIndex = 6;
            this.button_saveRestSettings.Text = "Save REST Settings";
            this.button_saveRestSettings.UseVisualStyleBackColor = true;
            // this.button_saveRestSettings.Click += new System.EventHandler(this.button_saveRestSettings_Click);
            // 
            // Form_REST
            // 
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.button_saveRestSettings);
            this.Controls.Add(this.button_sendCommand);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.textBox_command);
            this.Controls.Add(this.textBox_passwordREST);
            this.Controls.Add(this.textBox_portREST);
            this.Controls.Add(this.textBox_ipREST);
            this.Name = "Form_REST";
            this.Text = "REST API Interface";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ipREST;
        private System.Windows.Forms.TextBox textBox_portREST;
        private System.Windows.Forms.TextBox textBox_passwordREST;
        private System.Windows.Forms.TextBox textBox_command;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Button button_sendCommand;
        private System.Windows.Forms.Button button_saveRestSettings;
    }
}
