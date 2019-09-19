using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Database;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SaveEmployee(clsEmployee obj)
        {
            try
            {
                EmployeeServices objService = new EmployeeServices();
                return Request.CreateResponse(HttpStatusCode.OK, objService.SaveEmployee(obj));
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            
        }

        [HttpGet]
        public HttpResponseMessage GetEmployeeList()
        {
            try
            {
                EmployeeServices objService = new EmployeeServices();
                //List<tblEmployee> objReturn = objService.GetEmployeeList();
                return Request.CreateResponse(HttpStatusCode.OK, objService.GetEmployeeList());
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetEmployeeByID(int ID)
        {
            try
            {
                EmployeeServices objService = new EmployeeServices();
                //List<tblEmployee> objReturn = objService.GetEmployeeList();
                return Request.CreateResponse(HttpStatusCode.OK, objService.GetEmployeeByID(ID));
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public HttpResponseMessage DeleteEmployee(int ID)
        {
            try
            {
                EmployeeServices objService = new EmployeeServices();
                //List<tblEmployee> objReturn = objService.GetEmployeeList();
                return Request.CreateResponse(HttpStatusCode.OK, objService.DeleteEmployee(ID));
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

    }
}