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
        public Customer localCust;
        public bool Action(Object Class, int ActionType)
        {
            //getActionType(localXmlWriter, xmlFileName);

            if (Class != null)
            {
                //localCust = Class;
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Object>();
                switch (ActionType)
                {

                    case 1://Create
                        Repo.Create(Class);
                        break;
                    case 2://Update
                        Repo.Update(Class);
                        break;
                    case 3://Delete
                        Repo.Delete(Class);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }
        public bool Action(Customer Class, int ActionType)
        {
            //getActionType(localXmlWriter, xmlFileName);

            if (Class != null)
            {
                localCust = Class;
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Customer>();
                switch (ActionType)
                {

                    case 1://Create
                        Repo.Create(localCust);
                        break;
                    case 2://Update
                        Repo.Update(localCust);
                        break;
                    case 3://Delete
                        Repo.Delete(localCust);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        public bool Action(XmlWriter localXmlWriter, string xmlFileName)
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
            else if (InstatiateCallerRequested.item != null)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Item>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.item);

                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.item);
                        break;
                    case 3://Delete
                        var deleteItemRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Item>();
                        Item deleteItem = (from d in deleteItemRepo.GetAll() where d.ItemId == 3 select d).Single();
                        deleteItemRepo.Delete(deleteItem);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.salesHeader != null)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesHeader>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.salesHeader);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.salesHeader);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.salesHeader);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.salesItem != null)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesItem>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.salesItem);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.salesItem);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.salesItem);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.employee != null)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Employee>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.employee);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.employee);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.employee);
                        break;
                    default:
                        break;
                }
            }
            return false; ;
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
