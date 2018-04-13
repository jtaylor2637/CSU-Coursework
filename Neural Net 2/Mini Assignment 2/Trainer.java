import java.util.Arrays;
public class Trainer
{
    public static int[][] sign(int[][] a, int[][] b, int[][] c, int [][] input) {
        int row = a.length;
        int col = a[0].length;
        int [][] d = multiply(a, b);       
        int [][] e = subtract(d, c);        
        int [][] f = new int[4][1];
        for(int i = 0; i< 4; i++) {
            for(int j = 0; j < 1; j++){
                if(e[i][j] > 0) {
                    f[i][j] = 1;
                } else if (e[i][j] < 0) {
                    f[i][j] = -1;
                } else {
                    f[i][j] = input[i][j];
                }
            }
        }
        return f;
    }

    public static int[][] multiply(int[][] a, int[][] b) {
        int rowsInA = a.length;
        int columnsInA = a[0].length; // same as rows in B
        int columnsInB = b[0].length;
        int[][] c = new int[rowsInA][columnsInB];
        for (int i = 0; i < rowsInA; i++) {
            for (int j = 0; j < columnsInB; j++) {
                for (int k = 0; k < columnsInA; k++) {
                    c[i][j] = c[i][j] + a[i][k] * b[k][j];
                }
            }
        }
        return c;
    }

    public static int[][] scalarMulti(int[][] a, int b) {
        int rowsInA = a.length;
        int columnsInA = a[0].length; // same as rows in B        
        int[][] c = new int[rowsInA][columnsInA];
        for (int i = 0; i < rowsInA; i++) {
            for (int j = 0; j < columnsInA; j++) {
                c[i][j] = a[i][j] * b;
            }
        }
        return c;
    }

    public static int[][] transpose(int[][]a) {       

        int row = a.length;
        int col = a[0].length;

        int transpose[][] = new int[col][row];

        for (int i = 0 ; i < row ; i++)
        {
            for (int j = 0; j < col ; j++ )               
                transpose[j][i] = a[i][j];
        }
        return transpose;
    }

    public static int[][] add(int[][] a, int[][] b) {
        int row = a.length;
        int col = a[0].length; // same as rows in B

        int[][] c = new int[row][col];
        for ( int i = 0 ; i < row ; i++ )
            for ( int j = 0 ; j < col ; j++ )
                c[i][j] = a[i][j] + b[i][j];

        return c;
    }

    public static int[][] subtract(int[][] a, int[][] b) {
        int row = a.length;
        int col = a[0].length; // same as rows in B

        int[][] c = new int[row][col];
        for ( int i = 0 ; i < row ; i++ )
            for ( int j = 0 ; j < col ; j++ )
                c[i][j] = a[i][j] - b[i][j];

        return c;
    }

    public static boolean compareMatrix(int[][] a, int[][] b){
        if (Arrays.deepEquals(a, b)) {
            return true;
        } else {
            return false;
        }
    }

