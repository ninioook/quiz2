//1. დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
//კენტი რიცხვების ჯამი
//ლუწი რიცხვების ნამრავლი
//დაითვლის მასივში თითოეული ელემენტის რაოდენობას  (3)

Console.Write("Enter number: ");
var n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

var sum = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 1)
    {
        sum += arr[i];
    }
}

Console.WriteLine($"Sum of odd numbers is: {sum}");

var mult = 1;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        mult *= arr[i];
    }
}

Console.WriteLine($"Multiplication  of even numbers is: {mult}");

int count = 1, tempCount;

int tempNumb = 0;

for (int i = 0; i < n ; i++)
{
    tempNumb= arr[i];
    tempCount = 0;
    for (int j = 0; j < n; j++)
    {
        if (tempNumb == arr[j])
        {
            tempCount++;
        }
    }
}



//2. დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის თუ არა მოცემული სტრინგი პალინდრომი (პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის)   (2)

Console.WriteLine("Enter string:");
var palindrome = Console.ReadLine();

bool checkPalindrome(string palindrome)
{
    int length = palindrome.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (palindrome[i] != palindrome[length - 1 - i])
        {
            return false;
        }
    }

    return true;
}
var isPalindrome = checkPalindrome(palindrome);

Console.WriteLine($"Entered string is palindrome= {isPalindrome}");

//3.დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს. Მაგ 1 1 2 2 2 3 4 2 2  - უნდა დაბეჭდოს 3  და 2.  (3)


//4.(ბონუსი) დაწერეთ პროგრამა რომელიც მასივში იპოვნის ყველაზე ხშირად გამეორებული ელემენტის რაოენობას და დაბეჭდავს ამ ელემენტს. (2)

Console.Write("Enter number: ");
var m = int.Parse(Console.ReadLine());

int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int countt = 1, tempCountt;

int frequentNumber = array[0];
int tempNumber = 0;

for (int i = 0; i < m-1; i++)
{
    tempNumber = array[i];
    tempCountt = 0;
    for (int j = 0; j < m; j++)
    {
        if (tempNumber == array[j])
        {
            tempCountt++;
        }
    }
    if (tempCountt > countt)
    {
        frequentNumber = tempNumber;
        countt = tempCountt;
    }
}

Console.WriteLine(frequentNumber);
