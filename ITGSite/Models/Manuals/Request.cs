using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ITGSite.Models.Manuals
{
    public class RequestModel
    {
        public static async Task<string> procedures()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetStringAsync("api/procedures.php?inn=7724514910&kpp=772801001&late=10");

                return Convert.ToString(response);
            }
            catch
            {
                return "Не удалось подключиться";
            }
        }
        public static async Task<string> company_list()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetStringAsync("api/company_list.php?late=1");


                return Convert.ToString(response);
            }
            catch
            {
                return "Не удалось подключиться";
            }
        }
        public static async Task<string> company()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetStringAsync("api/company.php?inn=7744001497&kpp=997950001");

                return Convert.ToString(response);
            }
            catch
            {
                return "Не удалось подключиться";
            }
        }
        public static async Task<string> protocols_list()
        {
            //https://etp.gpb.ru/api/protocols_list.php?updatedonly

            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetStringAsync("api/protocols_list.php?updatedonly");

                return Convert.ToString(response);
            }
            catch
            {
                return "Не удалось подключиться";
            }

        }
        public static async Task<string> protocols()
        {
            //https://etp.gpb.ru/api/protocols.php?num=ГП410451
            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetStringAsync("api/protocols.php?num=ГП410451");

                return Convert.ToString(response);
            }
            catch
            {
                return "Не удалось подключиться";
            }

        }
    }
}
