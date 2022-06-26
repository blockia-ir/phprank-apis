import requests
from requests.structures import CaseInsensitiveDict

url = "https://site.com/api/v1/reports"

headers = CaseInsensitiveDict()
headers["Content-Type"] = "application/x-www-form-urlencoded"
headers["Authorization"] = "Bearer {api_key}"

data = "url={url}&privacy={0,1,2}&password={pass}"

# url : The webpage's URL.

"""
privacy :
Report page privacy.
Possible values are: 0 for Public, 1 for Private, 2 for Password. Defaults to: 1.
*/
"""

"""
password :
The password for the report page.
Only works with privacy set to 2.
"""

resp = requests.post(url, headers=headers, data=data)

print(resp.status_code)