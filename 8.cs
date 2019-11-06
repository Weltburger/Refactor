DateTime dt = DateTime.Now;
string h=dt.Hour.ToString().PadLeft(2,'0');
string m=dt.Minute.ToString().PadLeft(2,'0');
string s=dt.Second.ToString().PadLeft(2,'0');
Console.WriteLine("--"+h+":"+m+":"+s+"--");