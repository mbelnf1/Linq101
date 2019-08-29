namespace FormIU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allpeopleDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearsExperiencePicker = new System.Windows.Forms.DomainUpDown();
            this.updatePersonButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filteredpeopleList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linq 101 Demo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "All People";
            // 
            // allpeopleDropdown
            // 
            this.allpeopleDropdown.FormattingEnabled = true;
            this.allpeopleDropdown.Location = new System.Drawing.Point(61, 95);
            this.allpeopleDropdown.Name = "allpeopleDropdown";
            this.allpeopleDropdown.Size = new System.Drawing.Size(259, 21);
            this.allpeopleDropdown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Years Experience";
            // 
            // yearsExperiencePicker
            // 
            this.yearsExperiencePicker.Location = new System.Drawing.Point(64, 258);
            this.yearsExperiencePicker.Name = "yearsExperiencePicker";
            this.yearsExperiencePicker.Size = new System.Drawing.Size(42, 20);
            this.yearsExperiencePicker.TabIndex = 4;
            this.yearsExperiencePicker.Text = "0";
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.BackColor = System.Drawing.SystemColors.Window;
            this.updatePersonButton.Location = new System.Drawing.Point(74, 338);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(97, 37);
            this.updatePersonButton.TabIndex = 5;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "FIltered List";
            // 
            // filteredpeopleList
            // 
            this.filteredpeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredpeopleList.Location = new System.Drawing.Point(395, 95);
            this.filteredpeopleList.Name = "filteredpeopleList";
            this.filteredpeopleList.Size = new System.Drawing.Size(219, 304);
            this.filteredpeopleList.TabIndex = 7;
            this.filteredpeopleList.Text = "filteredPeopleList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filteredpeopleList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updatePersonButton);
            this.Controls.Add(this.yearsExperiencePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allpeopleDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Linq 101 Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox allpeopleDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown yearsExperiencePicker;
        private System.Windows.Forms.Button updatePersonButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox filteredpeopleList;
    }
}

