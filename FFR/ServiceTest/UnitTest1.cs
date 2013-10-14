﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.Entity;
using System.Configuration;
using System.Linq.Expressions;
using DAL;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCRUDFactoryandReturnARepositoryandCreateCustomer()
        {
            Int16 actionType = 1;
            
            var createCustomer = Activator.CreateInstance<Customer>();
            
            createCustomer.FirstName = "Nick";
            createCustomer.LastName = "Olsen";
            createCustomer.Address = "11320 Lovage Way";
            createCustomer.City = "Parker";
            createCustomer.State = "CO";
            createCustomer.Zip = "80134";
            createCustomer.Phone = "303-949-2695";
            createCustomer.Email = "jolsen@hotmail.com";
            //Factory Return Repository
            var customerRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Customer>();
            //Simulating the business logic that would ultimately be getting called from a controller in the manner it would be called.
            switch (actionType)
            {
                case 1://Create
                    customerRepo.Create(createCustomer);// = new DataRepository<Customer>();
                    break;
                case 2://Update
                    customerRepo.Update(createCustomer);
                    break;
                case 3://Delete
                    customerRepo.Delete(createCustomer);
                    break;
                default:
                    customerRepo = new DataRepository<Customer>();
                    //Assert.AreEqual(savedCustomer.CustomerId, 1);
                    break;
            } //customerRepo.Create(createCustomer);
           // Console.WriteLine("Yeah Buddy");            
        }
        
        
        
        [TestMethod]
        public void UseCRUDFactoryRetrieveUsingRepository()
        {
            var customerRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Customer>();

            List<Customer> customerList = customerRepo.GetAll().ToList<Customer>();
            Assert.IsTrue(customerList.Count > 0);
        }
        
        [TestMethod]
        public void UseCRUDFactoryandReturnARepositoryandUpdateItem()
        {
            Int16 actionType = 2;

            Item createItem = Activator.CreateInstance<Item>();
            createItem.ItemName = "FP Gray Turbo";
            createItem.Price = 1200;
            createItem.ItemCost = 550;
            //createItem.ItemId = 2;
            var itemRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Item>();

            itemRepo.Create(createItem);

            var deleteItemRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Item>();
            Item deleteItem = (from d in deleteItemRepo.GetAll() where d.ItemId == 1 select d).Single();

            switch (actionType)
            {
                case 1://Create
                    deleteItemRepo.Create(deleteItem);// = new DataRepository<Customer>();
                    break;
                case 2://Update
                    deleteItemRepo.Update(deleteItem);
                    break;
                case 3://Delete
                    deleteItemRepo.Delete(deleteItem);
                    break;
                default:
                    deleteItemRepo = new DataRepository<Item>();
                    //Assert.AreEqual(savedCustomer.CustomerId, 1);
                    break;
            }
        }
        [TestMethod]
        public void UseCRUDFactoryandReturnARepositoryandDeleteItem()
        {
            Int16 actionType = 2;

            Item createItem = Activator.CreateInstance<Item>();
            createItem.ItemName = "FP Delete";
            createItem.Price = 1200;
            createItem.ItemCost = 550;

            var itemRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Item>();

            itemRepo.Create(createItem);

            var deleteItemRepo = Service.CRUDRepositoryConcreteFactory.CRUD<Item>();
            Item deleteItem = (from d in deleteItemRepo.GetAll() where d.ItemName == "FP Delete" select d).Single();

            switch (actionType)
            {
                case 1://Create
                    deleteItemRepo.Create(deleteItem);// = new DataRepository<Customer>();
                    break;
                case 2://Update
                    deleteItemRepo.Update(deleteItem);
                    break;
                case 3://Delete
                    deleteItemRepo.Delete(deleteItem);
                    break;
                default:
                    deleteItemRepo = new DataRepository<Item>();
                    //Assert.AreEqual(savedCustomer.CustomerId, 1);
                    break;
            }
        
        }

    }
}
