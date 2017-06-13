namespace MultiScreenTEST
{
    partial class HomeForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRunClock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRunClock
            // 
            this.buttonRunClock.Location = new System.Drawing.Point(12, 12);
            this.buttonRunClock.Name = "buttonRunClock";
            this.buttonRunClock.Size = new System.Drawing.Size(259, 87);
            this.buttonRunClock.TabIndex = 0;
            this.buttonRunClock.Text = "Run Clock";
            this.buttonRunClock.UseVisualStyleBackColor = true;
            this.buttonRunClock.Click += new System.EventHandler(this.buttonRunClock_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.buttonRunClock);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "HomeForm";
            this.Text = "StartWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunClock;
    }
}

