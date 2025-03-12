//method for getting the maximum number using arrays
System.Console.WriteLine("How many numbers are you entering??? ");
int n = int.Parse(System.Console.ReadLine());

System.Console.WriteLine($"Enter {n} Numbers: ");
int []numbers=new int[n];

for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(System.Console.ReadLine());
}
System.Console.WriteLine($"The maximum number is {maximum(numbers)}");
static int maximum (int []arr){ //  هناخد الاراي ونرجع اكبر عنصر فيها عن طريق الفور لوب 
    int max=arr[0];
    for (int i=1;i<arr.Length;i++){
        if (arr[i]>max)
        {
            max=arr[i];
        }
    }
    return max;
}
System.Console.ReadKey();
