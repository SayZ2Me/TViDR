﻿namespace TViDR_WinForms.UserControls
{
    partial class Button_Minimize
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Button_Minimize
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::TViDR_WinForms.Properties.Resources.Button_Minimize;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Button_Minimize";
            this.Size = new System.Drawing.Size(19, 19);
            this.Click += new System.EventHandler(this.Button_Minimize_Click);
            this.MouseEnter += new System.EventHandler(this.Button_Minimize_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Button_Minimize_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
