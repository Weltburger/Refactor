//Use the Name field
string[] nameParts = customer.Name.Split(' ');
string firstName = nameParts[0];
string lastName = customer.Name.Replace(nameParts[0], "").TrimStart(' ');

//----------------------------------------------------------------

void method13(string fullName)
{
	var names = fullName.Split(' ');
	string firstName = names[0];
	string lastName = names[1];
}