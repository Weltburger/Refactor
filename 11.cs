List<int> arr = new List<int>();
List<int> tmpArr = new List<int>();
for (int i = 0; i < arr.Count; i++)
{
	if (arr[i] > 100)
	{
	}
	else
	tmpArr.Add(arr[i]);
}
arr = tmpArr;

//-------------------------

private List<int> select(arr[])
{
	for (int i = 0; i < arr.Count; i++)
	{
		if (arr[i] > 100)
		{
		}
		else
		tmpArr.Add(arr[i]);
	}

	return arr;
}

tmpArr = select(arr);

//-------------------------------------------------------------------------

void method11(){
List<int> arr = new List<int>();
    for (int i = 0; i < arr.Count; i++)
    {
    if (arr[i] > 100);
        arr.RemoveAt(i);
    }
}