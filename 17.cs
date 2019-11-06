string GetTextDiv2(string text)
 {
 int mid = text.Length / 2;
 int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
 int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;
 if (r - mid > mid - l) // to left is closer
 mid = l;
 else mid = r;
 if (mid == 5000) return "&nbsp" + text;
 return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" +
text.Substring(mid, text.Length - mid);
 }