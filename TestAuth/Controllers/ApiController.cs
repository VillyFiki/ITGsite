using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAuth.Controllers
{
    public class ApiController : ControllerBase
    {
        public async Task<string> GetArticle1()
        {
            //https://etp.gpb.ru/api/procedures.php?inn=7724514910&kpp=772801001&late=10
            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetAsync("api/procedures.php?inn=7724514910&kpp=772801001&late=10");

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.ContentType = "text/xml";
                    string a = "";
                    await Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetArticle2()
        {
            //https://etp.gpb.ru/api/company_list.php?late=1

            string result = "";
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetAsync("api/company_list.php?late=1");

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.ContentType = "text/xml";
                    string a = "";
                    await Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetArticle3()
        {
            //https://etp.gpb.ru/api/company.php?inn=7744001497&kpp=997950001

            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetAsync("api/company.php?inn=7744001497&kpp=997950001");

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.ContentType = "text/xml";
                    string a = "";
                    await Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetArticle4()
        {
            //https://etp.gpb.ru/api/protocols_list.php?updatedonly

            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetAsync("api/protocols_list.php?updatedonly");

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.ContentType = "text/xml";
                    string a = "";
                    await Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }

        }
        public async Task<string> GetArticle5()
        {
            //https://etp.gpb.ru/api/protocols.php?num=ГП410451
            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetAsync("api/protocols.php?num=ГП410451");

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.ContentType = "text/xml";
                    string a = "";
                    await Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }

        }
    }
}
