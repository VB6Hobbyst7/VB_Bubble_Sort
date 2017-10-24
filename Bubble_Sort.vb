'Justin Stachofsky
'Bubble Sort written for MIS 350
Module bubbleSort

    'Main subroutine for program
    Sub Main()

        Dim numberArray(100) 'Stores values to be sorted
        Dim userInput 'Stores user action
        Call generateValues(numberArray)

        Console.WriteLine("Unsorted Values:")
        Call printValues(numberArray)

        userInput = "a"
        While (userInput <> "q" Or userInput <> "s") 'Loop used to continually prompt menu if invalid command is given
            Console.WriteLine("Press 's' to sort or 'q' to exit program")
            userInput = Console.ReadLine()

            If userInput = "q" Then
                End
            ElseIf userInput = "s" Then
                Call sortValues(numberArray)
                Call printValues(numberArray)
                Console.ReadLine()
                End
            Else
                Console.WriteLine("Invalid command")
            End If
        End While

    End Sub

    'Subroutine used to fill array with values
    Sub generateValues(ByRef emptyArray)

        For i = 0 To UBound(emptyArray)
            emptyArray(i) = Int(Rnd() * 100) + 0 'Generates number between 0 and 100 and stores in array index
        Next

    End Sub

    'Subroutine used to print array
    Sub printValues(ByRef printArray)

        For i = 0 To UBound(printArray)
            Console.WriteLine(printArray(i))
        Next

    End Sub

    'Subroutine used to sort array, uses bubble sort method
    Sub sortValues(ByRef unsortedArray)
        Dim swapValue 'Holds temporary value during sort

        For i = 0 To UBound(unsortedArray)
            For j = i + 1 To UBound(unsortedArray)
                If unsortedArray(i) > unsortedArray(j) Then 'Check if i greater than so sort is 1 - 100 instead of 100 - 1
                    swapValue = unsortedArray(i)
                    unsortedArray(i) = unsortedArray(j)
                    unsortedArray(j) = swapValue
                End If
            Next
        Next

    End Sub

End Module
