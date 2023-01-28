
namespace Transparentify
{
    partial class Transparentify
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputDestinationFolder = new System.Windows.Forms.TextBox();
            this.commandBrowseDestination = new System.Windows.Forms.Button();
            this.inputPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputSuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commandExecute = new System.Windows.Forms.Button();
            this.commandBrowseSource = new System.Windows.Forms.Button();
            this.inputSourceFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination folder";
            // 
            // inputDestinationFolder
            // 
            this.inputDestinationFolder.Location = new System.Drawing.Point(23, 172);
            this.inputDestinationFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputDestinationFolder.Name = "inputDestinationFolder";
            this.inputDestinationFolder.Size = new System.Drawing.Size(286, 38);
            this.inputDestinationFolder.TabIndex = 2;
            // 
            // commandBrowseDestination
            // 
            this.commandBrowseDestination.Location = new System.Drawing.Point(313, 172);
            this.commandBrowseDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandBrowseDestination.Name = "commandBrowseDestination";
            this.commandBrowseDestination.Size = new System.Drawing.Size(71, 38);
            this.commandBrowseDestination.TabIndex = 3;
            this.commandBrowseDestination.Text = "...";
            this.commandBrowseDestination.UseVisualStyleBackColor = true;
            this.commandBrowseDestination.Click += new System.EventHandler(this.commandBrowseFolder_Click);
            // 
            // inputPrefix
            // 
            this.inputPrefix.Location = new System.Drawing.Point(23, 282);
            this.inputPrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPrefix.Name = "inputPrefix";
            this.inputPrefix.Size = new System.Drawing.Size(361, 38);
            this.inputPrefix.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prefix";
            // 
            // inputSuffix
            // 
            this.inputSuffix.Location = new System.Drawing.Point(23, 382);
            this.inputSuffix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputSuffix.Name = "inputSuffix";
            this.inputSuffix.Size = new System.Drawing.Size(361, 38);
            this.inputSuffix.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suffix";
            // 
            // commandExecute
            // 
            this.commandExecute.Location = new System.Drawing.Point(23, 466);
            this.commandExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandExecute.Name = "commandExecute";
            this.commandExecute.Size = new System.Drawing.Size(201, 56);
            this.commandExecute.TabIndex = 8;
            this.commandExecute.Text = "Execute";
            this.commandExecute.UseVisualStyleBackColor = true;
            this.commandExecute.Click += new System.EventHandler(this.commandExecute_Click);
            // 
            // commandBrowseSource
            // 
            this.commandBrowseSource.Location = new System.Drawing.Point(315, 64);
            this.commandBrowseSource.Margin = new System.Windows.Forms.Padding(2);
            this.commandBrowseSource.Name = "commandBrowseSource";
            this.commandBrowseSource.Size = new System.Drawing.Size(71, 38);
            this.commandBrowseSource.TabIndex = 11;
            this.commandBrowseSource.Text = "...";
            this.commandBrowseSource.UseVisualStyleBackColor = true;
            this.commandBrowseSource.Click += new System.EventHandler(this.commandBrowseSource_Click);
            // 
            // inputSourceFolder
            // 
            this.inputSourceFolder.Location = new System.Drawing.Point(25, 64);
            this.inputSourceFolder.Margin = new System.Windows.Forms.Padding(2);
            this.inputSourceFolder.Name = "inputSourceFolder";
            this.inputSourceFolder.Size = new System.Drawing.Size(286, 38);
            this.inputSourceFolder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 62);
            this.label4.TabIndex = 9;
            this.label4.Text = "Image folder";
            // 
            // Transparentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 548);
            this.Controls.Add(this.commandBrowseSource);
            this.Controls.Add(this.inputSourceFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commandExecute);
            this.Controls.Add(this.inputSuffix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commandBrowseDestination);
            this.Controls.Add(this.inputDestinationFolder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transparentify";
            this.Text = "Transparentify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDestinationFolder;
        private System.Windows.Forms.Button commandBrowseDestination;
        private System.Windows.Forms.TextBox inputPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button commandExecute;
        private System.Windows.Forms.Button commandBrowseSource;
        private System.Windows.Forms.TextBox inputSourceFolder;
        private System.Windows.Forms.Label label4;
    }
}

