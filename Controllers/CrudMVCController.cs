//using API_crud_app.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Security.Cryptography.X509Certificates;
//using System.Web;
//using System.Web.Mvc;

//namespace API_crud_app.Controllers
//{
//    public class CrudMVCController : Controller
//    {
//        // GET: CrudMVC

//        HttpClient client = new HttpClient();
//        public ActionResult Index()
//        {
//            List<NewStaf> staf = new List<NewStaf>();
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.GetAsync("Crud_api_");
//            response.Wait();


//            var test = response.Result;
//            if(test.IsSuccessStatusCode)
//            {
//                var disply = test.Content.ReadAsAsync<List<NewStaf>>();
//                disply.Wait();
//                staf = disply.Result;   
//            }

//            return View(staf);
//        }

//        public ActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Create(NewStaf n)
//        {
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.PostAsJsonAsync<NewStaf>("Crud_api_", n);
//            response.Wait();


//            var test = response.Result;
//            if (test.IsSuccessStatusCode)
//            {
//                return RedirectToAction("Index");
//            }
//            return View("Create");
//        }

//        public ActionResult Details(int id )
//        {
//            NewStaf n = null;
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.GetAsync("Crud_api_?id=" + id.ToString());
//            response.Wait();


//            var test = response.Result;
//            if (test.IsSuccessStatusCode)
//            {
//                var disply = test.Content.ReadAsAsync<NewStaf>();
//                disply.Wait();
//                n = disply.Result;
//            }
//            return View(n);

//        }

//        public ActionResult Edit(int id)
//        {
//            NewStaf n = null;
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.GetAsync("Crud_api_?id=" + id.ToString());
//            response.Wait();


//            var test = response.Result;
//            if (test.IsSuccessStatusCode)
//            {
//                var disply = test.Content.ReadAsAsync<NewStaf>();
//                disply.Wait();
//                n = disply.Result;
//            }
//            return View(n);
//        }

//        [HttpPost]
//        public ActionResult Edit( NewStaf n )
//        {
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.PutAsJsonAsync<NewStaf>("Crud_api_", n);
//            response.Wait();


//            var test = response.Result;
//            if (test.IsSuccessStatusCode)
//            {
//                return RedirectToAction("Index");
//            }
//            return View("Edit");
//        }

//        public ActionResult Delete(int id)
//        {
//            NewStaf n = null;
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.GetAsync("Crud_api_?id=" + id.ToString());
//            response.Wait();


//            var test = response.Result;
//            if (test.IsSuccessStatusCode)
//            {
//                var disply = test.Content.ReadAsAsync<NewStaf>();
//                disply.Wait();
//                n = disply.Result;
//            }
//            return View(n);
//        }

//        [HttpPost , ActionName("Delete")]
//        public ActionResult Deleteconfirm (int id)
//        {
//            client.BaseAddress = new Uri("http://localhost:53301/api/Crud_api_");
//            var response = client.DeleteAsync("Crud_api_/"+ id.ToString());
//            response.Wait();

//            var test = response.Result;
//            if (test.IsSuccessStatusCode)
//            {
//                return RedirectToAction("Index");
//            }
//            return View("Delete");
//        }
//    }
//}