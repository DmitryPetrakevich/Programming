using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000023E0 File Offset: 0x000005E0
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
