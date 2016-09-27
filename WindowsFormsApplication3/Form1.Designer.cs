namespace WindowsFormsApplication3
{
    partial class frmhowareyou
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grboptians = new System.Windows.Forms.GroupBox();
            this.rdbHitting = new System.Windows.Forms.RadioButton();
            this.rdbMad = new System.Windows.Forms.RadioButton();
            this.rdbSad = new System.Windows.Forms.RadioButton();
            this.rdbGood = new System.Windows.Forms.RadioButton();
            this.rdbGreat = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grboptians.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(156, 24);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(569, 98);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "How are you?";
            // 
            // grboptians
            // 
            this.grboptians.Controls.Add(this.rdbHitting);
            this.grboptians.Controls.Add(this.rdbMad);
            this.grboptians.Controls.Add(this.rdbSad);
            this.grboptians.Controls.Add(this.rdbGood);
            this.grboptians.Controls.Add(this.rdbGreat);
            this.grboptians.Location = new System.Drawing.Point(173, 195);
            this.grboptians.Name = "grboptians";
            this.grboptians.Size = new System.Drawing.Size(474, 125);
            this.grboptians.TabIndex = 1;
            this.grboptians.TabStop = false;
            // 
            // rdbHitting
            // 
            this.rdbHitting.AutoSize = true;
            this.rdbHitting.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHitting.Location = new System.Drawing.Point(20, 87);
            this.rdbHitting.Name = "rdbHitting";
            this.rdbHitting.Size = new System.Drawing.Size(289, 28);
            this.rdbHitting.TabIndex = 3;
            this.rdbHitting.TabStop = true;
            this.rdbHitting.Text = "I Feel Like Hitting Something";
            this.rdbHitting.UseVisualStyleBackColor = true;
            this.rdbHitting.CheckedChanged += new System.EventHandler(this.rdbHitting_CheckedChanged);
            // 
            // rdbMad
            // 
            this.rdbMad.AutoSize = true;
            this.rdbMad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMad.Location = new System.Drawing.Point(138, 65);
            this.rdbMad.Name = "rdbMad";
            this.rdbMad.Size = new System.Drawing.Size(66, 28);
            this.rdbMad.TabIndex = 3;
            this.rdbMad.TabStop = true;
            this.rdbMad.Text = "Mad";
            this.rdbMad.UseVisualStyleBackColor = true;
            this.rdbMad.CheckedChanged += new System.EventHandler(this.rdbMad_CheckedChanged);
            // 
            // rdbSad
            // 
            this.rdbSad.AutoSize = true;
            this.rdbSad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSad.Location = new System.Drawing.Point(138, 30);
            this.rdbSad.Name = "rdbSad";
            this.rdbSad.Size = new System.Drawing.Size(90, 28);
            this.rdbSad.TabIndex = 2;
            this.rdbSad.TabStop = true;
            this.rdbSad.Text = "Im Sad";
            this.rdbSad.UseVisualStyleBackColor = true;
            this.rdbSad.CheckedChanged += new System.EventHandler(this.rdbSad_CheckedChanged);
            // 
            // rdbGood
            // 
            this.rdbGood.AutoSize = true;
            this.rdbGood.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGood.Location = new System.Drawing.Point(20, 53);
            this.rdbGood.Name = "rdbGood";
            this.rdbGood.Size = new System.Drawing.Size(70, 28);
            this.rdbGood.TabIndex = 1;
            this.rdbGood.TabStop = true;
            this.rdbGood.Text = "Good";
            this.rdbGood.UseVisualStyleBackColor = true;
            this.rdbGood.CheckedChanged += new System.EventHandler(this.rdbGood_CheckedChanged);
            // 
            // rdbGreat
            // 
            this.rdbGreat.AutoSize = true;
            this.rdbGreat.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGreat.Location = new System.Drawing.Point(20, 20);
            this.rdbGreat.Name = "rdbGreat";
            this.rdbGreat.Size = new System.Drawing.Size(74, 28);
            this.rdbGreat.TabIndex = 0;
            this.rdbGreat.TabStop = true;
            this.rdbGreat.Text = "Great";
            this.rdbGreat.UseVisualStyleBackColor = true;
            this.rdbGreat.CheckedChanged += new System.EventHandler(this.rdbGreat_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(311, 365);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 2;
            // 
            // frmhowareyou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 418);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grboptians);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmhowareyou";
            this.Text = "How Are You?";
            this.grboptians.ResumeLayout(false);
            this.grboptians.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grboptians;
        private System.Windows.Forms.RadioButton rdbMad;
        private System.Windows.Forms.RadioButton rdbSad;
        private System.Windows.Forms.RadioButton rdbGood;
        private System.Windows.Forms.RadioButton rdbGreat;
        private System.Windows.Forms.RadioButton rdbHitting;
        private System.Windows.Forms.Label lblResult;
    }
}

