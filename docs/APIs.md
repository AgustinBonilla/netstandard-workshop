# Listado de apis para crear clientes .NET Standard en el workshop

## 1
```
URL GET	https://api.ip2country.info/ip?{publicIp}
 Ejemplo	https://api.ip2country.info/ip?8.8.4.4 
```
## 2
```
URL	GET	https://pozzad-email-validator.p.mashape.com/emailvalidator/validateEmail/{emailAddress}
Headers
 X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
 Accept		application/json
Ejemplo	
 GET	https://pozzad-email-validator.p.mashape.com/emailvalidator/validateEmail/fakemail521%40gmail.com
```
## 3
URL	GET	https://currencyconverter.p.mashape.com/availablecurrencies
URL	GET	https://currencyconverter.p.mashape.com/?from={fromCurrency}&from_amount=1&to={toCurrency}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://currencyconverter.p.mashape.com/?from=USD&from_amount=1&to=EUR

## 4
URL	GET	https://restcountries-v1.p.mashape.com/alpha/{countryCode}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://restcountries-v1.p.mashape.com/alpha/ar

## 5
URL	GET	https://duckduckgo-duckduckgo-zero-click-info.p.mashape.com/?format=json&no_html=1&no_redirect=1&q={query}&skip_disambig=1
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://duckduckgo-duckduckgo-zero-click-info.p.mashape.com/?format=json&no_html=1&no_redirect=1&q=lionel+messi&skip_disambig=1

## 6
URL	GET	https://tony11-blacklist-ip-v1.p.mashape.com/ipv4/{ip}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://tony11-blacklist-ip-v1.p.mashape.com/ipv4/8.8.4.4

## 7
URL	GET	https://aplet123-wordnet-search-v1.p.mashape.com/master?word={word}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://aplet123-wordnet-search-v1.p.mashape.com/master?word=football

## 8
URL	GET	https://api.genderize.io/?name={name}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://api.genderize.io/?name=juan

## 9
URL	GET	https://sun.p.mashape.com/api/sun/?city={cityName}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
Ejemplo	GET	https://sun.p.mashape.com/api/sun/?city=buenos+aires

## 10	https://market.mashape.com/moocher-io/domain-reputation
URL	GET	https://moocher-io-domain-reputation-v1.p.mashape.com/{domain}
Headers
    X-Mashape-Key	{apiKey} L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM
    Accept		application/json
    Content-Type	application/json
Ejemplo	GET	https://moocher-io-domain-reputation-v1.p.mashape.com/facebook.com

## 11	
URL	GET	https://openlibrary.org/api/books?bibkeys=ISBN:{isbnNumber}&jscmd=data&format=json
Ejemplo	GET	https://openlibrary.org/api/books?bibkeys=ISBN:9780131101630&jscmd=data&format=json

## 12
URL	GET	https://api.iextrading.com/1.0/stock/{stockName}/quote
Ejemplo	GET	https://api.iextrading.com/1.0/stock/msft/quote

## 13
URL	GET	https://api.onwater.io/api/v1/results/{latitude},{longitude}
Ejemplo	GET	https://api.onwater.io/api/v1/results/23.92323,-66.3

## 14
URL	GET	https://rest.bandsintown.com/artists/{artistName}/events?app_id=myapp
Ejemplo	GET	https://rest.bandsintown.com/artists/divididos/events?app_id=myapp

## 15
URL	GET	https://api.lyrics.ovh/v1/{artist}/{song}
Ejemplo	GET	https://api.lyrics.ovh/v1/TheRollingStones/Satisfaction

## 16
URL	GET	https://fonoapi.freshpixl.com/v1/getdevice?device={deviceName}&token={token}
Ejemplo	GET	https://fonoapi.freshpixl.com/v1/getdevice?device=lumia%20850&token=75d5f68c0bae7032c2d6191f7c13f1d65685e47571cbf434

## 17
URL	GET	https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={YYYY-MM-DD}&endtime={YYYY-MM-DD}&minmagnitude={minMaginitudeValue}
Ejemplo	GET	https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime=2017-09-19&endtime=2017-09-20&minmagnitude=6

## 18
URL	GET	http://api.citybik.es/v2/networks
URL	GET	http://api.citybik.es/v2/networks/{id}

Ejemplo	GET	http://api.citybik.es/v2/networks/movete
Ejemplo	GET	http://api.citybik.es/v2/networks/ecobici-buenos-aires

## 19
URL	GET	https://anapioficeandfire.com/api/books
URL	GET	https://anapioficeandfire.com/api/houses
URL	GET	https://anapioficeandfire.com/api/characters

URL	GET	https://anapioficeandfire.com/api/books/{id}
URL	GET	https://anapioficeandfire.com/api/houses/{id}
URL	GET	https://anapioficeandfire.com/api/characters/{id}

Ejemplo	GET	https://anapioficeandfire.com/api/books/1
Ejemplo	GET	https://anapioficeandfire.com/api/houses/378
Ejemplo	GET	https://anapioficeandfire.com/api/characters/583

## 20
URL	GET	https://www.metaweather.com/api/location/search/?query={cityName}
URL	GET	https://www.metaweather.com/api/location/{locationId}

Ejemplo	GET	https://www.metaweather.com/api/location/search/?query=buenos+aires
Ejemplo	GET	https://www.metaweather.com/api/location/468739


## 21	
URL	GET	http://ipinfo.io/{ip}
Headers
    Content-Type	application/json
Ejemplo	GET	http://ipinfo.io/8.8.4.4

## 22
URL	GET	http://webservice.solcre.com/cotizacion?backdoor=letmein
Headers
    Content-Type	application/json
Ejemplo	GET	http://webservice.solcre.com/cotizacion?backdoor=letmein

## 23
URL	GET	http://www.football-data.org/v1/competitions
URL	GET	http://www.football-data.org/v1/competitions/{competitionId}}/leagueTable
Ejemplo	GET	http://www.football-data.org/v1/competitions/445/leagueTable

## 24
URL GET https://maps.googleapis.com/maps/api/geocode/json?address={inputAddress}&sensor=false
Ejemplo GET https://maps.googleapis.com/maps/api/geocode/json?address=Oxford%20University,%20uk&sensor=false