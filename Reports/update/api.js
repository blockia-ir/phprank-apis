var url = "https://site.com.ir/api/v1/reports/{id}";

var xhr = new XMLHttpRequest();
xhr.open("PUT", url);

xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
xhr.setRequestHeader("Authorization", "Bearer {api_key}");

xhr.onreadystatechange = function () {
    if (xhr.readyState === 4) {
        console.log(xhr.status);
        console.log(xhr.responseText);
    }
};

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

xhr.send(data);