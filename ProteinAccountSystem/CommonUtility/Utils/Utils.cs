using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Utils
    {
        // 取得 Enum 列舉 Attribute Description 設定值
        public static  string GetDescriptionText(this Enum source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
             typeof(DescriptionAttribute), false);
            if (attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }

        //public async Task<string> PostAsync(string url, object data)
        //{
        //    //var Client = new HttpClient();
        //    //try
        //    //{
        //    //    string content = JsonConvert.SerializeObject(data);
        //    //    var buffer = Encoding.UTF8.GetBytes(content);
        //    //    var byteContent = new ByteArrayContent(buffer);
        //    //    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    //    var response = await Client.PostAsync(url, byteContent).ConfigureAwait(false);
        //    //    string result = await response.Content.ReadAsStringAsync();
        //    //    if (response.StatusCode != HttpStatusCode.OK)
        //    //    {
        //    //        return string.Empty;
        //    //    }
        //    //    return result;
        //    //}
        //    //catch (WebException ex)
        //    //{
        //    //    if (ex.Response != null)
        //    //    {
        //    //        string responseContent = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
        //    //        throw new System.Exception($"response :{responseContent}", ex);
        //    //    }
        //    //    throw;
        //    //}
        //}

        private static async Task<string> FormDataPostAsync(string url, Dictionary<string, string> formData)
        {
            using (HttpClientHandler handler = new HttpClientHandler())
            {
                using (HttpClient client = new HttpClient(handler))
                {
                    try
                    {
                        #region 呼叫遠端 Web API
                        string FooUrl = $"http://vulcanwebapi.azurewebsites.net/api/Values/FormUrlencodedPost";
                        HttpResponseMessage response = null;

                        #region  設定相關網址內容
                        var fooFullUrl = $"{FooUrl}";

                        // Accept 用於宣告客戶端要求服務端回應的文件型態 (底下兩種方法皆可任選其一來使用)
                        //client.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        // Content-Type 用於宣告遞送給對方的文件型態
                        //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                        #region 使用 MultipartFormDataContent 產生要 Post 的資料
                        // https://msdn.microsoft.com/zh-tw/library/system.net.http.multipartformdatacontent(v=vs.110).aspx
                        using (var content = new MultipartFormDataContent())
                        {
                            foreach (var keyValuePair in formData)
                            {
                                content.Add(new StringContent(keyValuePair.Value), keyValuePair.Key);
                            }
                            response = await client.PostAsync(fooFullUrl, content);
                        }
                        #endregion

                        #endregion
                        #endregion

                        #region 處理呼叫完成 Web API 之後的回報結果
                        if (response != null)
                        {
                            if (response.IsSuccessStatusCode == true)
                            {
                                // 取得呼叫完成 API 後的回報內容
                                string strResult = await response.Content.ReadAsStringAsync();
                                return strResult;
                            }
                            else
                            {
                                return "";
                            }
                        }
                        else
                        {
                            return "";
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        return "";
                    }
                }
            }

            return "";
        }
    }
}
