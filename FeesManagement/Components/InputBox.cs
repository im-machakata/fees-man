using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FeesManagement.Utils;

namespace FeesManagement.Components
{
	public partial class InputBox : UserControl
	{
		string Label;
		string Input;
		
		public string Value {
			get { return Input; }
		}
		
		public InputBox(string InputLabel)
		{
			InitializeComponent();
			Label = InputLabel;
			SetText(Label);
		}
		public void SetWidth(int Value){
			Width = Value;
			ILabel.Width = Value - 25;
			ILabel.Refresh();
		}
		public void SetText(string Label){
			ILabel.Text = Label;
			ChangeLabelColor();
		}
		void ChangeLabelColor(){
			var IsLabel = Validation.isEmpty(ILabel) || Validation.isLabel(ILabel,Label);
			ILabel.ForeColor = Color.FromKnownColor(IsLabel ? KnownColor.ScrollBar : KnownColor.ControlText);
		}
		void SetupLabel(){
			if(Validation.isEmpty(ILabel) || Validation.isLabel(ILabel,Label)){
				ILabel.Text = Label;
			}
		}
		void ILabelEnter(object sender, EventArgs e)
		{
			// clear username in equals default
			if(Validation.isLabel(ILabel, Label)){
				ILabel.Clear();
			}
			ChangeLabelColor();
		}
		
		void ILabelLeave(object sender, EventArgs e)
		{
			// if user did not enter anything
			// set text to label
			ChangeLabelColor();
			SetupLabel();
		}
		
		void ILabelKeyUp(object sender, KeyEventArgs e)
		{
			ChangeLabelColor();
		}
		
		void ILabelKeyPress(object sender, KeyPressEventArgs e)
		{
			ChangeLabelColor();
		}
		
		void ILabelTextChanged(object sender, EventArgs e)
		{
			Input = ILabel.Text.Trim();
		}
	}
}
