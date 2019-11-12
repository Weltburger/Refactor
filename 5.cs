Bool IsNumber (string str) 
{
	return (str.Replace ("0", "").Replace ("1", "").Replace ("2", "").Replace
	("3", "").Replace ("4", "").Replace ("5", "").Replace ("6", "").Replace
	("7", "").Replace ("8", "").Replace ("9", "").Length == 0);
}

//---------------------------------

 bool isNumber(string s) {
	try {
		int i = Integer.parseInt(s);
	} catch (NumberFormatException e) {
		return false;
	}
		return true;
}
