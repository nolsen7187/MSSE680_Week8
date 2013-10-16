using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BusinessLayer;

namespace PresentationWebForms
{
    public partial class EmployeeRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee uIEmployee = new Employee();

            uIEmployee.EmployeeFirstName = this.FirstNameTextBox.Text;
            uIEmployee.EmployeeLastName = this.LastNameTextBox.Text;
            uIEmployee.Employeetype = this.EmployeeTypeTextBox.Text;
            uIEmployee.EmployeePhone = this.PhoneTextBox.Text;

            object Class = uIEmployee;
            int ActionType = 1;

            //Facade newFacade = new Facade(uIEmployee, ActionType);
            Facade newFacade = new Facade(Class, ActionType);
            newFacade.ProcessRequest();

            if (Page.IsValid)
            {
                SuccessLabel.Text = "You have successfully registered on the FFR's website";
            }
            else
            {
                SuccessLabel.Text = "Failed to registers on FFR's website, please verify you have entered all necessary information.";
            }
            //deploy project
            //CustomerManager cm = new CustomerManager();
            //cm.Insert(uICustomer);
            /*XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            string xmlFileName = "CustomerTest.xml";
            //XmlWriter xmlWriter = XmlWriter.Create("@C:, xmlSetting);
            
            XmlWriter xmlWriter = XmlWriter..Create(xmlFileName, xmlSetting);


            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a customer registers on FFR's site");
            xmlWriter.WriteStartElement("Customer");
            xmlWriter.WriteElementString("ObjectType", "Customer");
            xmlWriter.WriteElementString("ActionType", "1");
            xmlWriter.WriteElementString("FirstName", this.FirstNameTextBox.Text);
            xmlWriter.WriteElementString("LastName", this.LastNameTextBox.Text);
            xmlWriter.WriteElementString("City", this.CityTextBox.Text);
            xmlWriter.WriteElementString("State", this.StateTextBox.Text);
            xmlWriter.WriteElementString("Street", this.StreetTextBox.Text);
            xmlWriter.WriteElementString("Zip", this.StateTextBox.Text);
            xmlWriter.WriteElementString("Phone", this.PhoneTextBox.Text);
            xmlWriter.WriteElementString("Email", this.EmailTextBox.Text);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter, xmlFileName);
            newFacade.ProcessRequest();
            xmlWriter.Dispose();
            xmlFileName = "";*/

        }
    }
}