﻿using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : Repo, IRepo<Employee, int, bool>
    {
        /*static EmpContext db;
        static EmployeeRepo() { 
            db = new EmpContext();  
        }
        public static List<Employee> Get() {
            return db.Employees.ToList();
            //var emps = new List<Employee>();    
            //for(int i = 1; i < 10; i++)
            //{
            //    emps.Add(new Employee() { Id=i, Name="E-" +i});
            //}
            //return emps;
        }
        public static Employee Get(int id) {
            return db.Employees.Find(id);
        }
        public static bool Insert(Employee emp) {
            db.Employees.Add(emp);
            return db.SaveChanges() > 0;
        }
        public static bool Update(Employee emp) {
            var exemp = Get(emp.Id);
            db.Entry(exemp).CurrentValues.SetValues(emp);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id) { 
            var emp = Get(id);
            db.Employees.Remove(emp);
            return db.SaveChanges() > 0;

        }*/
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Employee obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
