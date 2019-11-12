var ids = form.Keys;
if(ids.Length == 0 || ids.Length > 1) { throw Exception;}

//-------------------------

var ids = form.Keys;
if(ids.Length > 0) { throw Exception;}

//---------------------------------------------------------------------------------------

void kekException()
{
    if(isException(form.Keys)) 
        throw Exception;
}
bool isException(int a){
    return a.Length == 0 || a.Length >1
}