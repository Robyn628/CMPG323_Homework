
/**
 * Write a description of class FileClass here.
 *
 * @author (Caitlin Botha)
 * @version (34669205)
 */
import java.io.IOException;
import java.io.EOFException;

public class testBankAccount
{    
    public static void main(String [] args)
    {
        System.out.print("\f");
        
        Clientable [] arrClients = new Clientable[20];
        int count = 0;
        
        FileClass file = new FileClass();
        file.readFromFile();
        arrClients = file.getArray();
        count = file.getCount();
        
        display(arrClients,count);
        file.serializeAcc();   
        file.readChequeData();
    }
          
    public static void display(Clientable [] arrClients, int count)
    {
      
        for(int k = 0; k < count; k++)
        {
            Clientable client = arrClients[k];
            System.out.println(client.toString());                         
        }       
    }
    
    
}