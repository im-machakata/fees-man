using System;
using System.Windows.Forms;

namespace FeesManagement
{
	public class Utils
	{
		public static bool isLabel(RichTextBox input,string label){
			return input.Text.Trim() == label.Trim();
		}
		public static bool isEmpty(RichTextBox input){
			return input.Text.Trim() == null || input.Text.Trim() == "";
		}
	}
}
