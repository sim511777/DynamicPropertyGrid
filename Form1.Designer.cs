using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SreeSharp
{
   public partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnAddCustom = new System.Windows.Forms.Button();
         this.txtValue = new System.Windows.Forms.TextBox();
         this.txtName = new System.Windows.Forms.TextBox();
         this.cmdAdd = new System.Windows.Forms.Button();
         this.chkReadOnly = new System.Windows.Forms.CheckBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.txtNameToRemove = new System.Windows.Forms.TextBox();
         this.cmdRemove = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.btnGetValue = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // propertyGrid1
         // 
         this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
         this.propertyGrid1.Location = new System.Drawing.Point(10, 9);
         this.propertyGrid1.Name = "propertyGrid1";
         this.propertyGrid1.Size = new System.Drawing.Size(268, 293);
         this.propertyGrid1.TabIndex = 0;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.btnAddCustom);
         this.groupBox1.Controls.Add(this.txtValue);
         this.groupBox1.Controls.Add(this.txtName);
         this.groupBox1.Controls.Add(this.cmdAdd);
         this.groupBox1.Controls.Add(this.chkReadOnly);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(288, 9);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(250, 172);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Add Property";
         // 
         // btnAddCustom
         // 
         this.btnAddCustom.Location = new System.Drawing.Point(137, 140);
         this.btnAddCustom.Name = "btnAddCustom";
         this.btnAddCustom.Size = new System.Drawing.Size(90, 25);
         this.btnAddCustom.TabIndex = 6;
         this.btnAddCustom.Text = "Add custom";
         this.btnAddCustom.UseVisualStyleBackColor = true;
         this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
         // 
         // txtValue
         // 
         this.txtValue.Location = new System.Drawing.Point(77, 60);
         this.txtValue.Name = "txtValue";
         this.txtValue.Size = new System.Drawing.Size(163, 21);
         this.txtValue.TabIndex = 5;
         this.txtValue.Text = "Value";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(77, 26);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(163, 21);
         this.txtName.TabIndex = 4;
         this.txtName.Text = "Name";
         // 
         // cmdAdd
         // 
         this.cmdAdd.Location = new System.Drawing.Point(30, 140);
         this.cmdAdd.Name = "cmdAdd";
         this.cmdAdd.Size = new System.Drawing.Size(100, 26);
         this.cmdAdd.TabIndex = 3;
         this.cmdAdd.Text = "Add";
         this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
         // 
         // chkReadOnly
         // 
         this.chkReadOnly.Location = new System.Drawing.Point(10, 103);
         this.chkReadOnly.Name = "chkReadOnly";
         this.chkReadOnly.Size = new System.Drawing.Size(144, 18);
         this.chkReadOnly.TabIndex = 2;
         this.chkReadOnly.Text = "ReadOnly";
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(10, 69);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 17);
         this.label2.TabIndex = 1;
         this.label2.Text = "Value";
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(10, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(48, 18);
         this.label1.TabIndex = 0;
         this.label1.Text = "Name";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.txtNameToRemove);
         this.groupBox2.Controls.Add(this.cmdRemove);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Location = new System.Drawing.Point(288, 213);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(250, 89);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Remove Property";
         // 
         // txtNameToRemove
         // 
         this.txtNameToRemove.Location = new System.Drawing.Point(77, 26);
         this.txtNameToRemove.Name = "txtNameToRemove";
         this.txtNameToRemove.Size = new System.Drawing.Size(163, 21);
         this.txtNameToRemove.TabIndex = 4;
         // 
         // cmdRemove
         // 
         this.cmdRemove.Location = new System.Drawing.Point(77, 54);
         this.cmdRemove.Name = "cmdRemove";
         this.cmdRemove.Size = new System.Drawing.Size(115, 26);
         this.cmdRemove.TabIndex = 3;
         this.cmdRemove.Text = "Remove";
         this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(10, 34);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(48, 18);
         this.label4.TabIndex = 0;
         this.label4.Text = "Name";
         // 
         // btnGetValue
         // 
         this.btnGetValue.Location = new System.Drawing.Point(425, 187);
         this.btnGetValue.Name = "btnGetValue";
         this.btnGetValue.Size = new System.Drawing.Size(90, 27);
         this.btnGetValue.TabIndex = 4;
         this.btnGetValue.Text = "Get value";
         this.btnGetValue.UseVisualStyleBackColor = true;
         this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
         this.ClientSize = new System.Drawing.Size(551, 314);
         this.Controls.Add(this.btnGetValue);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.propertyGrid1);
         this.Name = "Form1";
         this.Text = "Add/Remove Items to/from Property Grid at Runtime";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkReadOnly;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button cmdRemove;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNameToRemove;
		private System.Windows.Forms.Button btnAddCustom;
		private System.Windows.Forms.Button btnGetValue;
   }
}
