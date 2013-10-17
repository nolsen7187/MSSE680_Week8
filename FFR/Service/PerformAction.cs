using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using System.Data.Entity;
using DAL;
using System.Xml;

namespace Service
{
    public class PerformAction
    {
        private static Int16 actionType;
        private Customer localCust;
        private Type ClassType;

        /*public static T bar<T>(T obj) where T : class
        {
            var type = obj.GetType();
            return Activator.CreateInstance(type) as T;
        }*/
        //Method used for websites
        public void Action(Object Class, int ActionType)
        {
            //getActionType(localXmlWriter, xmlFileName);
            dynamic ClassObject = Class;
            string ClassType = Class.ToString();
            //this.PassedClass = Class;
           //var ClassType = Convert.ChangeType(Class, ClassObject);
           //var oo = Convert.ChangeType(Class, System.);
           //var ClassType = bar<Object>(PassedClass);
            if (ClassType == "DAL.Customer")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Customer>();
                Act(Repo, ClassObject, ActionType);               
            }
            else if (ClassType == "DAL.Employee")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Employee>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.Item")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Item>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.ItemCategory")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<ItemCategory>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.SalesHeader")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesHeader>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.SalesItem")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesItem>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.WebUserTable")
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<WebUserTable>();
                Act(Repo, ClassObject, ActionType);
            }
        }
        public void Act(IDataRepository DataRepo, dynamic ClassObject, int ActionType)
        {
            switch (ActionType)
            {

                case 1://Create
                    DataRepo.Create(ClassObject);
                    break;
                case 2://Update
                    DataRepo.Update(ClassObject);
                    break;
                case 3://Delete
                    DataRepo.Delete(ClassObject);
                    break;
                default:
                    break;
            }
        }
        //End of logic used by websites



        public void Action(XmlWriter localXmlWriter, string xmlFileName)
        {
            getActionType(localXmlWriter, xmlFileName);

            if (InstatiateCallerRequested.customer != null)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Customer>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.customer);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.customer);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.customer);
                        break;
                    default:
                        break;
                }
            }
        }
        public static void getActionType(XmlWriter localXmlWriter, string xmlFileName)
        {

            XmlReader xmlReader = XmlReader.Create(xmlFileName);

            while (xmlReader.Read())
            {
                if (xmlReader.Name == "ActionType" && xmlReader.Value != "\n" && xmlReader.NodeType != XmlNodeType.EndElement)
                {
                    xmlReader.Read();
                    actionType = Convert.ToInt16(xmlReader.Value);
                    break;
                }
            }
            xmlReader.Close();
        }
    }

}
