using BLL.DTOs;
using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Online_Book_Store.Controllers
{
    public class BookController : ApiController
    {
        [HttpGet]
        [Route("api/books")]
        public HttpResponseMessage Books()
        {
            try
            {
                var data = BookServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/books/{id}")]
            public HttpResponseMessage Book(int id)
        {
            try
            {
                var data = BookServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/books/create")]
        public HttpResponseMessage AddBook( BookDTO  obj)
        {
            try
            {
                var data = BookServices.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Inserted" },data= obj);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpDelete]
        [Route("api/books/delete/{id}")]
        public HttpResponseMessage DeleteBook(int id)
        {
            try
            {
                var data = BookServices.DeleteBook(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
