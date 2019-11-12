txtContacts.Text = "";
bool first = true;
foreach (string contact in contacts)
{
if (first != true)
txtContacts.Text += ";";
first = false;
txtContacts.Text += contact;
}

//-----------------------------------------------------------------------

void method21()
{
	txtContacts.Text = "";
	bool first = true;
	foreach (string contact in contacts)
	{
	    if (first != true)
	    {
	        txtContacts.Text += ";";
	        first = false;
	    }
	    
	    txtContacts.Text += contact;
	}
}