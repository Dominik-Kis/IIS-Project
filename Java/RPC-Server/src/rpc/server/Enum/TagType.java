/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpc.server.Enum;

import java.util.Optional;

/**
 *
 * @author GamerGruft
 */
public enum TagType {
    CITY_NAME("GradIme"),
    TEMPERATURE("Temp"),
    MOISTURE("Vlaga"),
    PRESSURE("Tlak"),
    WIND_DIRECTION("VjetarSmjer"),
    WIND_SPEED("VjetarBrzina"),
    DESCRIPTION("Vrijeme");

    private final String name;

    private TagType(String name) {
        this.name = name;
    }

    public static Optional<TagType> from(String name) {
        for (TagType value : values()) {
            if (value.name.equals(name)) {
                return Optional.of(value);
            }
        }
        return Optional.empty();
    }
}
