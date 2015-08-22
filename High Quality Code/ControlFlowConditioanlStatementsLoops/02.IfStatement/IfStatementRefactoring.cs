Potato potato = new Potato();
//... 
if (potato != null)
{
	bool isPeeled = potato.IsPeeled;
	bool notRotten = !potato.IsRotten;

   if(isPeeled && notRotten)
   	{
    Cook(potato);
	}
}

//----------------------------------------

if (shouldVisitCell && IsInRange(x, MIN_X, MAX_X) && IsInRange(y, MIN_Y, MAX_Y))
{
   VisitCell();
}


private static bool IsInRange(double number, double min, double max)
{
	if (min <= number && number <= max)
	{
		return true;
	}
	return false;
}
