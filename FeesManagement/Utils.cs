/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/24/2023
 * Time: 10:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
