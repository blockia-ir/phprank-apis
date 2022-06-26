<?php

$url = "https://site.com/api/v1/reports";

$curl = curl_init($url);
curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_POST, true);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);

$headers = array(
   "Content-Type: application/x-www-form-urlencoded",
   "Authorization: Bearer {api_key}",
);
curl_setopt($curl, CURLOPT_HTTPHEADER, $headers);

$data = "url={url}&privacy={0,1,2}&password={pass}";

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

curl_setopt($curl, CURLOPT_POSTFIELDS, $data);

curl_setopt($curl, CURLOPT_SSL_VERIFYHOST, false);
curl_setopt($curl, CURLOPT_SSL_VERIFYPEER, false);

$resp = curl_exec($curl);
curl_close($curl);
var_dump($resp);

?>