string mailTo = ((Config.GetSetting("AdminNotifications_EmailAddress") == null) ||
(Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0))?
Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString():
Config.GetSetting("AdminNotifications_EmailAddress");

//---------------------------------------------------------------------------------

void method19()
{
string mailTo = condition()?setLeft():setRight();
}
bool condition()
{
    return ((Config.GetSetting("AdminNotifications_EmailAddress") == null) ||(Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0))
}
void setLeft()
{
    Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString()
}
void setRight()
{
    Config.GetSetting("AdminNotifications_EmailAddress")
}
