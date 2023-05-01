using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FeesManagement.Utils;

namespace FeesManagement.Components
{
	public partial class InputBox : UserControl
	{
		string IBLabel;
		string Input;
		InputBox FocusNext;
		
		public string Value {
			get { return Input; }
		}
		public string Label {
			get { return IBLabel; }
		}
		
		public InputBox(string InputLabel)
		{
			InitializeComponent();
			IBLabel = InputLabel;
			FocusNext = null;
			SetText(IBLabel);
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
		public void FocusBox(InputBox Nxt){
			FocusNext = Nxt;
		}
		public new void Focus(){
			ILabel.Focus();
		}
		public bool IsLabel(){
			return ILabel.Text.Trim() == IBLabel;
		}
		void ChangeLabelColor(){
			var SetDefaultColor = Validation.isEmpty(ILabel) || IsLabel();
			ILabel.ForeColor = Color.FromKnownColor(SetDefaultColor ? KnownColor.ScrollBar : KnownColor.ControlText);
		}
		void SetupLabel(){
			if(Validation.isEmpty(ILabel) || IsLabel()){
				ILabel.Text = IBLabel;
			}
		}
		void ILabelEnter(object sender, EventArgs e)
		{
			// clear username in equals default
			if(Validation.isLabel(ILabel, IBLabel)){
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
			if(e.KeyCode == Keys.Enter && FocusNext != null){
				FocusNext.Focus();
			}
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
