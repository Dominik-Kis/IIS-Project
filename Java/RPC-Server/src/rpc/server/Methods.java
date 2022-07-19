/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpc.server;

import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import javax.xml.stream.XMLEventReader;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamConstants;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.events.Characters;
import javax.xml.stream.events.StartElement;
import javax.xml.stream.events.XMLEvent;
import rpc.server.Enum.TagType;
import rpc.server.Models.City;

/**
 *
 * @author GamerGruft
 */
public class Methods {
    
    private static final String link = "https://vrijeme.hr/hrvatska_n.xml";
    
    public String getCity(String cityName) throws IOException, XMLStreamException, ParseException {
        List<City> cities = new ArrayList<>();
        
        URL url = new URL(link);
        HttpURLConnection con = (HttpURLConnection) url.openConnection();
        con.setConnectTimeout(10000);
        con.setReadTimeout(10000);
        con.setRequestMethod("GET");
        con.addRequestProperty("User-Agent", "Mozilla/5.0");

        try ( InputStream is = con.getInputStream()) {
            XMLEventReader reader = XMLInputFactory.newFactory().createXMLEventReader(is);

            Optional<TagType> tagType = Optional.empty();
            City city = null;
            StartElement startElement = null;
            while (reader.hasNext()) {
                XMLEvent event = reader.nextEvent();
                switch (event.getEventType()) {
                    case XMLStreamConstants.START_ELEMENT:
                        startElement = event.asStartElement();
                        String qName = startElement.getName().getLocalPart();
                        tagType = TagType.from(qName);

                        if (tagType.isPresent() && tagType.get() == TagType.CITY_NAME) {
                            city = new City();
                            cities.add(city);
                        }
                        break;
                    case XMLStreamConstants.CHARACTERS:
                        if (tagType.isPresent()) {
                            Characters characters = event.asCharacters();
                            String data = characters.getData().trim();
                            switch (tagType.get()) {
                                case CITY_NAME:
                                    if (city != null && !data.isEmpty()) {
                                        city.setCityName(data);
                                    }
                                    break;
                                case TEMPERATURE:
                                    if (city != null && !data.isEmpty()) {
                                        city.setTemp(data);
                                    }
                                    break;
                                case MOISTURE:
                                    if (city != null && !data.isEmpty()) {
                                        city.setMoisture(data);
                                    }
                                    break;
                                case PRESSURE:
                                    if (city != null && !data.isEmpty()) {
                                        city.setPressure(data);
                                    }
                                    break;
                                case WIND_DIRECTION:
                                    if (city != null && !data.isEmpty()) {
                                        city.setWindDirection(data);
                                    }
                                    break;
                                case WIND_SPEED:
                                    if (city != null && !data.isEmpty()) {
                                        city.setWindSpeed(data);
                                    }
                                    break;
                                case DESCRIPTION:
                                    if (city != null && !data.isEmpty()) {
                                        city.setWeatherDescription(data);
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
        }
        for (City element : cities) {
            if (element.getCityName().equals(cityName)) {
                return element.toString();
            }
        }
        return "City no found!";
    }
    
}
