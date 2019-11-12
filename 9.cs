return ((int)(Counter / 2) != Counter / 2.00 && Counter != 0);

//----------------------------------------------------------------------

bool method9(int Counter)
{
    bool f1 = Counter / 2.00 && Counter != 0;
    bool f2 = (int)(Counter / 2) != f1;
    return f2;
}