using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EmployeeServices
    {
        private readonly Entities db;
        public EmployeeServices()
        {
            db = new Entities();
        }


        public clsEmployeeReturn SaveEmployee(clsEmployee obj)
        {
            clsEmployeeReturn objReturn = new clsEmployeeReturn();

            

            tblEmployee objSave = new tblEmployee();
            if (obj.ID != 0)
            {
                objSave = db.tblEmployees.FirstOrDefault(x => x.ID == obj.ID);
            } 
            objSave.EmployeeName = obj.EmployeeName;
            objSave.DOB = obj.DOB;
            objSave.Gender = obj.Gender;
            objSave.DepartmentID = obj.DepartmentID;
            objSave.IsActive = true;

            db.Entry(objSave).State = obj.ID == 0 ? EntityState.Added : EntityState.Modified;
            db.SaveChanges();


            objReturn.ErrorNumber = "1";
            objReturn.ErrorMessage = "Success";
            return objReturn;
        }

        public List<tblEmployee> GetEmployeeList()
        {
            List<tblEmployee> objReturn = db.tblEmployees.Where(x => x.IsActive == true).ToList();
            return objReturn;
        }
        public tblEmployee GetEmployeeByID(int ID)
        {
            tblEmployee objReturn = db.tblEmployees.Where(x => x.IsActive == true && x.ID == ID).FirstOrDefault();
            return objReturn;
        }

        public clsEmployeeReturn DeleteEmployee(int ID)
        {
            clsEmployeeReturn objR = new clsEmployeeReturn();
            tblEmployee objReturn = db.tblEmployees.Where(x => x.ID == ID).FirstOrDefault();
            objReturn.IsActive = false;
            db.Entry(objReturn).State = EntityState.Modified;
            db.SaveChanges();

            objR.ErrorNumber = "1";
            objR.ErrorMessage = "Successfully deleted Employee";
            return objR;
        }

    }
}