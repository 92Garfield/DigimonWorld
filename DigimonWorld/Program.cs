using System;
using System.Runtime.InteropServices;

namespace DigimonWorld {

	public struct Rect {
		public int Left { get; set; }
		public int Top { get; set; }
		public int Right { get; set; }
		public int Bottom { get; set; }	}

	class MainClass {
		public static InterfaceForm form;
		public static DataReader dataReader;

		public static void Main(string[] args) {
			dataReader = new DataReader();

			form = new InterfaceForm();
			form.ShowDialog();
		}
	}
}
