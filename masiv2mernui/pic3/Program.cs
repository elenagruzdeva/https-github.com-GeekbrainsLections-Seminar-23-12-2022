int [,] pic = new int [,]
// zdes dolgnu but fiksirovannue dannue v {} skobkax s 0 i 1
void PrintImage (int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) // matrix.Get.Length(0) vmesto 3
    {
      for ( int j=0; j < image.GetLength(1); j++ ) // Matrix.Get.Length(1) vmesto 3
          {
            if (image [i,j] == 0) Console.WriteLine($"");
              //Console.Write($"{image [i,j]} ");
              else Console.WriteLine($"+");
          }

    Console.WriteLine();
    }
}
//kod dlya zakrashivanita paltsya vnytri nige
//= 34 i 35 dobavili stroky

void FIllImage (int row, int col)
{
    if (pic [row,col] == 0) 
    {
     pic [row,col] == 1;
    FIllImage (row-1, col);
    FIllImage (row, col-1);
    FIllImage (row+1, col);
    FIllImage (row, col+1);



    }
}
PrintImage(pic);
FIllImage;
PrintImage(pic);