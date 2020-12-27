using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using ProteinSystem.Interface.Service;
using ProteinSystem.Log;

namespace ProteinSystem.Service.Service.ExportSheetService
{
    public class GoogleSheetExportSheetService : IExportSheetService
    {
        public bool ExportExcel<T>(IEnumerable<T> list, string path) where T : class
        {
            try
            {
                // If modifying these scopes, delete your previously saved credentials
                // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
                string[] Scopes = { SheetsService.Scope.Spreadsheets };
                string ApplicationName = "GoogleSheetsTest";

                UserCredential credential;

                using (var stream =
                    new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    // The file token.json stores the user's access and refresh tokens, and is created
                    // automatically when the authorization flow completes for the first time.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }

                // Create Google Sheets API service.
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define request parameters.
                String spreadsheetId = "1ohQWljq175WZkIDZrb8F5xsaEZNJvIgELIv7rVVi3yQ";
                String range = "test1!A:E";
  
                SpreadsheetsResource.ValuesResource.AppendRequest request =
                    service.Spreadsheets.Values.Append(new ValueRange() { Values = GenerateData(list) }, spreadsheetId, range);
                request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                var response = request.Execute();
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex.StackTrace);
                LogUtil.Error(ex.ToString());
                LogUtil.Error($"Export google sheet Error! Type:{list.GetType()}");
                return false;
            }
            return true;
        }

        private static IList<IList<Object>> GenerateData(IEnumerable list)
        {
            List<IList<Object>> objNewRecords = new List<IList<Object>>();
          
            foreach (var l in list)
            {
                IList<Object> obj = new List<Object>();
                foreach (var pro in l.GetType().GetProperties())
                {
                    obj.Add(pro.Name);
                }
                objNewRecords.Add(obj);
                break;
            }

            foreach (var l in list)
            {
                IList<Object> obj = new List<Object>();
                foreach (PropertyInfo pro in l.GetType().GetProperties())
                {
                    var Key = pro.Name;
                    var Value = pro.GetValue(l, null);
                    obj.Add(Value.ToString());
                }
                objNewRecords.Add(obj);
            }

            return objNewRecords;
        }
    }
}