String[] days = new String[7];
for( int i = 0; i < 7; i++ ) {
 switch(i) {
 default:
 case 0:
 days[i] = "Monday";
 break;
 case 1:
 days[i] = "Tuesday";
 break;
 case 2:
 days[i] = "Wednesday";
 break;
 case 3:
 days[i] = "Thursday";
 break;
 case 4:
 days[i] = "Friday";
 break;
 case 5:
 days[i] = "Saturday";
 break;
 case 6:
 days[i] = "Sunday";
 break;
 }
}

//------------------------------------

String[] days = new String[7];
for( int i = 0; i < 7; i++ ) 
{
	days[i] = selectDay(i);
}

private string selectDay(int a)
{
	 switch(i) 
	 {
		 default:
		 case 0:
			 return "Monday";
			 break;
		 case 1:
			 return "Tuesday";
			 break;
		 case 2:
			 return "Wednesday";
			 break;
		 case 3:
			 return "Thursday";
			 break;
		 case 4:
			 return "Friday";
			 break;
		 case 5:
			 return "Saturday";
			 break;
		 case 6:
			 return "Sunday";
			 break;
 	}
}

//-------------------------------

 string days = {"Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday", "Sunday"};