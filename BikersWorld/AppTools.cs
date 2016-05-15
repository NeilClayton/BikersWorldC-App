using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
     class  AppTools
    {


        // method to clear all fields from  a group box 
        #region Clear all controls of group Box -> ResetAllGrb
        public static void ResetAllGrb(GroupBox groupBox)
        {

            foreach (Control ctrl in groupBox.Controls)
            {

                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
                if (ctrl is ListBox)
                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.ClearSelected();


                }
            }
        }
        #endregion

        //Disable Controls inside of a GroupBox 
        #region Disable Group Box controls -> disableControlsGrb
        public static void disableControlsGrb(GroupBox groupBox)
        {


            foreach (Control ctrl in groupBox.Controls)
            {

                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.ReadOnly = true;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.Enabled = false;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Enabled = false;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Enabled = false;
                }
                if (ctrl is ListBox)
                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.Enabled = false;


                }
            }
        }

        #endregion


        //Enable Controls inside of a GroupBox 
        #region Enable GroupBox Controls -> enableControlsGrb
        public static void enableControlsGrb(GroupBox groupBox)
        {



            foreach (Control ctrl in groupBox.Controls)
            {

                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.ReadOnly = false;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.Enabled = true;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Enabled = true;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Enabled = true;
                }
                if (ctrl is ListBox)
                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.Enabled = true;


                }
            }

        }
        #endregion


        // 
        public static void formVerifyAndOpen<T>(string formName) where T : Form, new()
        {

       
            Form appForm = Application.OpenForms[formName];




            if (appForm == null)
            {

                T theForm = new T();

                theForm.Show();
            }


        }


    }
}
