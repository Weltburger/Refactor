//Use the Name field
string[] nameParts = customer.Name.Split(' ');
string firstName = nameParts[0];
string lastName = customer.Name.Replace(nameParts[0], "").TrimStart(' ');