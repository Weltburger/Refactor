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