Module Module1
    Sub Main()
        Dim array(10) As Integer
        Dim Temp As Integer = 0
        Dim i As Integer
        Dim half As Integer
        Dim search As Integer


        For i = 0 To UBound(array)
            array(i) = Temp
            Temp += 1
            Console.Write(array(i))
        Next

        Console.Write(vbCrLf)


        search = CInt(Console.ReadLine)
        half = UBound(array) / 2
        If search < half Then
            half = half / 2
            If search < (half + 0.5) Then
                For i = 0 To half
                    If search = i Then
                        Console.WriteLine("found at" & i)
                    End If
                Next
            ElseIf search = (half + 0.5) Then
                Console.WriteLine("found at" & half)

            ElseIf search > (half + 0.5) Then
                For i = half To UBound(array) / 2
                    If search = i Then
                        Console.WriteLine("found at" & i)
                    End If
                Next
            End If

        ElseIf search = half Then
            Console.WriteLine("found at" & half)
        ElseIf search > half Then
            half = half * 1.5
            If search < (half + 0.5) Then
                For i = UBound(array) / 2 To half
                    If search = i Then
                        Console.WriteLine("found at" & i)
                    End If
                Next
            ElseIf search = (half + 0.5) Then
                Console.WriteLine("found at" & half)

            ElseIf search > (half + 0.5) Then
                For i = half To UBound(array)
                    If search = i Then
                        Console.WriteLine("found at" & i)
                    End If
                Next
            End If
        End If


    End Sub

End Module
