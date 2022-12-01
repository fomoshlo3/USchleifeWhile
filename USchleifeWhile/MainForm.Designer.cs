namespace USchleifeWhile
{
    partial class MainForm
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
            this.LblOutput = new System.Windows.Forms.Label();
            this.TBxInput = new System.Windows.Forms.TextBox();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(12, 9);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(37, 15);
            this.LblOutput.TabIndex = 0;
            this.LblOutput.Text = "(Leer)";
            // 
            // TBxInput
            // 
            this.TBxInput.Location = new System.Drawing.Point(233, 12);
            this.TBxInput.Name = "TBxInput";
            this.TBxInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TBxInput.Size = new System.Drawing.Size(141, 23);
            this.TBxInput.TabIndex = 1;
            this.TBxInput.Text = "Zahl";
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(299, 41);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 2;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 316);
            this.Controls.Add(this.CmdAnzeigen);
            this.Controls.Add(this.TBxInput);
            this.Controls.Add(this.LblOutput);
            this.Name = "MainForm";
            this.Text = "Uebung Schleifen While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblOutput;
        private TextBox TBxInput;
        private Button CmdAnzeigen;
    }
}