using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_TryParse
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAddieren_Click(object sender, EventArgs e)
		{
			try
			{
				// Prüfen, ob in erstes Textfeld eine gültige Zahl eingegeben wurde
				if (!double.TryParse(txtZahl1.Text, out double zahl1))
					throw new ArgumentException("Eingabe in Feld 1 muss eine Zahl sein!");

				// gleiches für 2. Textbox
				if (!double.TryParse(txtZahl2.Text, out double zahl2))
					throw new ArgumentException("Eingabe in Feld 2 muss eine Zahl sein!");

				// Nur Zahlen > 0 sollen akzeptiert werden


				lblErgebnis.Text = (zahl1 + zahl2).ToString();


			}
			// Optional (hier keine spezifische Fehlerbehandlung erforderlich)
			//catch (ArgumentException ex)
			//{
			//	lblErgebnis.Text = ex.Message;
			//}
			catch (Exception ex)
			{
				lblErgebnis.Text = ex.Message;
			}
		}
	}
}
