using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Xml;

namespace Service
{
    public class InstatiateCallerRequested
    {
        public static Customer customer;
        public static Item item;
        public static SalesHeader salesHeader;
        public static SalesItem salesItem;
        public static Employee employee;

        public void InstantiateCallerRequested(XmlWriter localXmlWriter, string xmlFileName)
        {
            customer = null; 
            item = null;
            salesHeader= null; 
            salesItem = null; 
            employee = null;

            XmlReader xmlReader = XmlReader.Create(xmlFileName);
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Customer")
                {
                    customer = Activator.CreateInstance<Customer>();
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Item")
                {
                    item = Activator.CreateInstance<Item>();
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "SalesHeader")
                {
                    salesHeader = Activator.CreateInstance<SalesHeader>();
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "SalesItem")
                {
                    salesItem = Activator.CreateInstance<SalesItem>();
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Employee")
                {
                    employee = Activator.CreateInstance<Employee>();
                    break;
                }
                //throw Exception("No Caller Requested found in XML");

            }
            xmlReader.Close();
        }

    }
}
