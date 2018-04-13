import java.io.*;
import java.net.*;
import java.util.Scanner;
/*
 * Jacob Taylor
 * Computer Networks
 * Server code
 */

public class Server {
    public static void main(String args[]) throws Exception{
        Socket connectionSocket; //current connection of the client
        BufferedReader inClient; //reader for client file lines
        System.out.println("Enter the expected file name (without .txt): ");
        Scanner nameScan = new Scanner(System.in); //file name scanner
        String expectedName = nameScan.nextLine();
        nameScan.close(); //close scanner
        String lineFromClient; //current line of file
        //String bigFileName = "Test1 - large";
        //String smallFileName = "Test1-small.txt";
        String comparison = expectedName + ".txt"; //the expected file
        ServerSocket welcomeSocket = new ServerSocket(1234); //server socket connect
        System.out.println("I am ready for any client side request");
        long sumTime = 0;
        for(int i = 1; i <= 100; i++){ //receive 100 files
            long fileTransferTime = 0;
            connectionSocket = welcomeSocket.accept(); //once client has connected
            System.out.println("I am starting to receive file \"" + expectedName + "\" now for the " + i + "th time");
            long startingTime = System.currentTimeMillis();
            //input stream from the client
            inClient = new BufferedReader(new InputStreamReader(connectionSocket.getInputStream()));
            //writer for the copied files
            PrintWriter out = new PrintWriter("received" + i + ".txt");

            
            boolean EOF = false; //end of file status
            while(EOF == false){ //read from file as long as not at end
                lineFromClient = inClient.readLine();

                if(lineFromClient == null) {
                    EOF = true;
                } else {
                    out.println(lineFromClient);                  
                }
            }

            out.close(); //close print writer
            connectionSocket.close(); //close clients connection
            System.out.println("I am finished receiving file \"" + expectedName + "\" for the" + i + "th time");
            long endingTime = System.currentTimeMillis();
            fileTransferTime = endingTime - startingTime; //calculate file transfer time
            System.out.println("It took " + fileTransferTime + " milliseconds for \"" + expectedName + "\" to transfer the " + i + "th time.");
            System.out.println();
            sumTime += fileTransferTime;
        }
        welcomeSocket.close(); //close server connection once all done with file transfers
        //System.out.println("The total time used to send the file \"" + expectedName + "\" 100 times was: " + sumTime + " milliseconds");
        long avgTime = (sumTime / 100);
        
        System.out.println("The average time used to send the file \"" + expectedName + "\" in milliseconds is: " + avgTime);
        
        
        
        //comparison file
        File serverFile = new File(comparison);
        int numFails = 0; //number of failures in file
        for(int i = 1; i <= 100; i++){ //read all 100 files
            File clientFile = new File("received" + i + ".txt"); //each file received
            Scanner serverReader = new Scanner(serverFile); //reader for server file
            Scanner clientReader = new Scanner(clientFile); //reader for client files

            boolean same = true; //files are equal
            //while readers have next lines, compare them and if they arent the same add a fail counter
            while(serverReader.hasNextLine() && clientReader.hasNextLine()) {
                same = serverReader.nextLine().equals(clientReader.nextLine());
                if(same == false){
                    numFails++;
                    break;
                }                
            }
            serverReader.close(); //close readers
            clientReader.close();
        }
        
        System.out.println("Failure rate is " + numFails + " out of 100");
        System.out.println("I am done");
    }    
}