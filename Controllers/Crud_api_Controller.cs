using API_crud_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;


namespace API_crud_app.Controllers
{
    public class Crud_api_Controller : ApiController
    {
        sqlrevisionEntities1 db = new sqlrevisionEntities1();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetStaf()
        {
            List<NewStaf> list = db.NewStafs.ToList();
            return Ok(list);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GEtStafById( int id )
        {
           var stafn = db.NewStafs.Where(model => model.id == id ).FirstOrDefault();
            return Ok(stafn);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Stafinsurt( NewStaf n )
        {
            db.NewStafs.Add( n );
            db.SaveChanges();
            return Ok();
        }


        [System.Web.Http.HttpPut]
        public IHttpActionResult StafUpdate(NewStaf n)
        {


            db.Entry(n).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            //var stf = db.NewStafs.Where(model => model.id == n.id).FirstOrDefault();
            //if( stf != null )
            //{
            //    stf.id = n.id;
            //    stf.name = n.name;
            //    stf.dipartment = n.dipartment;
            //    stf.gender = n.gender;
            //    stf.age = n.age;
            //    stf.salary = n.salary;
            //    db.SaveChanges();

            //}
            //else
            //{
            //    return NotFound();
            //}
            return Ok();
        }


        [System.Web.Http.HttpDelete]
        public IHttpActionResult Stafdelete(int  id)
        {
            var stafn = db.NewStafs.Where(model => model.id == id).FirstOrDefault();
            
            db.Entry(stafn).State = System.Data.Entity.EntityState.Deleted;

            db.SaveChanges();
            return Ok();
        }


    }
}