    public static void main(String[] args) {
        int posMatrix[][] = { {1}, {1}, {1}, {1} };
        int negMatrix[][] = { {-1}, {-1}, {-1}, {-1} };
        int posTran[][] = transpose(posMatrix);
        int negTran[][] = transpose(negMatrix);
        int mulPos[][] = multiply(posMatrix, posTran);
        int mulNeg[][] = multiply(negMatrix, negTran);
        int states = 2;
        int IDMatrix[][] = { {1, 0, 0, 0}, {0, 1, 0, 0}, {0, 0, 1, 0}, {0, 0, 0, 1}};
        int stID[][] = scalarMulti(IDMatrix, 2);
        int summation[][] = add(mulPos, mulNeg);
        int weightMatrix[][] = subtract(summation, stID);
        int threshold[][] = { {-6}, {-6}, {-6}, {-6} };
        int threshold2[][] = { {6}, {6}, {6}, {6} };
        int x1[][] = { {1}, {1}, {1}, {1} };
        int x2[][] = { {1}, {1}, {1}, {-1} };
        int x3[][] = { {1}, {1}, {-1}, {-1} };
        int x4[][] = { {1}, {-1}, {-1}, {-1} };
        int x5[][] = { {-1}, {-1}, {-1}, {-1} };      

        Neuron a = new Neuron(posMatrix);
        Neuron b = new Neuron(negMatrix);
        a.setWeight(weightMatrix);
        b.setWeight(weightMatrix);

        System.out.println("State 1");
        for (int i = 0; i < posMatrix.length; i++) {
            for (int j = 0; j < posMatrix[0].length; j++) {
                System.out.print(posMatrix[i][j] + " ");
            }
            System.out.println();
        }
        System.out.println();

        System.out.println("Input 1 testing");
        System.out.println();
        int [][] sigX1 = sign(weightMatrix, x4, threshold, posMatrix);
        int count = 1;
        boolean finished = false;
        while(finished == false) {
            System.out.format("Epoch %d%n" , count);
            if(compareMatrix(posMatrix, sigX1) == true) {
                for (int i = 0; i < sigX1.length; i++) {
                    for (int j = 0; j < sigX1[0].length; j++) {
                        System.out.print(sigX1[i][j] + " ");
                    }
                    System.out.println();
                }
                System.out.println();
                finished = true;
            } else {
                for (int i = 0; i < sigX1.length; i++) {
                    for (int j = 0; j < sigX1[0].length; j++) {
                        System.out.print(sigX1[i][j] + " ");
                    }
                    System.out.println();
                }
                System.out.println();
                count++;
                sigX1 = sign(weightMatrix, sigX1, threshold, posMatrix);
            }            
        }

       
        /*
        System.out.println("Input 2 result");
        int [][] sigX2 = sign(weightMatrix, x2, threshold, posMatrix);
        for (int i = 0; i < sigX2.length; i++) {
        for (int j = 0; j < sigX2[0].length; j++) {
        System.out.print(sigX2[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println();
        System.out.println("Input 3 result");
        int [][] sigX3 = sign(weightMatrix, x3, threshold, posMatrix);
        for (int i = 0; i < sigX3.length; i++) {
        for (int j = 0; j < sigX3[0].length; j++) {
        System.out.print(sigX3[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println(); 
        System.out.println("Input 4 result");
        int [][] sigX4 = sign(weightMatrix, x4, threshold, posMatrix);
        for (int i = 0; i < sigX4.length; i++) {
        for (int j = 0; j < sigX4[0].length; j++) {
        System.out.print(sigX4[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println(); 
        System.out.println("Input 5 result");
        int [][] sigX5 = sign(weightMatrix, x5, threshold, posMatrix);
        for (int i = 0; i < sigX5.length; i++) {
        for (int j = 0; j < sigX5[0].length; j++) {
        System.out.print(sigX5[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println();

        System.out.println("State 2");
        for (int i = 0; i < negMatrix.length; i++) {
        for (int j = 0; j < negMatrix[0].length; j++) {
        System.out.print(negMatrix[i][j] + " ");
        }
        System.out.println();
        }

        System.out.println();
        System.out.println("Input 1 result");
        int [][] sigX6 = sign(weightMatrix, x1, threshold2, negMatrix);
        for (int i = 0; i < sigX6.length; i++) {
        for (int j = 0; j < sigX6[0].length; j++) {
        System.out.print(sigX6[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println();
        System.out.println("Input 2 result");
        int [][] sigX7 = sign(weightMatrix, x2, threshold2, negMatrix);
        for (int i = 0; i < sigX7.length; i++) {
        for (int j = 0; j < sigX7[0].length; j++) {
        System.out.print(sigX7[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println();
        System.out.println("Input 3 result");
        int [][] sigX8 = sign(weightMatrix, x3, threshold2, negMatrix);
        for (int i = 0; i < sigX8.length; i++) {
        for (int j = 0; j < sigX8[0].length; j++) {
        System.out.print(sigX8[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println(); 
        System.out.println("Input 4 result");
        int [][] sigX9 = sign(weightMatrix, x4, threshold2, negMatrix);
        for (int i = 0; i < sigX9.length; i++) {
        for (int j = 0; j < sigX9[0].length; j++) {
        System.out.print(sigX9[i][j] + " ");
        }
        System.out.println();
        }
        System.out.println(); 
        System.out.println("Input 5 result");
        int [][] sigX10 = sign(weightMatrix, x5, threshold2, negMatrix);
        for (int i = 0; i < sigX10.length; i++) {
        for (int j = 0; j < sigX10[0].length; j++) {
        System.out.print(sigX10[i][j] + " ");
        }
        System.out.println();
        } 
         */

    }      
}
