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
            Type[] typeArray = MyReflection.GetImplementedTypesFromTypeArray(
                MyReflection.GetTypesInNamespace(
                Assembly.LoadFrom("MyLogicLib.dll"), "MyLogicLib.Task7Logic.Shapes"));
            //comboBox1.DataSource = typeArray;
            comboBox1.DisplayMember = "Name";
            comboBox2.DisplayMember = "Name";
            comboBox3.Items.Add("MyLogicLib.dll");
        }
        
        void comboBox1_DropDownClosed(object sender, EventArgs e) {
            BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
            comboBox2.DataSource = MyReflection.GetMethodsOfType((Type)comboBox1.SelectedItem);
        }
        
        void comboBox3_DropDownClosed(object sender, EventArgs e) {
            BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
            string lib = (string) comboBox3.SelectedItem;
            comboBox1.DataSource = MyReflection.GetImplementedTypesFromTypeArray(
                MyReflection.GetTypesInNamespace(
                    Assembly.LoadFrom(lib), lib.Substring(0, lib.Length-3) + "Task7Logic.Shapes"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodInfo method = (MethodInfo) comboBox2.SelectedItem;
            richTextBox1.Text = MyReflection.RunMethod(
                (Type)comboBox1.SelectedItem, method.Name, new object[]{5, 5}, null).ToString();
        }
    }
}