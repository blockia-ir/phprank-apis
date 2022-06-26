var url = "https://site.com.ir/api/v1/reports/{id}";

var httpRequest = (HttpWebRequest)WebRequest.Create(url);
httpRequest.Method = "PUT";

httpRequest.ContentType = "application/x-www-form-urlencoded";
httpRequest.Headers["Authorization"] = "Bearer {api_key}";

var data = "privacy={0,1,2}&password={pass}&results={results}";

/*
privacy :
Report page privacy.
Possible values are: 0 for Public, 1 for Private, 2 for Password.
*/

/*
password :
The password for the report page.
Only works with privacy set to 2.
*/

/*
results :
Update the report results.
Possible values are: 0 for No, 1 for Yes. Defaults to: 0.
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