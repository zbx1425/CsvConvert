
using System;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace CsvConvert
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            if (args.Length > 0) {
                if (args[0].ToLowerInvariant() == "-nogui") {
                    var language = Properties.Resources.lang_en.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(s => !string.IsNullOrEmpty(s.Trim()))
                        .ToDictionary(l => l.Split(new[] { ',' }, 2)[0].Trim(), l => l.Split(new[] { ',' }, 2)[1]);
                    ConvertUtil.ProcessFile(args.Skip(1).ToArray(), ".csv", new ConvertUtil.ConvertOption(),
                        (m, p) => { }
                    );
                    return;
                } else {
                    mainForm.Shown += (sender, e) => {
                        mainForm.SummonWorkerThread(args);
                    };
                }
            }
            Application.Run(mainForm);
		}
    }
}
