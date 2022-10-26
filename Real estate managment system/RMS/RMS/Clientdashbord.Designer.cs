namespace RMS
{
    partial class Clientdashbord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableAdapterManager1 = new RMS.R_M_SDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.bimage = new System.Windows.Forms.Button();
            this.baproperty = new System.Windows.Forms.Button();
            this.bby = new System.Windows.Forms.Button();
            this.bsearchp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.bsearchp);
            this.panel1.Controls.Add(this.bby);
            this.panel1.Controls.Add(this.baproperty);
            this.panel1.Controls.Add(this.bimage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1089);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1451, 1089);
            this.panel2.TabIndex = 1;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tblClientPhoneNumberTableAdapter = null;
            this.tableAdapterManager1.tblClientTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = RMS.R_M_SDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "RMS";
            // 
            // bimage
            // 
            this.bimage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bimage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimage.Location = new System.Drawing.Point(0, 213);
            this.bimage.Name = "bimage";
            this.bimage.Size = new System.Drawing.Size(400, 103);
            this.bimage.TabIndex = 0;
            this.bimage.Text = "browes image";
            this.bimage.UseVisualStyleBackColor = false;
            this.bimage.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.bimage.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // baproperty
            // 
            this.baproperty.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.baproperty.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baproperty.Location = new System.Drawing.Point(0, 313);
            this.baproperty.Name = "baproperty";
            this.baproperty.Size = new System.Drawing.Size(400, 103);
            this.baproperty.TabIndex = 5;
            this.baproperty.Text = "Available Property ";
            this.baproperty.UseVisualStyleBackColor = false;
            this.baproperty.MouseLeave += new System.EventHandler(this.baproperty_MouseLeave);
            this.baproperty.MouseHover += new System.EventHandler(this.baproperty_MouseHover);
            // 
            // bby
            // 
            this.bby.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bby.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bby.Location = new System.Drawing.Point(-6, 511);
            this.bby.Name = "bby";
            this.bby.Size = new System.Drawing.Size(400, 103);
            this.bby.TabIndex = 6;
            this.bby.Text = "buy property ";
            this.bby.UseVisualStyleBackColor = false;
            this.bby.MouseLeave += new System.EventHandler(this.bby_MouseLeave);
            this.bby.MouseHover += new System.EventHandler(this.bby_MouseHover);
            // 
            // bsearchp
            // 
            this.bsearchp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bsearchp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsearchp.Location = new System.Drawing.Point(-3, 413);
            this.bsearchp.Name = "bsearchp";
            this.bsearchp.Size = new System.Drawing.Size(400, 103);
            this.bsearchp.TabIndex = 7;
            this.bsearchp.Text = "Search property";
            this.bsearchp.UseVisualStyleBackColor = false;
            this.bsearchp.MouseLeave += new System.EventHandler(this.bsearchp_MouseLeave);
            this.bsearchp.MouseHover += new System.EventHandler(this.bsearchp_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Honeydew;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(-3, 986);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(403, 103);
            this.button5.TabIndex = 8;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Clientdashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 1089);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Clientdashbord";
            this.Text = "Clientdashbord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private R_M_SDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button bsearchp;
        private System.Windows.Forms.Button bby;
        private System.Windows.Forms.Button baproperty;
        private System.Windows.Forms.Button bimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}