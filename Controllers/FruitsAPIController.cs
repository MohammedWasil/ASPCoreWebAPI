﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace ASPCoreWebAPI_56M.Controllers
//{
//    //[Route("api/[controller]")]
//   // [ApiController]
//    public class FruitsAPIController : ControllerBase
//    {
//        public List<string> fruits = new List<string>()
//        {
//             "Apple",
//            "Banana",
//            "Mango",
//            "Cherry",
//            "Grapes"
//        };

//        [HttpGet]
//        public List<string> GetFruits()
//        {
//            return fruits;
//        }

//        [HttpGet("{id}")]
//       public string GetFruitsByIdIndex(int id)
//        {
//            return fruits.ElementAt(id);
//        }

//    }
//}
