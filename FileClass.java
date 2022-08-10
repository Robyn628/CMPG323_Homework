
/**
 * Write a description of class FileClass here.
 *
 * @author (Caitlin Botha)
 * @version (34669205)
 */

import java.util.Scanner;
import java.io.FileReader;
import java.io.IOException;
import java.io.EOFException;
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import java.io.FileInputStream;
import java.io.ObjectInputStream;
import javax.swing.JOptionPane;
import java.text.NumberFormat;

public class FileClass
{
    Clientable [] arrClients = new Clientable[20];
    int count = 0;
           
    public void readFromFile()
    {
        try
        {
            Scanner sc = new Scanner(new FileReader("data.txt"));
            
            while (sc.hasNext())
            {
                String line = sc.nextLine();
                String [] info = line.split(",");
                
                String type = info[0];
                String name = info[1];
                String surname = info[2];
                String IDnumber = info[3];
                String contactNum = info[4];
                double balance = Double.parseDouble(info[5]);
                if (type.equals("Sa"))
                {
                    arrClients[count] = new SavingsClient(name, surname, IDnumber,contactNum, balance);
                }
                
                if (type.equals("St"))
                {
                    double bursaryAmount = Double.parseDouble(info[6]);
                    arrClients[count] = new StudentClient(name, surname, IDnumber,contactNum, balance, bursaryAmount);
                }
                                
                if (type.equals("Ch"))
                {
                    arrClients[count] = new ChequeClient(name, surname, IDnumber,contactNum, balance);
                }
                if (type.equals("Co"))
                {
                    double bankfee = Double.parseDouble(info[6]);
                    String compName = info[7];
                    arrClients[count] = new CompanyClient(name, surname, IDnumber,contactNum, balance, bankfee, compName);
                }
                count++;
            } // while
            sc.close();
        } // try
        catch (Exception e)
        {
            JOptionPane.showMessageDialog(null,"Error reading the file");
        }
    }
      
    public void serializeAcc()
    {
        try
        {
            ObjectOutputStream out = new ObjectOutputStream (new FileOutputStream("cheque.ser"));
            
            for(int i = 0; i < count; i++)
            {
                if (arrClients[i] instanceof ChequeClient)
                {
                    out.writeObject(arrClients[i]);
                }
                out.close();
            }
        }
        catch(IOException ex)
        {
            System.out.println(ex);
        }     
    }
    
    public void readChequeData()
    {
        System.out.println("List of cheque clients");
        
        try
        {
            ObjectInputStream input = new ObjectInputStream(new FileInputStream("cheque.ser"));
            
            while (true)
            { 
                Clientable c = (Clientable)input.readObject();
                System.out.printf("%-20s %-10s\n", c.getName(), NumberFormat.getCurrencyInstance().format(c.getBalance()));
            } 
        }
        catch (EOFException endOfFileException)
        {
            System.out.println("No more records");
            System.exit(1);
        }
        catch (ClassNotFoundException classNotFoundException)
        {
            System.err.println("Invalid object type. Terminating.");
        }
        catch (IOException ioException)
        {
             System.err.println("Error reading from file. Terminating.");
        } 
    }
    
    public Clientable [] getArray()
    {
        return arrClients;
    }
    
    public int getCount()
    {
        return count;
    }    
    
}
        





