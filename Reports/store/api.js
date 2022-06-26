var url = "https://site.com/api/v1/reports";

var xhr = new XMLHttpRequest();
xhr.open("POST", url);

xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
xhr.setRequestHeader("Authorization", "Bearer {api_key}");

xhr.onreadystatechange = function () {
    if (xhr.readyState === 4) {
        console.log(xhr.status);
        console.log(xhr.responseText);
    }
};

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

xhr.send(data);