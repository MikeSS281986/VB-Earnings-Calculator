Module Module1

    Sub Main()
        Dim displayMenu As Boolean = True
        While (displayMenu)
            displayMenu = MainMenu()
        End While
    End Sub

    Function MainMenu()
        Console.Clear()
        Console.Write("Choose one: Enter your hourly wage or yearly salary or exit. H\Y\E? ")
        Dim userInput As String = Console.ReadLine()
        If userInput = "h" Or userInput = "H" Then
            Return HourToYear()
        ElseIf userInput = "y" Or userInput = "Y" Then
            Return YearToHourly()
        ElseIf userInput = "e" Or userInput = "E" Then
            Return False
        Else
            Console.WriteLine("Please enter a valid entry")
            Console.ReadLine()
            Return True
        End If
    End Function

    Function HourToYear() As Integer
        Console.Clear()
        Console.Write("How much do you make an hour? Please do not enter $ symbol ")
        Dim hourlyWage As String = Console.ReadLine()
        Console.Write("How many hours do you work a week? ")
        Dim hoursWorkWeek As String = Console.ReadLine()
        Dim yearlySalary As Integer
        Convert.ToDecimal(hourlyWage)
        Convert.ToInt32(hoursWorkWeek)
        yearlySalary = ((hourlyWage * hoursWorkWeek) * 4) * 12
        Console.WriteLine("You make {0:C} a year.", yearlySalary)
        Console.ReadLine()
        Return True
    End Function

    Function YearToHourly() As Integer
        Console.Clear()
        Console.Write("How much do you make a year? ")
        Dim yearlySalary As String = Console.ReadLine()
        Dim hourlyWage
        Convert.ToInt32(yearlySalary)
        hourlyWage = ((yearlySalary / 12) / 4) / 40
        Console.WriteLine("You make {0:C} an hour.", hourlyWage)
        Console.ReadLine()
        Return True
    End Function

End Module
