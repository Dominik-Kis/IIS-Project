/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javajaxb;

import generated.Weapons;
import java.io.File;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;

/**
 *
 * @author GamerGruft
 */
public class JavaJAXB {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            JAXBContext jc = JAXBContext.newInstance(Weapons.class);
            Marshaller m = jc.createMarshaller();
            
            Unmarshaller u = jc.createUnmarshaller();
            File file = new File("./xmlFiles/JAXB.xml");
            if(file.exists()) { 
                Weapons weapons = (Weapons) u.unmarshal(file);
                m.marshal(weapons, System.out);                
            }else{
                System.out.println("File not found!");
            }

            
        } catch (JAXBException ex) {
            Logger.getLogger(JavaJAXB.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
