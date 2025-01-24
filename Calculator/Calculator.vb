'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/JaceFoxman/Calculator.git

Option Explicit Off
Option Strict Off



Imports System.Runtime.Remoting.Services

Module Calculator

    Sub Main()


        Dim intVariable1 As Integer
        Dim intVariable2 As Integer
        Dim userInput As String

        'Get variables 1 & 2 from user to use in operators
        Console.Write("Enter variable 1: ")
        intVariable1 = Console.ReadLine()
        intVariable1 = CInt(intVariable1)
        Console.WriteLine()

        Console.Write("Enter variable 2: ")
        intVariable2 = Console.ReadLine()
        intVariable2 = CInt(intVariable2)
        Console.WriteLine()

        'Get user to chose what operator they want to use 
        Console.WriteLine("Choose an operator: " & vbNewLine _
                          & "1.Add " & vbNewLine _
                          & "2.Multiply")

        userInput = Console.ReadLine()
        Console.WriteLine()

        'Decison making to decided operatio based off previous user input
        If userInput = "1" Then
            Console.WriteLine($"Operator: {userInput}" & " Addition")
            Console.WriteLine($"{intVariable1} + {intVariable2} = {intVariable1 + intVariable2}")
        ElseIf userInput = "2" Then
            Console.WriteLine($"Operator: {userInput}" & " Multiply")
            Console.WriteLine($"{intVariable1} * {intVariable2} = {intVariable1 * intVariable2}")
        Else
            Console.WriteLine("Invalid Response")
        End If

    End Sub

End Module
