/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpc.server.Models;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

/**
 *
 * @author GamerGruft
 */
public class City {

    public String getCityName() {
        return cityName;
    }

    public void setCityName(String cityName) {
        this.cityName = cityName;
    }

    public String getTemp() {
        return temp;
    }

    public void setTemp(String temp) {
        this.temp = temp;
    }

    public String getMoisture() {
        return moisture;
    }

    public void setMoisture(String moisture) {
        this.moisture = moisture;
    }

    public String getPressure() {
        return pressure;
    }

    public void setPressure(String pressure) {
        this.pressure = pressure;
    }

    public String getWindDirection() {
        return windDirection;
    }

    public void setWindDirection(String windDirection) {
        this.windDirection = windDirection;
    }

    public String getWindSpeed() {
        return windSpeed;
    }

    public void setWindSpeed(String windSpeed) {
        this.windSpeed = windSpeed;
    }

    public String getWeatherDescription() {
        return weatherDescription;
    }

    public void setWeatherDescription(String weatherDescription) {
        this.weatherDescription = weatherDescription;
    }
    @XmlAttribute
    @XmlElement(name = "GradIme")
    private String cityName;
    @XmlElement(name = "Temp")
    private String temp;
    @XmlElement(name = "Vlaga")
    private String moisture;
    @XmlElement(name = "Tlak")
    private String pressure;
    @XmlElement(name = "VjetarSmjer")
    private String windDirection;
    @XmlElement(name = "VjetarBrzina")
    private String windSpeed;
    @XmlElement(name = "Vrijeme")
    private String weatherDescription;

    @Override
    public String toString() {
        return "City name = " + cityName + 
                "\nTempe = " + temp + 
                "\nMoisture = " + moisture + 
                "\nPressure = " + pressure +
                "\nWind direction = " + windDirection + 
                "\nWind speed = " + windSpeed + 
                "\nWeather description = " + weatherDescription;
    }
    
    
}
