using System;
using System.Drawing;

namespace Level_10
{
	public abstract class Shape {
		
		public abstract void Draw();

		public Size Bounds {
			get;
			set;
		}
		
		public Point Position {
			get;
			set;
		}
	}
	
	public class Square : Shape {
		public Square() {
			
		}
		
		public override void Draw() {
			this.Position = new Point(2, 4);
		}
	}
	
	public class Circle : Shape {
		public Circle() {
			
		}
		
		public override void Draw() {
			
		}
	}
}

