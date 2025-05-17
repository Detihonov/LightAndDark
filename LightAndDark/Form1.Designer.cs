namespace LightAndDark
{
    partial class Form
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
            this.ltheme = new System.Windows.Forms.Label();
            this.SwithDarkWhite = new Siticone.UI.WinForms.SiticoneWinToggleSwith();
            this.SuspendLayout();
            // 
            // ltheme
            // 
            this.ltheme.AutoSize = true;
            this.ltheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltheme.Location = new System.Drawing.Point(676, 9);
            this.ltheme.Name = "ltheme";
            this.ltheme.Size = new System.Drawing.Size(66, 18);
            this.ltheme.TabIndex = 0;
            this.ltheme.Text = "THEME";
            // 
            // SwithDarkWhite
            // 
            this.SwithDarkWhite.Location = new System.Drawing.Point(744, 5);
            this.SwithDarkWhite.Name = "SwithDarkWhite";
            this.SwithDarkWhite.Size = new System.Drawing.Size(44, 25);
            this.SwithDarkWhite.TabIndex = 1;
            this.SwithDarkWhite.Text = "SwithDarkWhite";
            this.SwithDarkWhite.CheckedChanged += new System.EventHandler(this.SwithDarkWhite_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SwithDarkWhite);
            this.Controls.Add(this.ltheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "LightAndDark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltheme;
        private Siticone.UI.WinForms.SiticoneWinToggleSwith SwithDarkWhite;
    }
}

