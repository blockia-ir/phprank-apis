import requests
from requests.structures import CaseInsensitiveDict

url = "https://site.com/api/v1/reports"

headers = CaseInsensitiveDict()
headers["Accept"] = "application/json"
headers["Authorization"] = "Bearer {api_key}"


resp = requests.get(url, headers=headers)

print(resp.status_code)