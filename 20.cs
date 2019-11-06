public bool CheckPath(string path)
{
 int n;
 n = 0;
 //Проверяем наличие нужных папок;
 if (Directory.Exists(path + "SCLAD"))
 {
 n += 1;
 }
 if (Directory.Exists(path + "REAL"))
 {
 n += 1;
 }
 if (Directory.Exists(path + "DOSTAVKA"))
 {
 n += 1;
 }
 //Проверяем наличие нужных файлов
 if (File.Exists(path + "analit.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "partner.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "SCLAD\\mdoc.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "SCLAD\\mdoc.fpt"))
 {
 n += 1;
 }
 if (File.Exists(path + "SCLAD\\mdocm.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "SCLAD\\mgrup.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "SCLAD\\mlabel.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "SCLAD\\mlabel.fpt"))
 {
 n += 1;
 }
 if (File.Exists(path + "REAL\\rbookm.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "REAL\\rbook.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "REAL\\rbook.fpt"))
 {
 n += 1;
 }
 if (File.Exists(path + "DOSTAVKA\\avt.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "DOSTAVKA\\avtm.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "DOSTAVKA\\avtm.fpt"))
 {
 n += 1;
 }
 if (File.Exists(path + "DOSTAVKA\\cargo.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "DOSTAVKA\\cargom.dbf"))
 {
 n += 1;
 }
 if (File.Exists(path + "DOSTAVKA\\zamena.dbf"))
 {
 n += 1;
 }
 //Если указанная папка содержит все, что нужно
 if (n == 20)
 {
 return true;
 }
 return false;
}