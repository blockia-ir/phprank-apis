import requests
from requests.structures import CaseInsensitiveDict

url = "https://site.com/api/v1/reports/{id}"

headers = CaseInsensitiveDict()
headers["Authorization"] = "Bearer {api_key}"


resp = requests.delete(url, headers=headers)

print(resp.status_code)