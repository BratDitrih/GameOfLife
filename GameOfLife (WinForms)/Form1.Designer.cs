namespace GameOfLife__WinForms_
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DensityTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ResolutionTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.GameFieldImage = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameFieldImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.DensityTrackBar);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ResolutionTrackBar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.StartButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.GameFieldImage);
            this.splitContainer1.Size = new System.Drawing.Size(2034, 996);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // DensityTrackBar
            // 
            this.DensityTrackBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.DensityTrackBar.Location = new System.Drawing.Point(690, 0);
            this.DensityTrackBar.Maximum = 25;
            this.DensityTrackBar.Minimum = 1;
            this.DensityTrackBar.Name = "DensityTrackBar";
            this.DensityTrackBar.Size = new System.Drawing.Size(156, 49);
            this.DensityTrackBar.TabIndex = 5;
            this.DensityTrackBar.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(570, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Density";
            // 
            // ResolutionTrackBar
            // 
            this.ResolutionTrackBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResolutionTrackBar.Location = new System.Drawing.Point(414, 0);
            this.ResolutionTrackBar.Maximum = 30;
            this.ResolutionTrackBar.Minimum = 1;
            this.ResolutionTrackBar.Name = "ResolutionTrackBar";
            this.ResolutionTrackBar.Size = new System.Drawing.Size(156, 49);
            this.ResolutionTrackBar.TabIndex = 3;
            this.ResolutionTrackBar.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resolution";
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StopButton.Location = new System.Drawing.Point(125, 0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(125, 49);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartButton.Location = new System.Drawing.Point(0, 0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 49);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GameFieldImage
            // 
            this.GameFieldImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameFieldImage.Location = new System.Drawing.Point(0, 0);
            this.GameFieldImage.Name = "GameFieldImage";
            this.GameFieldImage.Size = new System.Drawing.Size(2034, 941);
            this.GameFieldImage.TabIndex = 0;
            this.GameFieldImage.TabStop = false;
            this.GameFieldImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameFieldImage_MouseMove);
            // 
            // Timer
            // 
            this.Timer.Interval = 250;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2034, 996);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DensityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameFieldImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox GameFieldImage;
        private Button StartButton;
        private Button StopButton;
        private Label label1;
        private TrackBar ResolutionTrackBar;
        private TrackBar DensityTrackBar;
        private Label label2;
        private System.Windows.Forms.Timer Timer;
    }
}