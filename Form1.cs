using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SreeSharp
{

	public partial class Form1 : System.Windows.Forms.Form
	{
		CustomClass myProperties = new CustomClass();

		public Form1()
		{
			InitializeComponent();

			myProperties.Add(new CustomProperty("Name", "Sven", typeof(string), false, true));
			myProperties.Add(new CustomProperty("MyBool", "True", typeof(bool), false, true));
			myProperties.Add(new CustomProperty("CaptionPosition", "Top", typeof(CaptionPosition), false, true));
			myProperties.Add(new CustomProperty("Custom", "", typeof(States), false, true));
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			CustomProperty myProp = new CustomProperty(txtName.Text, txtValue.Text, typeof(string), chkReadOnly.Checked, true);
			myProperties.Add(myProp); 
			propertyGrid1.Refresh();
		}

		private void cmdRemove_Click(object sender, System.EventArgs e)
		{
			myProperties.Remove(txtNameToRemove.Text); 
			propertyGrid1.Refresh(); 
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			propertyGrid1.SelectedObject = myProperties;
		}

		private void btnAddCustom_Click(object sender, EventArgs e)
		{
			myProperties.Add(new CustomProperty("Custom2", "", typeof(States), false, true));
			propertyGrid1.Refresh();
		}

		private void btnGetValue_Click(object sender, EventArgs e)
		{
			object obj = propertyGrid1.SelectedGridItem.Value;
			Console.WriteLine(obj.ToString());
		}
	}

	//-----------------------------

	public enum CaptionPosition
	{
		Top,
		Left
	}

	[TypeConverter(typeof(StatesList))]
	public class States
	{
	}

	public class StatesList : System.ComponentModel.StringConverter
	{
		public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> states = new List<string>();
			states.Add("Alabama");
			states.Add("Alaska");
			states.Add("Arizona");
			states.Add("Arkansas");
			states.Add("Custom "+DateTime.Now.ToString());
			return new StandardValuesCollection(states);
		}

		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
