/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpc.client;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;

/**
 *
 * @author GamerGruft
 */
public class RPCClient {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL("http://localhost:8080"));
        config.setEnabledForExceptions(true);
        config.setContentLengthOptional(false);
        //za decimalnu tocku na true
        config.setEnabledForExtensions(true);
        
        XmlRpcClient client = new XmlRpcClient();
        client.setConfig(config);
        
        BufferedReader reader = new BufferedReader(
            new InputStreamReader(System.in));
        
        String finish;
        String result;
        
        do {
            System.out.println("Enter city name:");
            String city = reader.readLine();
            Object[] param = new Object[]{city};
            
            result =(String) client.execute("Methods.getCity", param);
            
            System.out.println(result);

            System.out.println("\nDo you wish to continue? \nY : N");
            finish = reader.readLine();
        } while ("Y".toLowerCase().equals(finish.toLowerCase()));
        
        } catch (Exception e) {
            
        }

    }
    
}
