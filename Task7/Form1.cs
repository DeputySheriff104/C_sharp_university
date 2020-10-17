using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLogicLib.Task7Logic.ReflectionLogic;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                MyReflection.GetImplementedTypesFromTypeArray(
                    MyReflection.GetTypesInNamespace(
                        Assembly.LoadFrom("MyLogicLib.dll"), "MyLogicLib.Task7Logic.Shapes"));
                classComboBox.DisplayMember = "Name";
                methodComboBox.DisplayMember = "Name";
                libraryComboBox.Items.Add("MyLogicLib.dll");
        }
        
        void classComboBox_DropDownClosed(object sender, EventArgs e) {
            if (classComboBox.SelectedItem != null)
            {
                BeginInvoke(new Action(() => { classComboBox.Select(0, 0); }));
                methodComboBox.DataSource = MyReflection.GetMethodsOfType((Type) classComboBox.SelectedItem);
                methodComboBox.SelectedItem = null;
                label2.Text = "";
            }
        }
        
        void methodComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (methodComboBox.SelectedItem != null)
            {
                Type type = (Type) classComboBox.SelectedItem;
                label2.Text = MyReflection.GetStringConstructorParams(
                    type.GetConstructors()[0]);
            }
        }
        
        void libraryComboBox_DropDownClosed(object sender, EventArgs e) {
            if (libraryComboBox.SelectedItem != null)
            {
                BeginInvoke(new Action(() => { classComboBox.Select(0, 0); }));
                string lib = (string) libraryComboBox.SelectedItem;
                classComboBox.DataSource = MyReflection.GetImplementedTypesFromTypeArray(
                    MyReflection.GetTypesInNamespace(
                        Assembly.LoadFrom(lib), lib.Substring(
                            0, lib.Length - 3) + "Task7Logic.Shapes"));
                classComboBox.SelectedItem = null;
            }
        }
        
        private void runMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                MethodInfo method = (MethodInfo) methodComboBox.SelectedItem;
                string methParams = textBox1.Text;
                List<object> paramsList = new List<object>();
                int[] paramsArray = methParams
                    .Split(' ')
                    .Select(n => Convert.ToInt32(n)).ToArray();
                foreach (var par in paramsArray)
                {
                    paramsList.Add(par);
                }

                richTextBox1.Text = MyReflection.RunMethod(
                    (Type) classComboBox.SelectedItem, method.Name,
                    paramsList.ToArray(), null).ToString();
            }
            catch (Exception)
            {
                // ignore
            }
        }
    }
}