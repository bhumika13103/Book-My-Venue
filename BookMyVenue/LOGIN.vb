Public Class LOGIN
    Private Sub BtnCUSTOMER_Click(sender As Object, e As EventArgs) Handles BtnCUSTOMER.Click
        CUSTOMERlogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnVENUEOWNER_Click(sender As Object, e As EventArgs) Handles BtnVENUEOWNER.Click
        VENUEOWNERlogin.Show()
        Me.Close()
    End Sub
End Class