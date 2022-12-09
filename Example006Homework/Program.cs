Console.WriteLine("Ввидите число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 6  || Number == 7){

  Console.WriteLine("Да,сегодня выходной");

}

else if (Number < 1 || Number >7) {

  Console.WriteLine("Извините, в неделе 7 дней ");

}
else  {

  Console.WriteLine("Нет, сегодня рабочий день (не выходной)");

}


