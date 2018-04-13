import java.io.*;
import java.net.*;
import java.util.Scanner;
import java.io.File;
import java.io.OutputStream;
/*  Jacob Taylor
 *  Computer Networks
 *  Client Side Code
 * 
 */
public class Client {
    public static void main(String args[]) throws Exception
    {
        String IP = "192.168.1.7"; //Ip address must be changed per computer
        Scanner nameScan = new Scanner(System.in); //scanner for name of the file to be transferred
        System.out.println("Enter the file name (without .txt): ");
        String fileName = nameScan.nextLine() + ".txt"; //the file's name
        nameScan.close();
        //String fileName = "Test1-small.txt";
        File clientFile = new File(fileName); //creating the file object
        long sumTime = 0; //total amount of time to transfer
        for (int i = 1; i <= 100; i++){ //loop through 100 times transferring 1 file each time
            Socket clientSocket = new Socket(IP, 1234); //creating the socket for the client
            System.out.println("I am connecting to the server: IP address " + IP);

            long fileTransferTime = 0;
            System.out.println("I am sending file \"" + fileName + "\" for the " + i + "th time.");
            long startingTime = System.currentTimeMillis();

            Scanner clientReader = new Scanner(clientFile); //reader for the file

            //output stream for sending data to server
            DataOutputStream outputToServer = new DataOutputStream(clientSocket.getOutputStream()); 
            //as long as the file isnt at EOF read the line and output to the server
            while(clientReader.hasNextLine()){
                outputToServer.writeBytes(clientReader.nextLine() + "\n");
            }
            clientReader.close(); //close the reader
            System.out.println("I am finished sending file \"" + fileName + "\" for the " + i + "th time.");
            clientSocket.close(); //close the connection of the client
            long endingTime = System.currentTimeMillis();
            fileTransferTime = endingTime - startingTime; //calculate the time spent to send file
            System.out.println("It took " + fileTransferTime + " milliseconds for \"" + fileName + "\" to transfer the " + i + "th time.");
            sumTime += fileTransferTime; //increase total time
            System.out.println();
        }

        //System.out.println("The total time used to send the file \"" + fileName + "\" 100 times was: " + sumTime + " milliseconds");
        long avgTime = (sumTime / 100); //average time spent
        System.out.println("The average time used to send the file \"" + fileName + "\" in milliseconds is: " + avgTime);
        System.out.println("I am done transfering files now.");
    }
}