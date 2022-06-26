var url = "https://site.com/api/v1/reports";

var httpRequest = (HttpWebRequest)WebRequest.Create(url);
httpRequest.Method = "POST";

httpRequest.ContentType = "application/x-www-form-urlencoded";
httpRequest.Headers["Authorization"] = "Bearer {api_key}";

var data = "url={url}&privacy={0,1,2}&password={pass}";

// url : The webpage's URL.

/*
privacy :
Report page privacy.
Possible values are: 0 for Public, 1 for Private, 2 for Password. Defaults to: 1.
*/

/*
password :
The password for the report page.
Only works with privacy set to 2.
*/

using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
{
   streamWriter.Write(data);
}

var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
{
   var result = streamReader.ReadToEnd();
}

Console.WriteLine(httpResponse.StatusCode);