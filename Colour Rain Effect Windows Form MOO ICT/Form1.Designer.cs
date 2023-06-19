namespace Colour_Rain_Effect_Windows_Form_MOO_ICT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ParticleEffectsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ParticleEffectsTimer
            // 
            this.ParticleEffectsTimer.Enabled = true;
            this.ParticleEffectsTimer.Interval = 20;
            this.ParticleEffectsTimer.Tick += new System.EventHandler(this.ParticleTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colour_Rain_Effect_Windows_Form_MOO_ICT.Properties.Resources.mugen_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Colour Rain Effect in Windows Form MOO ICT";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ParticleEffectsTimer;
    }
}