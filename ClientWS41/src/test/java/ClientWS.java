import proxy.BanqueService;
import proxy.BanqueWS;
import proxy.Compte;

public class ClientWS {
    public static void main(String[] args) {
        BanqueService stub=new BanqueWS().getBanqueServicePort();
        System.out.println(stub.conversation(30));
        //compte
        Compte c=stub.getCompte(3);
        System.out.println(c.getCode());
        System.out.println(c.getSolde());

    }
}
