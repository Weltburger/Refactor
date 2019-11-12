switch (driver.Status)
 {
 case ClientStatus.Unknown:
 return m_driverStatusNames[ClientStatus.Unknown];
 case ClientStatus.Free:
 return m_driverStatusNames[ClientStatus.Free];
 case ClientStatus.Busy:
 return m_driverStatusNames[ClientStatus.Busy];
 case ClientStatus.InWay:
 return m_driverStatusNames[ClientStatus.InWay];
 case ClientStatus.Work:
 return m_driverStatusNames[ClientStatus.Work];
 case ClientStatus.Break:
 return m_driverStatusNames[ClientStatus.Break];
 case ClientStatus.Alarm:
 return m_driverStatusNames[ClientStatus.Alarm];
}

m_driverStatusNames[driver.Status]
