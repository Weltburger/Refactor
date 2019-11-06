string mailTo = ((Config.GetSetting("AdminNotifications_EmailAddress") == null) ||
(Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0))?
Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString():
Config.GetSetting("AdminNotifications_EmailAddress");