using System;
using System.Windows.Forms;
using RJP;

namespace RJP_EdytorBazyDanych
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                DataBase.ImportAll();
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Nie znaleziono plików bazodanowych", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    return;
            }
            Application.Run(new Home());
        }
    }
}
