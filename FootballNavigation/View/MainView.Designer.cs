
namespace FootballNavigation.View
{
    partial class MainView
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
            this.btnField = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnField
            // 
            this.btnField.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnField.Location = new System.Drawing.Point(257, 265);
            this.btnField.Name = "btnField";
            this.btnField.Size = new System.Drawing.Size(277, 70);
            this.btnField.TabIndex = 0;
            this.btnField.Text = "Go To Field";
            this.btnField.UseVisualStyleBackColor = true;
            this.btnField.Click += new System.EventHandler(this.btnField_Click);
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManager.Location = new System.Drawing.Point(257, 357);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(277, 67);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Go To Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FootballNavigation.Properties.Resources._1188610;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnField);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnField;
        private System.Windows.Forms.Button btnManager;
    }
}