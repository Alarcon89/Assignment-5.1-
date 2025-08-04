namespace SpaceShip_Crew
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelSpaceShipSimulation = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxInsideCrew = new System.Windows.Forms.TextBox();
            this.groupBoxCrewWhoAreReady = new System.Windows.Forms.GroupBox();
            this.richTextBoxTransferCrew = new System.Windows.Forms.RichTextBox();
            this.buttonTransferTroops = new System.Windows.Forms.Button();
            this.labelListOfTroops = new System.Windows.Forms.Label();
            this.groupBoxTroopsFighting = new System.Windows.Forms.GroupBox();
            this.richTextBoxTransferFightCrew = new System.Windows.Forms.RichTextBox();
            this.labelMoveOverTheFightingTroops = new System.Windows.Forms.Label();
            this.groupBoxCrewWhoAreReady.SuspendLayout();
            this.groupBoxTroopsFighting.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSpaceShipSimulation
            // 
            this.labelSpaceShipSimulation.AutoSize = true;
            this.labelSpaceShipSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpaceShipSimulation.Location = new System.Drawing.Point(433, 9);
            this.labelSpaceShipSimulation.Name = "labelSpaceShipSimulation";
            this.labelSpaceShipSimulation.Size = new System.Drawing.Size(235, 20);
            this.labelSpaceShipSimulation.TabIndex = 0;
            this.labelSpaceShipSimulation.Text = "Space Ship Crew Simulation";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(674, 32);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(352, 32);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxInsideCrew
            // 
            this.textBoxInsideCrew.BackColor = System.Drawing.Color.SlateGray;
            this.textBoxInsideCrew.Location = new System.Drawing.Point(28, 102);
            this.textBoxInsideCrew.Multiline = true;
            this.textBoxInsideCrew.Name = "textBoxInsideCrew";
            this.textBoxInsideCrew.Size = new System.Drawing.Size(199, 395);
            this.textBoxInsideCrew.TabIndex = 3;
            this.textBoxInsideCrew.TextChanged += new System.EventHandler(this.textBoxInsideCrew_TextChanged);
            // 
            // groupBoxCrewWhoAreReady
            // 
            this.groupBoxCrewWhoAreReady.Controls.Add(this.richTextBoxTransferCrew);
            this.groupBoxCrewWhoAreReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCrewWhoAreReady.Location = new System.Drawing.Point(921, 112);
            this.groupBoxCrewWhoAreReady.Name = "groupBoxCrewWhoAreReady";
            this.groupBoxCrewWhoAreReady.Size = new System.Drawing.Size(252, 395);
            this.groupBoxCrewWhoAreReady.TabIndex = 4;
            this.groupBoxCrewWhoAreReady.TabStop = false;
            this.groupBoxCrewWhoAreReady.Text = "Crew That Are Ready To Fight!";
            // 
            // richTextBoxTransferCrew
            // 
            this.richTextBoxTransferCrew.Location = new System.Drawing.Point(19, 39);
            this.richTextBoxTransferCrew.Name = "richTextBoxTransferCrew";
            this.richTextBoxTransferCrew.Size = new System.Drawing.Size(211, 331);
            this.richTextBoxTransferCrew.TabIndex = 0;
            this.richTextBoxTransferCrew.Text = "";
            // 
            // buttonTransferTroops
            // 
            this.buttonTransferTroops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferTroops.Location = new System.Drawing.Point(236, 192);
            this.buttonTransferTroops.Name = "buttonTransferTroops";
            this.buttonTransferTroops.Size = new System.Drawing.Size(149, 26);
            this.buttonTransferTroops.TabIndex = 5;
            this.buttonTransferTroops.Text = "Transfer Troops";
            this.buttonTransferTroops.UseVisualStyleBackColor = true;
            this.buttonTransferTroops.Click += new System.EventHandler(this.buttonTransferTroops_Click);
            // 
            // labelListOfTroops
            // 
            this.labelListOfTroops.AutoSize = true;
            this.labelListOfTroops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListOfTroops.Location = new System.Drawing.Point(72, 82);
            this.labelListOfTroops.Name = "labelListOfTroops";
            this.labelListOfTroops.Size = new System.Drawing.Size(112, 17);
            this.labelListOfTroops.TabIndex = 6;
            this.labelListOfTroops.Text = "List Of Troops";
            // 
            // groupBoxTroopsFighting
            // 
            this.groupBoxTroopsFighting.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxTroopsFighting.Controls.Add(this.richTextBoxTransferFightCrew);
            this.groupBoxTroopsFighting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTroopsFighting.Location = new System.Drawing.Point(437, 112);
            this.groupBoxTroopsFighting.Name = "groupBoxTroopsFighting";
            this.groupBoxTroopsFighting.Size = new System.Drawing.Size(231, 385);
            this.groupBoxTroopsFighting.TabIndex = 7;
            this.groupBoxTroopsFighting.TabStop = false;
            this.groupBoxTroopsFighting.Text = "Boots On The Ground";
            // 
            // richTextBoxTransferFightCrew
            // 
            this.richTextBoxTransferFightCrew.Location = new System.Drawing.Point(7, 39);
            this.richTextBoxTransferFightCrew.Name = "richTextBoxTransferFightCrew";
            this.richTextBoxTransferFightCrew.Size = new System.Drawing.Size(218, 331);
            this.richTextBoxTransferFightCrew.TabIndex = 0;
            this.richTextBoxTransferFightCrew.Text = "";
            // 
            // labelMoveOverTheFightingTroops
            // 
            this.labelMoveOverTheFightingTroops.AutoSize = true;
            this.labelMoveOverTheFightingTroops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoveOverTheFightingTroops.Location = new System.Drawing.Point(233, 154);
            this.labelMoveOverTheFightingTroops.Name = "labelMoveOverTheFightingTroops";
            this.labelMoveOverTheFightingTroops.Size = new System.Drawing.Size(182, 17);
            this.labelMoveOverTheFightingTroops.TabIndex = 1;
            this.labelMoveOverTheFightingTroops.Text = "See Who Is In The Fight";
            this.labelMoveOverTheFightingTroops.Click += new System.EventHandler(this.labelMoveOverTheFightingTroops_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 630);
            this.Controls.Add(this.labelMoveOverTheFightingTroops);
            this.Controls.Add(this.groupBoxTroopsFighting);
            this.Controls.Add(this.labelListOfTroops);
            this.Controls.Add(this.buttonTransferTroops);
            this.Controls.Add(this.groupBoxCrewWhoAreReady);
            this.Controls.Add(this.textBoxInsideCrew);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSpaceShipSimulation);
            this.Name = "Main";
            this.Text = "Form Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxCrewWhoAreReady.ResumeLayout(false);
            this.groupBoxTroopsFighting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpaceShipSimulation;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxInsideCrew;
        private System.Windows.Forms.GroupBox groupBoxCrewWhoAreReady;
        private System.Windows.Forms.RichTextBox richTextBoxTransferCrew;
        private System.Windows.Forms.Button buttonTransferTroops;
        private System.Windows.Forms.Label labelListOfTroops;
        private System.Windows.Forms.GroupBox groupBoxTroopsFighting;
        private System.Windows.Forms.RichTextBox richTextBoxTransferFightCrew;
        private System.Windows.Forms.Label labelMoveOverTheFightingTroops;
    }
}

