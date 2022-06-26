var url = "https://site.com/api/v1/reports/{id}";

var xhr = new XMLHttpRequest();
xhr.open("DELETE", url);

xhr.setRequestHeader("Authorization", "Bearer {api_key}");

xhr.onreadystatechange = function () {
    if (xhr.readyState === 4) {
        console.log(xhr.status);
        console.log(xhr.responseText);
    }
};

xhr.send();