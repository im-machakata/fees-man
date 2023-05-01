using System;
using System.Windows.Forms;

namespace FeesManagement.Utils
{
	public class Validation
	{
		public static bool isLabel(RichTextBox input,string label){
			return input.Text.Trim() == label.Trim();
		}
		public static bool isEmpty(RichTextBox input){
			return input.Text.Trim() == null || input.Text.Trim() == "";
		}
		public static bool isEmpty(string input){
			try {
				return input.Trim() == null || input.Trim() == "";
			} catch (NullReferenceException) {
				return true;
			}
		}
	}
}
