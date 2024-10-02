namespace Am_I_Positive
{
    partial class Form1
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.posnegOutput = new System.Windows.Forms.Label();
            this.div7Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(33, 25);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(146, 25);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Number input:";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(38, 69);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(141, 20);
            this.numInput.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(71, 95);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // posnegOutput
            // 
            this.posnegOutput.AutoSize = true;
            this.posnegOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posnegOutput.Location = new System.Drawing.Point(33, 192);
            this.posnegOutput.Name = "posnegOutput";
            this.posnegOutput.Size = new System.Drawing.Size(213, 25);
            this.posnegOutput.TabIndex = 3;
            this.posnegOutput.Text = "Positive or negative?";
            // 
            // div7Output
            // 
            this.div7Output.AutoSize = true;
            this.div7Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div7Output.Location = new System.Drawing.Point(33, 238);
            this.div7Output.Name = "div7Output";
            this.div7Output.Size = new System.Drawing.Size(152, 25);
            this.div7Output.TabIndex = 4;
            this.div7Output.Text = "Divisible by 7?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.div7Output);
            this.Controls.Add(this.posnegOutput);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Am I Positive?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label posnegOutput;
        private System.Windows.Forms.Label div7Output;
    }
}

