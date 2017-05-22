using System;
using System.Threading;
using System.Diagnostics;

namespace DigimonWorld {
	public class DataReader {
		public Thread thread;
		public Process epsxe;
		public IntPtr epsxeHandle;

		public DataReader() {
			epsxe = Process.GetProcessesByName("epsxe")[0];
			epsxeHandle = DLL.OpenProcess(DLL.PROCESS_WM_READ, false, epsxe.Id);

			thread = new Thread(new ThreadStart(this.readData));
			thread.Start();
		}

		void readData() {
			Byte[] buffer = new Byte[64];

			while (true) {
				
				Thread.Sleep(100);
			}
		}
	}
}
