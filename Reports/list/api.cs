var url = "https://site.com/api/v1/reports";

var httpRequest = (HttpWebRequest)WebRequest.Create(url);

httpRequest.Accept = "application/json";
httpRequest.Headers["Authorization"] = "Bearer {api_key}";


var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
{
   var result = streamReader.ReadToEnd();
}

Console.WriteLine(httpResponse.StatusCode);