
namespace Csharp_2021_TryParse
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtZahl1 = new System.Windows.Forms.TextBox();
			this.txtZahl2 = new System.Windows.Forms.TextBox();
			this.btnAddieren = new System.Windows.Forms.Button();
			this.lblErgebnis = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtZahl1
			// 
			this.txtZahl1.Location = new System.Drawing.Point(13, 13);
			this.txtZahl1.Name = "txtZahl1";
			this.txtZahl1.Size = new System.Drawing.Size(100, 20);
			this.txtZahl1.TabIndex = 0;
			// 
			// txtZahl2
			// 
			this.txtZahl2.Location = new System.Drawing.Point(120, 13);
			this.txtZahl2.Name = "txtZahl2";
			this.txtZahl2.Size = new System.Drawing.Size(100, 20);
			this.txtZahl2.TabIndex = 1;
			// 
			// btnAddieren
			// 
			this.btnAddieren.Location = new System.Drawing.Point(79, 48);
			this.btnAddieren.Name = "btnAddieren";
			this.btnAddieren.Size = new System.Drawing.Size(75, 23);
			this.btnAddieren.TabIndex = 2;
			this.btnAddieren.Text = "Addieren";
			this.btnAddieren.UseVisualStyleBackColor = true;
			this.btnAddieren.Click += new System.EventHandler(this.btnAddieren_Click);
			// 
			// lblErgebnis
			// 
			this.lblErgebnis.AutoSize = true;
			this.lblErgebnis.Location = new System.Drawing.Point(258, 19);
			this.lblErgebnis.Name = "lblErgebnis";
			this.lblErgebnis.Size = new System.Drawing.Size(35, 13);
			this.lblErgebnis.TabIndex = 3;
			this.lblErgebnis.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 96);
			this.Controls.Add(this.lblErgebnis);
			this.Controls.Add(this.btnAddieren);
			this.Controls.Add(this.txtZahl2);
			this.Controls.Add(this.txtZahl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtZahl1;
		private System.Windows.Forms.TextBox txtZahl2;
		private System.Windows.Forms.Button btnAddieren;
		private System.Windows.Forms.Label lblErgebnis;
	}
}

