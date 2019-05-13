from bs4 import BeautifulSoup
import requests

# Scrapowanie samych marek samochodów
url_1 = 'https://www.autocentrum.pl/spalanie/'
response = requests.get(url_1, timeout=5)
content = BeautifulSoup(response.content, "html.parser")

marki_aut = content.findAll(attrs={"class":"name"})

for marki_aut in content.findAll(attrs={"class":"name"}):
    print(marki_aut.text.encode('utf-8'))

