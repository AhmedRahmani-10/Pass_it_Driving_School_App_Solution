Imports System.Security.Cryptography.Pkcs

Public Class AppSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadingBar.Increment(1)
        If LoadingBar.Value = 100 Then
            Me.Hide()
            Dim log = New login
            log.Show()
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub AppSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class