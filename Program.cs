namespace C_sharp_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*<----ARRAY OF NUMBERS---->*/
            int[] nummer = new int[] { 1, 2, 3, 4, 5, 6 }; //Array declaration and initialization with values
            nummer[2] = 205; //modifying array elements
            foreach(int nm in nummer)
            {
                Console.WriteLine(nm);
            }

            /*<----ARRAY OF STRINGS---->*/

            string[] matunda = new string[4]; //array declaration and specifying number of elements it will hold
            matunda[0] = "Maembe";
            matunda[1] = "Ndizi";
            matunda[2] = "Machungwa";
           

            foreach (string tunda in matunda)
            {
                Console.WriteLine(tunda);
            }
            // Shorthand array declaration and initialization
            string[] magari = { "Audi", "Mercedes", "Toyota", "Mazda", "Porsche Cayenne" };
            foreach(string gari in magari) //Iterating through the elements of array
            {
                Console.WriteLine(gari);
            }

            string gariMoja = magari[0]; //Accessing array elements
            Console.WriteLine(gariMoja);

            int kiwango = magari.Length; //Getting length of an array
            Console.WriteLine(kiwango);



            /*<---MULTIDIMENSIONAL ARRAYS--->*/
            //An array that contain other arrays as its elements.

            int[,] box; // multidimensional array declaration

            int[,] boxxi = new int[3, 4]; //Initializing a multidimensional array and specifying number of rows and columns
            int[,]boxi ={ { 1,2,3},{ 4,5,6},{ 7,8,9},{ 10,11,12} };

            int element = boxi[1, 1]; //Accessing elements in a multidimensional array
            Console.WriteLine(element);

            boxi[0, 1]=24; //Modifying elements in an array


            int numRows = boxi.GetLength(0);
            Console.WriteLine(numRows); //getting number of rows

            int numCol = boxi.GetLength(1); //Getting number of columns
            Console.WriteLine(numCol);

            for(int row=0;row < numRows; row++) // Iterating through a multidimensional array;
            {
                for(int col=0;col < numCol; col++)
                {
                    Console.WriteLine(boxi[row, col]);
                }
            }


            /*<----JAGGED ARRAY----->*/
            //Each elements can itself be an array, it allows subarrays to have different length
            int[][] jaggedArray; //Declaring jagged arrays.
            int[][] jagged = new int[3][];
            jagged[0] = new int[2]; //specifying array sizes.
            jagged[1] = new int[4];
            jagged[2] = new int[6];


            int[][] jaggedArr = new int[][]
            {
                new int[]{2,3},  //Initializing jagged arrays with values.
                new int[]{4,5,6,7},
                new int[]{3,4,5,6,7,8}
            };

            int wapi = jaggedArr[1][3]; //Accessing elements in a jagged array
            Console.WriteLine(wapi);

            jaggedArr[1][2] = 78; //Modifying elements in a jagged array


            for(int i = 0; i < jaggedArr.Length; i++) {
                for(int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr[i][j]);
                }
            
            }



            
        }
    }
}