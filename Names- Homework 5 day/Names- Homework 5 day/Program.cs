

int[] grades= new int[20];

List<string> fewNames = new List<string>();
fewNames.Add("Pawel") ;
fewNames.Add("Ryszard"); 
fewNames.Add("Søren");
fewNames.Add("Linda");
fewNames.Add("Lars") ; 
for (var f = 0; f< fewNames.Count; f++)
{
    Console.WriteLine(fewNames[f]);
}
for (int f = 0; f < 20; f = f+4)
{
    Console.WriteLine(f); 
}