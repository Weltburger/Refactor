foreach (string id in sourceIDs.Split(new char[] { ',' },
StringSplitOptions.RemoveEmptyEntries))
 {
 sourceId = Convert.ToInt32(id);
 break;
 }


//-----------------------------------------------------------------

 void method16()
{
	var sourceId;
	foreach (string id in sourceIDs.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries))
	{
		 sourceId = Convert.ToInt32(id);
		 break;
	}
}