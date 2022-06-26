<?php

$url = "https://seolozhist.ir/api/v1/reports/{id}";

$curl = curl_init($url);
curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_PUT, true);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);

$headers = array(
   "Content-Type: application/x-www-form-urlencoded",
   "Authorization: Bearer {api_key}",
);
curl_setopt($curl, CURLOPT_HTTPHEADER, $headers);

$data = "privacy={0,1,2}&password={pass}&results={results}";

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

curl_setopt($curl, CURLOPT_POSTFIELDS, $data);

curl_setopt($curl, CURLOPT_SSL_VERIFYHOST, false);
curl_setopt($curl, CURLOPT_SSL_VERIFYPEER, false);

$resp = curl_exec($curl);
curl_close($curl);
var_dump($resp);

?>