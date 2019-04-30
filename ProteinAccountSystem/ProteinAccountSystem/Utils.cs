using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProteinAccountSystem
{
    public class Utils
    {
        /// <summary>
        /// post Json数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        public static string PostJson(string url, string postData)
        {
            try
            {
                // 定义request并设置request的路径
                WebRequest request = WebRequest.Create(url);
                request.Method = "post";

                // 设置参数的编码格式，解决中文乱码
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // 设置request的MIME类型及内容长度
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;

                // 打开request字符流
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                // 定义response为前面的request响应
                WebResponse response = request.GetResponse();

                // 定义response字符流
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                var result = reader.ReadToEnd();
                reader.Close();
                return result;
            }
            catch (Exception ex)
            {

            }
            return "";
        }



        public static string PostFromData(string url, Dictionary<string, string> formData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //必須透過ParseQueryString()來建立NameValueCollection物件，之後.ToString()才能轉換成queryString
            NameValueCollection postParams = System.Web.HttpUtility.ParseQueryString(string.Empty);
            foreach (var item in formData)
                postParams.Add(item.Key, item.Value);

            byte[] byteArray = Encoding.UTF8.GetBytes(postParams.ToString());
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(byteArray, 0, byteArray.Length);
            }

            //API回傳的字串
            string responseStr = "";
            //發出Request
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    responseStr = sr.ReadToEnd();
                }
            }
            return responseStr;
        }
    }
}
