Public Class Form1
    Dim i As Integer
    Dim x As Integer = 1

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim b As Button() = {b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20}
       
        x = x + 1

        If x Mod 2 = 0 Then
            Button1.Text = "Stop"

        Else
            Button1.Text = "Start"
        End If

        While x Mod 2 = 0

            Dim decre As Integer = 10
            Dim incre As Integer = 1

            For Me.i = 0 To 19

                b(i).BackColor = Color.Red

                If i > 9 Then
                    b(i - 10).BackColor = Color.White
                End If
                Await Task.Delay(25)

            Next i


            While decre > 1
                b(i - decre).BackColor = Color.White
                decre -= 1
                Await Task.Delay(60)
            End While

            i = 19
            For Me.i = 19 To 0 Step -1

                b(i).BackColor = Color.Red


                If i < 11 Then
                    b(i + 9).BackColor = Color.White
                End If
                Await Task.Delay(25)

            Next i

            i = 9
            While incre < 9
                b(i - incre).BackColor = Color.White
                incre += 1
                Await Task.Delay(60)
            End While


        End While
    End Sub

    
  
   
    
End Class
