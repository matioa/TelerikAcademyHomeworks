bool valueFound = false;

for (int i = 0; i < 100; i++) 
{
  Console.WriteLine(array[i]);
  if ( (i % 10 == 0) && (array[i] == expectedValue) ) 
  {
    valueFound = true;
    Console.WriteLine("Value Found");
    break;
  }
}
