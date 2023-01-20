

int number = 10044;

string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

List<char> digit  = new List<char>();

digit.Add('0');
digit.Add('1');
digit.Add('2');
digit.Add('3');
digit.Add('4');
digit.Add('5');
digit.Add('6');
digit.Add('7');
digit.Add('8');
digit.Add('9');

foreach (var value in digit)
{
    int count = 0;
    foreach (var x in letters)
        if(value == x) 
   
    { count++; }

    Console.WriteLine(value + "=>" + count);
} 





