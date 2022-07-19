/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpc.server;

import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.server.XmlRpcServer;
import org.apache.xmlrpc.server.XmlRpcServerConfigImpl;
import org.apache.xmlrpc.webserver.WebServer;

/**
 *
 * @author GamerGruft
 */
public class RPCServer {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
        System.out.println("Kreiram server ...");
        WebServer server = new WebServer(8080);
        
        XmlRpcServer xmlServer = server.getXmlRpcServer();
        PropertyHandlerMapping phm = new PropertyHandlerMapping();
        phm.addHandler("Methods", Methods.class);
        xmlServer.setHandlerMapping(phm);
        
        //config
        XmlRpcServerConfigImpl config = (XmlRpcServerConfigImpl) xmlServer.getConfig();
        config.setEnabledForExceptions(true);
        config.setContentLengthOptional(false);
        //za decimalnu tocku na true
        config.setEnabledForExtensions(true);
        
        System.out.println("Pokrecem server ...");
        server.start();
        System.out.println("Server pokrenut.");
        } catch (Exception e) {
            
        }
    }
    
}
