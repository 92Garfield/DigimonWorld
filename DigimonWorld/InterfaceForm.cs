using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace DigimonWorld {
	public class InterfaceForm : Form {
		bool drag = false;
		Point start_point;

		public InterfaceForm() {
			this.MouseDown += new MouseEventHandler(Form_MouseDown);
			this.MouseUp += new MouseEventHandler(Form_MouseUp);
			this.MouseMove += new MouseEventHandler(Form_MouseMove);

			this.FormBorderStyle = FormBorderStyle.None;

			this.TransparencyKey = Color.Turquoise;
			this.BackColor = Color.Turquoise;
		}

		protected override void OnPaint(PaintEventArgs e) {
			e.Graphics.FillRectangle(new SolidBrush(Color.Violet), 0, 0, 100, 100);
			e.Graphics.DrawImage(Image.FromFile("assets/speed.png"), 0, 0);
		}

		void Form_MouseDown(object sender, MouseEventArgs e) {
			this.drag = true;
			this.start_point = new Point(e.X, e.Y);
		}

		void Form_MouseUp(object sender, MouseEventArgs e) {
			this.drag = false;
		}

		void Form_MouseMove(object sender, MouseEventArgs e) {
			if (this.drag) {
				Point p1 = new Point(e.X, e.Y);
				Point p2 = this.PointToScreen(p1);
				Point p3 = new Point(p2.X - this.start_point.X,
									 p2.Y - this.start_point.Y);
				this.Location = p3;
			}
		}
	}
}
