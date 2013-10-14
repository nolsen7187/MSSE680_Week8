using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using System.Collections;
using System.Xml;
using DAL;

namespace BusinessLayer
{
    public class Facade
    {
        private InstatiateCallerRequested instatiateCallerRequested = new InstatiateCallerRequested();
        private HandleData handleData = new HandleData();
        private PerformAction performAction = new PerformAction();
        private Customer lclClass;
        private int lclActionType;
        private XmlWriter localXMLWriter;
        private String localxmlFileName;
        private Object lclObjectClass;

        public Facade(XmlWriter xmlWriter, string xmlFileName)
        {
            this.localXMLWriter = xmlWriter;
            this.localxmlFileName = xmlFileName;
        }

        public Facade(Customer Class, int ActionType) 
        {
            this.lclClass = Class;
            this.lclActionType = ActionType;
        }
        public Facade(Customer Class)
        {
            this.lclObjectClass = Class;
            //this.lclActionType = ActionType;
        }
        public void ProcessRequest()
        {
            if (localXMLWriter != null)
            {
                instatiateCallerRequested.InstantiateCallerRequested(localXMLWriter, localxmlFileName);
                handleData.setdata(localXMLWriter, localxmlFileName);
                performAction.Action(lclClass, lclActionType);
                this.localXMLWriter.Dispose();
                this.localxmlFileName = "";
            }
            else if (lclClass != null)
            {
                performAction.Action(lclClass, lclActionType);
            }
            else
            {
                performAction.Action(lclObjectClass, lclActionType);
            }
        }
    }
}
