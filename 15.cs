public string generateEMail()
{
string res;
int i = PersonName.IndexOf(" ");
char[] str1 = new char[i];
PersonName.CopyTo(0, str1, 0, i);
string str11 = new string(str1);
char[] str2 = new char[PersonName.Length - i - 1];
PersonName.CopyTo(i + 1, str2, 0, PersonName.Length-i-1);
string str22 = new string(str2);
res = str11.ToString() + "." + str22.ToString();
if (res.Length > 20)
{
str1 = new char[20];
res.CopyTo(0, str1, 0, 20);
res = new string(str1);
}
res += "@domain.ua";
return res;
}

//----------------------------------------------------------------

string generateEMail()
{
	string res;
	int i = PersonName.IndexOf(" ");
	char[] str1 = new char[i];
	PersonName.CopyTo(0, str1, 0, i);
	string str11 = new string(str1);
	char[] str2 = new char[PersonName.Length - i - 1];
	PersonName.CopyTo(i + 1, str2, 0, PersonName.Length-i-1);
	string str22 = new string(str2);
	res = str11.ToString() + "." + str22.ToString();
	if (res.Length > 20)
	{
		str1 = new char[20];
		res.CopyTo(0, str1, 0, 20);
		res = new string(str1);
	}
	res += "@domain.ua";
	return res;
}