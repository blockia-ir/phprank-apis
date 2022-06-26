import requests
from requests.structures import CaseInsensitiveDict

url = "https://site.com.ir/api/v1/reports/{id}"

headers = CaseInsensitiveDict()
headers["Content-Type"] = "application/x-www-form-urlencoded"
headers["Authorization"] = "Bearer {api_key}"

data = "privacy={0,1,2}&password={pass}&results={results}"

"""
privacy :
Report page privacy.
Possible values are: 0 for Public, 1 for Private, 2 for Password.
"""

"""
password :
The password for the report page.
Only works with privacy set to 2.
"""

"""
results :
Update the report results.
Possible values are: 0 for No, 1 for Yes. Defaults to: 0.
"""

resp = requests.put(url, headers=headers, data=data)

print(resp.status_code)