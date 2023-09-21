static String[] ArrFilter(String[] initArr) {
    String[] outArr = Array.Empty<string>();
    int BASE_LENGTH = 3;
    for (int i = 0; i < initArr.Length; ++i) {
        if (initArr[i].Length <= BASE_LENGTH) {
            Array.Resize(ref outArr, outArr.Length + 1);
            outArr[^1] = initArr[i];
        }
    }
    return outArr;
}

static void ArrayFiller(String[] arr) {
    for (int i = 0; i < arr.Length; ++i) {
        Console.Write("Pleaase enter next element: ");

        arr[i] = Console.ReadLine()!;
    }
}

Console.Write("Please enter array size: ");
int size = 0;
while(!int.TryParse(Console.ReadLine(), out size)) {
    Console.WriteLine("Wrong type of input!");
}
String[] initArr = new String[size];
ArrayFiller(initArr);
String[] outArr = ArrFilter(initArr);

Console.WriteLine(string.Join(" ", outArr));



