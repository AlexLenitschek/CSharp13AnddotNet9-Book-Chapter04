﻿//TimesTable(12, 255);

ConfigureConsole(useComputerCulture: true);


decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax");

// Alternatively, call the function in the interpolated string.
// WriteLine($"You must pay {CalculateTax(amount: 149, twoLetterRegionCode: "FR"):C} in tax.");

//RunCardinalToOrdinal();

//RunFactorial();

RunFibImperative();
RunFibFunctional();