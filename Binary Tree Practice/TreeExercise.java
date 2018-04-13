import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;
/**
 *
 * @author csu
 */
public class TreeExercise 
{
    public static void main(String args[])
    {
        String[] myStringsChars = new String[26];

        for(int i = 0; i < myStringsChars.length; i++)
        {
            myStringsChars[i] = new String(Character.toChars(i+65));
            System.out.println(myStringsChars[i]);
        }

        // create the Tree as a linked structure from the array myStringChars
        // the Strings are stored using the representation for trees as arrays in the book
        // (e.g. for an element i, the left child is stored in position 2*i + 1, right child is 
        // on position 2*(i + 1). Also specify the level of a TreeNode

        List<TreeNode> nodes = new LinkedList();
        List<TreeNode> nodesList = new LinkedList();
        TreeNode root = new TreeNode(myStringsChars[0], null);
        nodes.add(root);
        //         nodesList.add(root);
        //         for(int i = 0; i < myStringsChars.length; i++)
        //         {
        //             TreeNode parent = nodes.remove(0);            
        //             if(2 * i + 1 < 26)
        //             {
        //                 String left = myStringsChars[2 * i + 1];
        //                 TreeNode leftNode = new TreeNode(left, parent);
        //                 parent.setLeftChild(leftNode);
        //                 nodes.add(leftNode);
        //                 nodesList.add(leftNode);
        //                 
        //             }
        //             if(2 * (i+1) < 26)
        //             {
        //                 String right = myStringsChars[2*(i+1)];
        //                 TreeNode rightNode = new TreeNode(right, parent);
        //                 parent.setRightChild(rightNode);
        //                 nodes.add(rightNode);
        //                 nodesList.add(rightNode);
        //             }          
        //         }

        for(int i = 1; i < 26; i++)
        {
            String letter = myStringsChars[i];
            TreeNode node = new TreeNode(letter, null);
            nodes.add(node);            
        }

        for(int i = 1; i < nodes.size(); i++)
        {

            if(i%2==0)
            {
                TreeNode child = nodes.get(i);
                TreeNode parent = nodes.get((i-1)/2);
                parent.setRightChild(child);
                child.setParent(parent);                
            }
            else
            {
                TreeNode child = nodes.get(i);
                TreeNode parent = nodes.get((i/2));
                parent.setLeftChild(child);
                child.setParent(parent);                
            }
        }
        System.out.println("");
        printTree(nodes);
        //         Scanner scan = new Scanner(System.in);
        //         System.out.println("Enter the first node to find lowest common ancestor of: ");
        //         String letter1 = scan.nextLine();
        //         System.out.println("Enter the second node to find lowest common ancestor of: ");
        //         String letter2 = scan.nextLine();        
        //         TreeNode first = root.findNodeOnTree(letter1);
        //         TreeNode second = root.findNodeOnTree(letter2);

        // create a traversal by levels and print as you traverse to check that the creation of the tree has happened correctly
        // create the code that asks the user for two letters in uppercase and searches for the nodes in the tree that contain
        // such letters     

        // create the code that calls the static method below and finds the lowest common ancestor of two TreeNodes
        //         TreeNode commonAncestor = findLowestCommonAncestor(firstNode, secondNode);
        //         
        //         if(commonAncestor != null)
        //         {
        //             System.out.println(commonAncestor.getContents());
        //         }    
    }   

    public static void printTree(List<TreeNode> x)
    {
        for ( int i = 0; i< x.size(); i++)
        {
            TreeNode a = x.get(i);
            System.out.println(a.parentPrint());
            System.out.println(a.leftChildPrint());
            System.out.println(a.rightChildPrint());
            System.out.println("");
            //             if(2 * i + 1 < 26)
            //             {                
            //                 System.out.println(a.toString2());
            //             }
            //             else
            //             {
            //                 System.out.println(a.toString2());
            //             }
        }
    }

    public static TreeNode findLowestCommonAncestor(TreeNode node1, TreeNode node2)
    {
        // Given two nodes on the same tree, this method should return the lowest common ancestor.
        // if no common ancestor is found, this method returns null .        
        List<TreeNode> path1 = new LinkedList();
        List<TreeNode> path2 = new LinkedList();
        while(node1.getParent()!= null)
        {
            path1.add(node1);
            node1 = node1.getParent();
        }
        while(node2.getParent()!=null)
        {
            path2.add(node2);
            node2 = node2.getParent();
        }
        return null;
    }       
}