private void set_mode(bool mod)
{
 if(mod==true)
 {
 label1.Enabled=true;
 button1.Enabled=true;
 button2.Enabled=true;
 button3.Enabled=false;
 button4.Enabled=false;
 }
 else
 {
 label1.Enabled=false;
 button1.Enabled=false;
 button2.Enabled=false;
 button3.Enabled=true;
 button4.Enabled=true;
 }
}

// Есть смысл дать правильные имена кнопкам и лейблам, для более легкого восприятия кода
// Либо написать метод для изменения состояния компонента на противоположный текущему