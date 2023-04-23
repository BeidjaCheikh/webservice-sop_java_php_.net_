package ws;

import jakarta.jws.WebMethod;
import jakarta.jws.WebParam;
import jakarta.jws.WebService;

import java.util.Date;
import java.util.List;


//POJO Plain Old Java Object
@WebService(serviceName ="BanqueWS")
public class BanqueService {
    @WebMethod(operationName = "conversation")
    public double conversion( @WebParam(partName = "montant") double mt){

        return mt*10.54;
    }
    @WebMethod
    public  Compte getCompte(@WebParam(partName = "code") int code){
        return  new Compte(code, Math.random(),new Date());

    }
    @WebMethod
    public List<Compte>compteList(){
        return List.of(

        new Compte(1, Math.random(),new Date()),
        new Compte(2, Math.random(),new Date()),
        new Compte(3, Math.random(),new Date())

        );
    }
}
