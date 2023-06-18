Public Class homepage

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Dim max As Integer = 1000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)
        Dim i As Integer = 1
        Dim number(max - 1) As Integer
        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        Timer1.Interval = number(i)
        i += 1
        ChangeImage()
    End Sub
    Private Sub ChangeImage()
        Static Dim iImage1 As Integer
        Select Case iImage1
            Case 0
                PictureBox1.Image = My.Resources.homepage4
                iImage1 += 1
            Case 1
                PictureBox1.Image = My.Resources.homepage11
                iImage1 += 1
            Case 2
                PictureBox1.Image = My.Resources.homepage2
                iImage1 += 1
            Case 3
                PictureBox1.Image = My.Resources.homepage3
                iImage1 += 1

        End Select
        Timer1.Enabled = True
    End Sub

    Private Sub BtnLOGIN_Click(sender As Object, e As EventArgs) Handles BtnLOGIN.Click
        LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub BtnREGISTER_Click(sender As Object, e As EventArgs) Handles BtnREGISTER.Click
        REGISTRATION.Show()
        Me.Close()
    End Sub
    Private Sub BtnADMIN_Click(sender As Object, e As EventArgs) Handles BtnADMIN.Click
        ADMINlogin.Show()
        Me.Close()
    End Sub

End Class